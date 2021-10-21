﻿using DownKyi.Core.BiliApi.VideoStream.Models;
using DownKyi.Core.Logging;
using Newtonsoft.Json;
using System;

namespace DownKyi.Core.BiliApi.VideoStream
{
    public static class VideoStream
    {

        /// <summary>
        /// 获取普通视频的视频流
        /// </summary>
        /// <param name="avid"></param>
        /// <param name="bvid"></param>
        /// <param name="cid"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public static PlayUrl GetVideoPlayUrl(long avid, string bvid, long cid, int quality = 125)
        {
            string baseUrl = $"https://api.bilibili.com/x/player/playurl?cid={cid}&qn={quality}&fourk=1&fnver=0&fnval=80";
            string url;
            if (bvid != null) { url = $"{baseUrl}&bvid={bvid}"; }
            else if (avid > -1) { url = $"{baseUrl}&aid={avid}"; }
            else { return null; }

            return GetPlayUrl(url);
        }

        /// <summary>
        /// 获取番剧的视频流
        /// </summary>
        /// <param name="avid"></param>
        /// <param name="bvid"></param>
        /// <param name="cid"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public static PlayUrl GetBangumiPlayUrl(long avid, string bvid, long cid, int quality = 125)
        {
            string baseUrl = $"https://api.bilibili.com/pgc/player/web/playurl?cid={cid}&qn={quality}&fourk=1&fnver=0&fnval=80";
            string url;
            if (bvid != null) { url = $"{baseUrl}&bvid={bvid}"; }
            else if (avid > -1) { url = $"{baseUrl}&aid={avid}"; }
            else { return null; }

            return GetPlayUrl(url);
        }

        /// <summary>
        /// 获取课程的视频流
        /// </summary>
        /// <param name="avid"></param>
        /// <param name="bvid"></param>
        /// <param name="cid"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public static PlayUrl GetCheesePlayUrl(long avid, string bvid, long cid, long episodeId, int quality = 125)
        {
            string baseUrl = $"https://api.bilibili.com/pugv/player/web/playurl?cid={cid}&qn={quality}&fourk=1&fnver=0&fnval=80";
            string url;
            if (bvid != null) { url = $"{baseUrl}&bvid={bvid}"; }
            else if (avid > -1) { url = $"{baseUrl}&aid={avid}"; }
            else { return null; }

            // 必须有episodeId，否则会返回请求错误
            if (episodeId != 0)
            {
                url += $"&ep_id={episodeId}";
            }

            return GetPlayUrl(url);
        }

        /// <summary>
        /// 获取视频流
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static PlayUrl GetPlayUrl(string url)
        {
            string referer = "https://www.bilibili.com";
            string response = WebClient.RequestWeb(url, referer);

            try
            {
                var playUrl = JsonConvert.DeserializeObject<PlayUrlOrigin>(response);
                if (playUrl == null) { return null; }
                else if (playUrl.Data != null) { return playUrl.Data; }
                else if (playUrl.Result != null) { return playUrl.Result; }
                else { return null; }
            }
            catch (Exception e)
            {
                Utils.Debugging.Console.PrintLine("GetPlayUrl()发生异常: {0}", e);
                LogManager.Error("GetPlayUrl", e);
                return null;
            }
        }

    }
}
