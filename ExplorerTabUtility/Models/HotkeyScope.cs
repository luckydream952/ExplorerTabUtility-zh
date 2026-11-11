using System.ComponentModel;

namespace ExplorerTabUtility.Models;

public enum HotkeyScope
{
    [Description("全局（任意位置）")]
    Global,
    [Description("仅资源管理器")]
    FileExplorer
}