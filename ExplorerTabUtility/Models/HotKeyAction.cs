using System.ComponentModel;
using System.Text.Json.Serialization;
using ExplorerTabUtility.Helpers;

namespace ExplorerTabUtility.Models;

[JsonConverter(typeof(HotKeyActionJsonConverter))]
public enum HotKeyAction
{
    [Description("打开指定位置")]
    Open,
    [Description("复制当前标签")]
    Duplicate,
    [Description("重新打开最后关闭的位置")]
    ReopenClosed,
    [Description("打开标签搜索弹窗")]
    TabSearch,
    [Description("后退")]
    NavigateBack,
    [Description("上一级")]
    NavigateUp,
    [Description("前进")]
    NavigateForward,
    [Description("设为新标签目标窗口")]
    SetTargetWindow,
    [Description("开关窗口重定向")]
    ToggleWinHook,
    [Description("开关标签复用")]
    ToggleReuseTabs,
    [Description("显示/隐藏主界面")]
    ToggleVisibility,
    [Description("分离当前标签")]
    DetachTab,
    [Description("窗口右贴边")]
    SnapRight,
    [Description("窗口左贴边")]
    SnapLeft,
    [Description("窗口上贴边")]
    SnapUp,
    [Description("窗口下贴边")]
    SnapDown
}