﻿using DownKyi.Core.BiliApi.Login;
using DownKyi.Core.BiliApi.Users;
using DownKyi.Core.BiliApi.Users.Models;
using DownKyi.Core.Storage;
using DownKyi.CustomControl;
using DownKyi.Events;
using DownKyi.Images;
using DownKyi.Utils;
using DownKyi.ViewModels.PageViewModels;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DownKyi.ViewModels
{
    public class ViewMySpaceViewModel : BaseViewModel
    {
        public const string Tag = "PageMySpace";

        // mid
        private long mid = -1;

        #region 页面属性申明

        private VectorImage arrowBack;
        public VectorImage ArrowBack
        {
            get => arrowBack;
            set => SetProperty(ref arrowBack, value);
        }

        private VectorImage logout;
        public VectorImage Logout
        {
            get => logout;
            set => SetProperty(ref logout, value);
        }

        private GifImage loading;
        public GifImage Loading
        {
            get => loading;
            set => SetProperty(ref loading, value);
        }

        private Visibility noDataVisibility;
        public Visibility NoDataVisibility
        {
            get => noDataVisibility;
            set => SetProperty(ref noDataVisibility, value);
        }

        private Visibility loadingVisibility;
        public Visibility LoadingVisibility
        {
            get => loadingVisibility;
            set => SetProperty(ref loadingVisibility, value);
        }

        private Visibility viewVisibility;
        public Visibility ViewVisibility
        {
            get => viewVisibility;
            set => SetProperty(ref viewVisibility, value);
        }

        private Visibility contentVisibility;
        public Visibility ContentVisibility
        {
            get => contentVisibility;
            set => SetProperty(ref contentVisibility, value);
        }

        private string topNavigationBg;
        public string TopNavigationBg
        {
            get => topNavigationBg;
            set => SetProperty(ref topNavigationBg, value);
        }

        private BitmapImage background;
        public BitmapImage Background
        {
            get => background;
            set => SetProperty(ref background, value);
        }

        private BitmapImage header;
        public BitmapImage Header
        {
            get => header;
            set => SetProperty(ref header, value);
        }

        private string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        private BitmapImage sex;
        public BitmapImage Sex
        {
            get => sex;
            set => SetProperty(ref sex, value);
        }

        private BitmapImage level;
        public BitmapImage Level
        {
            get => level;
            set => SetProperty(ref level, value);
        }

        private Visibility vipTypeVisibility;
        public Visibility VipTypeVisibility
        {
            get => vipTypeVisibility;
            set => SetProperty(ref vipTypeVisibility, value);
        }

        private string vipType;
        public string VipType
        {
            get => vipType;
            set => SetProperty(ref vipType, value);
        }

        private string sign;
        public string Sign
        {
            get => sign;
            set => SetProperty(ref sign, value);
        }

        private VectorImage coinIcon;
        public VectorImage CoinIcon
        {
            get => coinIcon;
            set => SetProperty(ref coinIcon, value);
        }

        private string coin;
        public string Coin
        {
            get => coin;
            set => SetProperty(ref coin, value);
        }

        private VectorImage moneyIcon;
        public VectorImage MoneyIcon
        {
            get => moneyIcon;
            set => SetProperty(ref moneyIcon, value);
        }

        private string money;
        public string Money
        {
            get => money;
            set => SetProperty(ref money, value);
        }

        private VectorImage bindingEmail;
        public VectorImage BindingEmail
        {
            get => bindingEmail;
            set => SetProperty(ref bindingEmail, value);
        }

        private Visibility bindingEmailVisibility;
        public Visibility BindingEmailVisibility
        {
            get => bindingEmailVisibility;
            set => SetProperty(ref bindingEmailVisibility, value);
        }

        private VectorImage bindingPhone;
        public VectorImage BindingPhone
        {
            get => bindingPhone;
            set => SetProperty(ref bindingPhone, value);
        }

        private Visibility bindingPhoneVisibility;
        public Visibility BindingPhoneVisibility
        {
            get => bindingPhoneVisibility;
            set => SetProperty(ref bindingPhoneVisibility, value);
        }

        private string levelText;
        public string LevelText
        {
            get => levelText;
            set => SetProperty(ref levelText, value);
        }

        private string currentExp;
        public string CurrentExp
        {
            get => currentExp;
            set => SetProperty(ref currentExp, value);
        }

        private int expProgress;
        public int ExpProgress
        {
            get => expProgress;
            set => SetProperty(ref expProgress, value);
        }

        private int maxExp;
        public int MaxExp
        {
            get => maxExp;
            set => SetProperty(ref maxExp, value);
        }

        private ObservableCollection<SpaceItem> statusList;
        public ObservableCollection<SpaceItem> StatusList
        {
            get => statusList;
            set => SetProperty(ref statusList, value);
        }

        private ObservableCollection<SpaceItem> packageList;
        public ObservableCollection<SpaceItem> PackageList
        {
            get => packageList;
            set => SetProperty(ref packageList, value);
        }

        private int selectedPackage;
        public int SelectedPackage
        {
            get => selectedPackage;
            set => SetProperty(ref selectedPackage, value);
        }

        #endregion

        public ViewMySpaceViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            #region 属性初始化

            // 返回按钮
            ArrowBack = NavigationIcon.Instance().ArrowBack;
            ArrowBack.Fill = DictionaryResource.GetColor("ColorTextDark");

            // 退出登录按钮
            Logout = NavigationIcon.Instance().Logout;
            Logout.Fill = DictionaryResource.GetColor("ColorTextDark");

            // 初始化loading gif
            Loading = new GifImage(Properties.Resources.loading);
            Loading.StartAnimate();

            TopNavigationBg = "#00FFFFFF"; // 透明

            // B站图标
            CoinIcon = NormalIcon.Instance().CoinIcon;
            CoinIcon.Fill = DictionaryResource.GetColor("ColorPrimary");
            MoneyIcon = NormalIcon.Instance().MoneyIcon;
            MoneyIcon.Fill = DictionaryResource.GetColor("ColorMoney");
            BindingEmail = NormalIcon.Instance().BindingEmail;
            BindingEmail.Fill = DictionaryResource.GetColor("ColorPrimary");
            BindingPhone = NormalIcon.Instance().BindingPhone;
            BindingPhone.Fill = DictionaryResource.GetColor("ColorPrimary");

            StatusList = new ObservableCollection<SpaceItem>();
            PackageList = new ObservableCollection<SpaceItem>();

            #endregion
        }

        #region 命令申明

        // 返回事件
        private DelegateCommand backSpaceCommand;
        public DelegateCommand BackSpaceCommand => backSpaceCommand ?? (backSpaceCommand = new DelegateCommand(ExecuteBackSpace));

        /// <summary>
        /// 返回事件
        /// </summary>
        private void ExecuteBackSpace()
        {
            NavigationParam parameter = new NavigationParam
            {
                ViewName = ParentView,
                ParentViewName = null,
                Parameter = null
            };
            eventAggregator.GetEvent<NavigationEvent>().Publish(parameter);
        }

        // 退出登录事件
        private DelegateCommand logoutCommand;
        public DelegateCommand LogoutCommand => logoutCommand ?? (logoutCommand = new DelegateCommand(ExecuteLogoutCommand));

        /// <summary>
        /// 退出登录事件
        /// </summary>
        private void ExecuteLogoutCommand()
        {
            // 注销
            LoginHelper.Logout();

            // 返回上一页
            NavigationParam parameter = new NavigationParam
            {
                ViewName = ParentView,
                ParentViewName = null,
                Parameter = "logout"
            };
            eventAggregator.GetEvent<NavigationEvent>().Publish(parameter);
        }

        // 页面选择事件
        private DelegateCommand packageListCommand;
        public DelegateCommand PackageListCommand => packageListCommand ?? (packageListCommand = new DelegateCommand(ExecutePackageListCommand));

        /// <summary>
        /// 页面选择事件
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecutePackageListCommand()
        {
            if (SelectedPackage == -1)
            {
                return;
            }

            switch (SelectedPackage)
            {
                case 0:
                    Console.WriteLine(SelectedPackage);
                    break;
                case 1:
                    Console.WriteLine(SelectedPackage);
                    break;
                case 2:
                    Console.WriteLine(SelectedPackage);
                    break;
                case 3:
                    Console.WriteLine(SelectedPackage);
                    break;
                default:
                    break;
            }

            SelectedPackage = -1;
        }

        #endregion

        /// <summary>
        /// 初始化页面
        /// </summary>
        private void InitView()
        {
            TopNavigationBg = "#00FFFFFF"; // 透明
            ArrowBack.Fill = DictionaryResource.GetColor("ColorTextDark");
            Logout.Fill = DictionaryResource.GetColor("ColorTextDark");
            Background = null;

            Header = null;
            UserName = "";
            Sex = null;
            Level = null;
            VipTypeVisibility = Visibility.Collapsed;
            VipType = "";
            Sign = "";

            Coin = "0.0";
            Money = "0.0";

            LevelText = "";
            CurrentExp = "--/--";

            StatusList.Clear();
            StatusList.Add(new SpaceItem { Title = "关注数", Subtitle = "--" });
            StatusList.Add(new SpaceItem { Title = "悄悄关注数", Subtitle = "--" });
            StatusList.Add(new SpaceItem { Title = "粉丝数", Subtitle = "--" });
            StatusList.Add(new SpaceItem { Title = "黑名单数", Subtitle = "--" });
            StatusList.Add(new SpaceItem { Title = "节操值", Subtitle = "--" });
            StatusList.Add(new SpaceItem { Title = "封禁状态", Subtitle = "N/A" });

            PackageList.Clear();
            PackageList.Add(new SpaceItem { Image = NormalIcon.Instance().FavoriteOutline, Title = "收藏夹" });
            PackageList.Add(new SpaceItem { Image = NormalIcon.Instance().BangumiFollow, Title = "我的订阅" });
            PackageList.Add(new SpaceItem { Image = NormalIcon.Instance().Toview, Title = "稍后再看" });
            PackageList.Add(new SpaceItem { Image = NormalIcon.Instance().History, Title = "历史记录" });
            NormalIcon.Instance().FavoriteOutline.Fill = DictionaryResource.GetColor("ColorPrimary");
            NormalIcon.Instance().BangumiFollow.Fill = DictionaryResource.GetColor("ColorPrimary");
            NormalIcon.Instance().Toview.Fill = DictionaryResource.GetColor("ColorPrimary");
            NormalIcon.Instance().History.Fill = DictionaryResource.GetColor("ColorPrimary");

            SelectedPackage = -1;

            ContentVisibility = Visibility.Collapsed;
            ViewVisibility = Visibility.Collapsed;
            LoadingVisibility = Visibility.Visible;
            NoDataVisibility = Visibility.Collapsed;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        private async void UpdateSpaceInfo()
        {
            bool isNoData = true;
            Uri toutuUri = null;
            string headerUri = null;
            Uri sexUri = null;
            Uri levelUri = null;

            await Task.Run(() =>
            {

                // 背景图片
                SpaceSettings spaceSettings = UserSpace.GetSpaceSettings(mid);
                if (spaceSettings != null)
                {
                    StorageCover storageCover = new StorageCover();
                    string toutu = storageCover.GetCover($"https://i0.hdslb.com/{spaceSettings.Toutu.Limg}");
                    toutuUri = new Uri(toutu);
                }
                else
                {
                    toutuUri = new Uri("pack://application:,,,/Resources/backgound/9-绿荫秘境.png");
                }

                // 我的用户信息
                MyInfo myInfo = UserInfo.GetMyInfo();
                if (myInfo != null)
                {
                    isNoData = false;

                    // 头像
                    StorageHeader storageHeader = new StorageHeader();
                    headerUri = storageHeader.GetHeader(mid, myInfo.Name, myInfo.Face);
                    // 用户名
                    UserName = myInfo.Name;
                    // 性别
                    if (myInfo.Sex == "男")
                    {
                        sexUri = new Uri($"pack://application:,,,/Resources/sex/male.png");
                    }
                    else if (myInfo.Sex == "女")
                    {
                        sexUri = new Uri($"pack://application:,,,/Resources/sex/female.png");
                    }
                    // 显示vip信息
                    if (myInfo.Vip.Label.Text == null || myInfo.Vip.Label.Text == "")
                    {
                        VipTypeVisibility = Visibility.Collapsed;
                    }
                    else
                    {
                        VipTypeVisibility = Visibility.Visible;
                        VipType = myInfo.Vip.Label.Text;
                    }
                    // 等级
                    levelUri = new Uri($"pack://application:,,,/Resources/level/lv{myInfo.Level}.png");
                    // 签名
                    Sign = myInfo.Sign;
                    // 绑定邮箱&手机
                    if (myInfo.EmailStatus == 0)
                    { BindingEmailVisibility = Visibility.Collapsed; }
                    if (myInfo.TelStatus == 0)
                    { BindingPhoneVisibility = Visibility.Collapsed; }
                    // 等级
                    LevelText = $"{DictionaryResource.GetString("Level")}{myInfo.LevelExp.CurrentLevel}";
                    if (myInfo.LevelExp.NextExp == -1)
                    {
                        CurrentExp = $"{myInfo.LevelExp.CurrentExp}/--";
                    }
                    else
                    {
                        CurrentExp = $"{myInfo.LevelExp.CurrentExp}/{myInfo.LevelExp.NextExp}";
                    }
                    // 经验
                    MaxExp = myInfo.LevelExp.NextExp;
                    ExpProgress = myInfo.LevelExp.CurrentExp;
                    // 节操值
                    StatusList[4].Subtitle = myInfo.Moral.ToString();
                    // 封禁状态                   
                    if (myInfo.Silence == 0)
                    { StatusList[5].Subtitle = "正常"; }
                    else if (myInfo.Silence == 1)
                    { StatusList[5].Subtitle = "封停"; }
                }
                else
                {
                    // 没有数据
                    isNoData = true;
                }

            });

            if (isNoData)
            {
                TopNavigationBg = "#00FFFFFF"; // 透明
                ArrowBack.Fill = DictionaryResource.GetColor("ColorTextDark");
                Logout.Fill = DictionaryResource.GetColor("ColorTextDark");
                Background = null;

                ViewVisibility = Visibility.Collapsed;
                LoadingVisibility = Visibility.Collapsed;
                NoDataVisibility = Visibility.Visible;
                return;
            }
            else
            {
                // 头像
                StorageHeader storageHeader = new StorageHeader();
                Header = storageHeader.GetHeaderThumbnail(headerUri, 64, 64);
                // 性别
                Sex = new BitmapImage(sexUri);
                // 等级
                Level = new BitmapImage(levelUri);

                ArrowBack.Fill = DictionaryResource.GetColor("ColorText");
                Logout.Fill = DictionaryResource.GetColor("ColorText");
                TopNavigationBg = DictionaryResource.GetColor("ColorMask100");
                Background = new BitmapImage(toutuUri);

                ViewVisibility = Visibility.Visible;
                LoadingVisibility = Visibility.Collapsed;
                NoDataVisibility = Visibility.Collapsed;
            }

            await Task.Run(() =>
            {
                // 导航栏信息
                UserInfoForNavigation navData = UserInfo.GetUserInfoForNavigation();
                if (navData != null)
                {
                    ContentVisibility = Visibility.Visible;

                    // 硬币
                    Coin = navData.Money == 0 ? "0.0" : navData.Money.ToString("F1");
                    // B币
                    Money = navData.Wallet.BcoinBalance == 0 ? "0.0" : navData.Wallet.BcoinBalance.ToString("F1");
                }

                //用户的关系状态数
                UserRelationStat relationStat = UserStatus.GetUserRelationStat(mid);
                if (relationStat != null)
                {
                    // 关注数
                    StatusList[0].Subtitle = relationStat.Following.ToString();
                    // 悄悄关注数
                    StatusList[1].Subtitle = relationStat.Whisper.ToString();
                    // 粉丝数
                    StatusList[2].Subtitle = relationStat.Follower.ToString();
                    // 黑名单数
                    StatusList[3].Subtitle = relationStat.Black.ToString();
                }
            });

        }

        /// <summary>
        /// 接收mid参数
        /// </summary>
        /// <param name="navigationContext"></param>
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            // 根据传入参数不同执行不同任务
            long parameter = navigationContext.Parameters.GetValue<long>("Parameter");
            if (parameter == 0)
            {
                return;
            }
            mid = parameter;

            InitView();
            UpdateSpaceInfo();
        }

    }
}
