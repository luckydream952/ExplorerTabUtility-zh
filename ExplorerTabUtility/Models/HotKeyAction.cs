using System.ComponentModel;
using System.Text.Json.Serialization;
using ExplorerTabUtility.Helpers;

namespace ExplorerTabUtility.Models;

[JsonConverter(typeof(HotKeyActionJsonConverter))]
public enum HotKeyAction
{
    [Description("打开资源管理器（新标签页）")]
    Open,
    [Description("复制当前标签")]
    Duplicate,
    [Description("重新打开最近关闭的标签")]
    ReopenClosed,
    [Description("标签搜索与切换")]
    TabSearch,
    [Description("后退")]
    NavigateBack,
    [Description("上一级")]
    NavigateUp,
    [Description("前进")]
    NavigateForward,
    [Description("设为新标签接收窗口")]
    SetTargetWindow,
    [Description("开关窗口自动转标签")]
    ToggleWinHook,
    [Description("开关复用已有标签")]
    ToggleReuseTabs,
    [Description("显示/隐藏主界面")]
    ToggleVisibility,
    [Description("分离当前标签到新窗口")]
    DetachTab,
    [Description("窗口贴右边")]
    SnapRight,
    [Description("窗口贴左边")]
    SnapLeft,
    [Description("窗口贴顶部")]
    SnapUp,
    [Description("窗口贴底部")]
    SnapDown
}