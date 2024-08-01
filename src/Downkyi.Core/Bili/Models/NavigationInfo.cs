﻿namespace Downkyi.Core.Bili.Models;

public class NavigationInfo
{
    public long Mid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Header { get; set; } = string.Empty;
    public int VipStatus { get; set; } // 会员开通状态 // 0：无；1：有
    public bool IsLogin { get; set; }
}