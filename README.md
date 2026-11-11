# Explorer Tab Utility（资源管理器标签助手）

**简体中文 | [English](README.en.md)**

> [!IMPORTANT]
> 本仓库是社区**非官方中文汉化版**。原项目版权归 [w4po](https://github.com/w4po) 所有，遵循 MIT 许可；本仓库仅将界面文案与文档翻译为简体中文，未改动程序逻辑。遇到功能问题请以原项目为准。

> [!TIP]
> 让 Windows 11 中把新打开的资源管理器窗口强制并入标签页，工作流更清爽、更有条理！

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ExplorerTabUtilityLogo.gif" alt="Explorer Tab Utility Logo">

  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
  [![Windows 11](https://img.shields.io/badge/Windows%2011-22H2+-blue.svg)](https://www.microsoft.com/windows/windows-11)
  [![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download)
  [![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-purple.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
</div>

> [!IMPORTANT]
> 本程序要求 Windows 11（22H2 Build 22621 及以上）且资源管理器已具备标签页功能。

## 🤔 为什么需要它？

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TheWhy.png" alt="Why use Explorer Tab Utility">
</div>

满桌面都是资源管理器窗口？本工具会把新开的窗口自动并成标签页，让文件管理更整洁。

## ✨ 功能

<details>
<summary>🔄 窗口自动转标签页</summary>

- 无缝地把新开的资源管理器窗口并入标签页
- 若该路径已在标签中打开，直接切换过去
- 支持用快捷键切换虚拟桌面
- 支持标签的附加与分离
- 妥善处理“在文件夹中显示”这类带选中项的调用
- 支持一次打开多个标签

**效果演示：**
![Window to tab conversion](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/WindowToTab.gif)
</details>

<details>
<summary>🖨️ 复制当前标签</summary>

- 快速复制当前标签或窗口
- 可选复制成标签还是新窗口（切换 `Tab` 选项）
- 保留当前位置与已选中的项目

**效果演示：**
![Duplicate current tab](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DuplicateTab.gif)
</details>

<details>
<summary>♻️ 恢复已关闭的标签</summary>

- 重新打开此前关闭的标签或窗口
- 可选以标签还是新窗口恢复（切换 `Tab` 选项）
- 还原精确路径与选中项
- 程序重启后历史仍保留（需在设置中开启“保存已关闭历史”）

**效果演示：**
![Reopen closed tabs](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ReopenClosedTab.gif)
</details>

<details>
<summary>🔄 恢复上次的窗口</summary>

- 资源管理器重启/崩溃或系统重启后，自动恢复之前打开的窗口
- 通过“恢复上次的窗口”开关控制
- 首次启动会弹确认框，由你决定是否恢复

![Restore Previous Windows](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/RestorePrevious.png)
</details>

<details>
<summary>📋 标签分离与窗口贴边</summary>

- 把当前标签分离成独立窗口
- 窗口可贴到屏幕四边（右/左/上/下）
- 一个快捷键可串联多个动作
- 示例（CTRL + Q）：
  1. 第一个配置：分离当前标签
  2. 第二个配置：原窗口左贴边
  3. 第三个配置：新窗口右贴边（可设置延迟）
- 延迟可按你机器的性能自行微调

**效果演示：**
![Detach & Snap](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DetachSnap.gif)
</details>

<details>
<summary>⬅️ 前进与后退导航</summary>

- 在资源管理器中前进/后退/上一级：
  - 键盘快捷键（可自定义）
  - 在文件夹空白处点鼠标
- 目录之间来回切换非常顺手

**效果演示：**
![Navigate back/up](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/NavigateBack.gif)
</details>

<details>
<summary>📁 自定义路径导航</summary>

- 给常用位置绑快捷键，一键打开
- 可选以标签还是新窗口打开（切换 `Tab` 选项）
- 支持多种写法：
  - 普通路径：`C:\Users\Documents`
  - 环境变量：`%USERPROFILE%\Downloads`
  - Windows CLSID 路径：`{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}`（特殊文件夹）
  - 程序与文件：`C:\file.txt`
  - 网址：`https://github.com/w4po/ExplorerTabUtility`（用默认浏览器打开）
- 适合高频目录
- 用 CLSID 可直达系统文件夹

**效果演示：**
![Custom location](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/CustomLocation.gif)
</details>

<details>
<summary>🔍 标签搜索与切换</summary>

- 在已打开的标签/窗口之间快速查找并切换
- 输入文件夹名或路径片段即可搜索
- 上下方向键选择，回车确认
- 不同修饰键行为不同：
  - 默认：切到已有标签，或以新标签打开该位置
  - SHIFT：以新窗口打开所选位置，而不是标签
  - CTRL：即使已存在也再复制一个标签
- 一键清空最近关闭的历史

![Tab Search](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TabSearch.gif)
</details>

<details>
<summary>🪟 Ctrl+Shift 强制新开窗口</summary>

- 打开位置时按住 Ctrl+Shift，即强制以新窗口打开
- 临时覆盖窗口重定向与标签复用设置
- 适合偶尔需要独立窗口、又不想关掉标签功能的场景
</details>

<details>
<summary>⚡ 性能与稳定性</summary>

- 轻量，资源占用低
- 标签创建快、响应快
- 基于 COM 的稳定实现
- 窗口状态管理可靠
</details>

## 🚀 开始使用

1. 从 [Releases](https://github.com/w4po/ExplorerTabUtility/releases) 下载最新版，或用 `winget` / `choco` 安装：
    ```powershell
    winget install w4po.ExplorerTabUtility --interactive
    ```
    ```powershell
    choco install explorertabutility --version 2.5.0 --params "/interactive"
    ```
2. 运行程序
3. 看到托盘图标即可用了

    ![Menu](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Menu.png)

## ⚙️ 配置

> [!NOTE]
> 程序默认最小化在通知区域运行。
> 双击或右键托盘图标即可进入设置。

<details>
<summary>🔧 常规设置</summary>

- **窗口重定向**：开关“新窗口自动转标签页”
- **复用标签**：已存在同路径时切换过去，而不是再开一个
- **键盘监听**：开关键盘快捷键
- **鼠标监听**：开关鼠标导航功能
- **开机自启**：配置随 Windows 启动
- **配置保存位置**：
  * 设置保存在 AppData 下的 JSON 文件里：
  ```
  %APPDATA%\ExplorerTabUtility\settings.json
  ```
  想恢复默认，删掉这个文件即可。
</details>

<details>
<summary>⚙️ 偏好设置</summary>

- **自动更新**：启动时检查新版本
- **我有主题显示问题**：改用另一种隐藏窗口方式，保留你自定义的资源管理器主题；遇到主题相关异常时开启
- **保存已关闭历史**：记录关闭过的窗口，便于之后重新打开（供“恢复关闭”与“标签搜索”使用）
- **恢复上次的窗口**：重启或崩溃后恢复之前打开的窗口
- **隐藏托盘图标**：不在通知区域显示图标，任务栏更干净
  * 开启前必须先给 `ToggleVisibility` 动作配好快捷键

![Preferences](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Preferences.png)
</details>

<details>
<summary>⌨️ 快捷键配置管理</summary>

### 配置条目操作
- 新建配置
- 从文件导入配置
- 导出配置到文件
- 单条配置单独启用/停用

### 每条配置的内容
1. **基础项**
   - 快捷键：设置组合键（支持修饰键）
   - 作用域：全局（系统范围）或仅资源管理器
   - 动作类型：
     - `Open`：打开指定位置
     - `Duplicate`：复制当前标签
     - `ReopenClosed`：重新打开最后关闭的位置
     - `TabSearch`：打开标签搜索/切换弹窗
     - `NavigateBack`：当前标签内后退
     - `NavigateForward`：当前标签内前进
     - `NavigateUp`：上一级目录
     - `SetTargetWindow`：把当前窗口标记为新标签的接收窗口
     - `ToggleWinHook`：开关窗口重定向
     - `ToggleReuseTabs`：开关标签复用
     - `ToggleVisibility`：显示/隐藏主界面
     - `DetachTab`：把当前标签分离成新窗口
     - `Snap`：窗口贴到屏幕四边（右/左/上/下）
   - 路径字段（仅 `Open` 动作）
     - 可留空，留空即打开新标签
     - 支持多种路径写法（见“自定义路径导航”）

2. **高级设置**
   - 执行延迟：滑块设置动作执行前的等待
   - 按键处理：是否把快捷键继续传给其他程序
   - 删除配置：移除不需要的配置条目

![Form](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Form.png)

> [!TIP]
> 用“拦截”开关决定是否阻止其他程序也收到同一组快捷键。

> [!NOTE]
> `SetTargetWindow` 用来指定由哪个资源管理器窗口接收新标签。开了多个窗口或跨虚拟桌面工作时特别有用。
</details>

## 🔧 技术细节

<details>
<summary>实现概览</summary>

### 核心组成

#### 1. 🔌 COM 集成
- 通过原生 COM 接口直接操作 Windows Shell：
  - `Shell32`：外壳核心功能与文件系统操作
  - `SHDocVw`：资源管理器窗口与标签管理
  - 自定义 COM 接口实现，保证外壳交互稳定
- 高效处理 PIDL（Pointer to ID List）以完成文件系统操作
- 线程安全的 COM 对象生命周期管理

#### 2. 🪟 窗口管理
- 进阶的窗口跟踪与状态管理：
  - 并发集合实现线程安全的窗口跟踪
  - 标签句柄缓存与校验
  - 智能的窗口转标签判断
- 支持特殊文件夹（CLSID 路径）导航

#### 3. ⚡ 进程与事件
- 稳定的资源管理器进程监控：
  - 崩溃后自动恢复
  - 事件驱动架构，界面响应及时
  - 高效的窗口事件挂接
- 异步处理：
  - STA（单线程套间）任务调度器
  - 非阻塞的 COM 操作
  - 用 SemaphoreSlim 做正确同步

#### 4. 🚀 性能优化
- 多级缓存：
  - 窗口句柄缓存
  - 路径比较优化
  - 标签状态跟踪
- 资源管理：
  - COM 对象正确释放
  - 内存友好的集合
  - 尽量减少窗口重建

#### 5. 🎨 现代界面
- 基于 WPF 的现代界面：
  - XAML 组件，布局与样式更灵活
  - 独立 XAML 文件维护主题与样式
  - 与 Windows 11 设计语言一致
- 托盘集成增强：
  - 基于 WPF 的 TaskbarIcon
  - XAML 右键菜单，采用 Win11 图标风格
  - 自定义图标与悬停反馈
- 标签搜索弹窗，风格现代、支持键盘操作
- “关于”页面含开发者信息与支持方式

### 关键技术
- .NET 9 与 .NET Framework 4.8.1
- Windows COM API
  - Shell32 与 SHDocVw 接口
  - 原生 P/Invoke
- 基于 STA 调度器的进阶线程处理
- 并发集合保证线程安全
- WPF（Windows Presentation Foundation）实现现代界面
</details>

## 🗑️ 卸载

按安装方式选择：

- **用安装包安装的**：走 Windows 标准卸载
  - “设置 > 应用 > 已安装的应用”
  - 找到 “Explorer Tab Utility”，点“卸载”
  - 或用控制面板 > 程序和功能
  - 也可直接运行安装目录里的卸载程序

- **用 winget 安装的**：
  ```powershell
  winget uninstall w4po.ExplorerTabUtility
  ```

- **用 Chocolatey 安装的**：
  ```powershell
  choco uninstall explorertabutility
  ```

- **便携版**：直接删除程序文件夹
  - 若开过“开机自启”，删除前先关掉

## 杀毒软件误报

> [!WARNING]
> 本工具可能被杀毒软件判定为可疑，这是**误报**，原因是我们使用了：
> - COM 交互（管理资源管理器标签）
> - 低级键盘与鼠标钩子（实现快捷键）
>
> 项目完全开源，你可以：
> - 在本仓库审阅全部源码
> - 用 Visual Studio 自行编译
> - 自行验证其安全性

### 加进 Windows Defender 排除项

若 Defender 拦截，可按以下步骤加入排除：

1. 打开“Windows 安全中心”
2. 进入“病毒和威胁防护”
3. 在“病毒和威胁防护设置”下点“管理设置”
4. 向下找到“排除项”，点“添加或删除排除项”
5. 点“添加排除项”，选择“文件夹”
6. 选中 Explorer Tab Utility 所在目录

或用 PowerShell（管理员）：
```powershell
Add-MpPreference -ExclusionPath "PATH_TO_UTILITY_FOLDER"
```

## ℹ️ 说明

> [!NOTE]
> 尽管已尽量优化，受 Windows 资源管理器自身限制，部分操作仍可能有延迟：
> - 资源管理器的标签接口没有可编程控制的正式 API
> - 某些操作本身较慢，尤其是同时操作多个窗口时
> - Windows Shell 未开放全部必要的无缝标签管理能力

在这些限制之下，本工具用可用的 Windows API 与 COM 接口做到了能做到的最好。

## 💝 支持项目

如果这个工具帮到了你，可以支持原作者继续开发：

<p align="center">
  <a href="https://github.com/sponsors/w4po">
    <img src="https://img.shields.io/badge/sponsor-30363D?style=for-the-badge&logo=GitHub-Sponsors&logoColor=#white" alt="GitHub Sponsors"/>
  </a>
  <a href="https://www.patreon.com/w4po">
    <img src="https://img.shields.io/badge/Patreon-F96854?style=for-the-badge&logo=patreon&logoColor=white" alt="Patreon"/>
  </a>
  <a href="https://www.buymeacoffee.com/w4po">
    <img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me A Coffee"/>
  </a>
  <a href="https://paypal.me/w4po77">
    <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white" alt="PayPal"/>
  </a>
</p>

你的支持让项目得以持续维护与改进 ❤️

### 赞助者与支持者

感谢所有支持本项目的朋友！

<p align="center">
  <a href="https://github.com/sponsors/w4po">
    <img src="https://cdn.jsdelivr.net/gh/w4po/sponsors/sponsors.svg" alt="Sponsors" />
  </a>
</p>

## 参与贡献

欢迎提交 issue 与 pull request。

## 许可

本项目遵循 MIT 许可，详见 [LICENSE](LICENSE)。

## 致谢

本项目使用了以下优秀的开源包：

<p align="center">
  <a href="https://github.com/HavenDV/H.Hooks">
    <img src="https://img.shields.io/badge/H.Hooks-Keyboard%20Hook-purple?style=for-the-badge" alt="H.Hooks"/>
  </a>
  <a href="https://github.com/hardcodet/wpf-notifyicon">
    <img src="https://img.shields.io/badge/Hardcodet.NotifyIcon.Wpf-System%20Tray-blue?style=for-the-badge" alt="Hardcodet NotifyIcon"/>
  </a>
</p>

- **[H.Hooks](https://github.com/HavenDV/H.Hooks)** — 高效可靠的键盘钩子实现
- **[Hardcodet.NotifyIcon.Wpf](https://github.com/hardcodet/wpf-notifyicon)** — 基于 WPF 的现代托盘图标实现

特别感谢这些包的维护者。

## 代码签名
<table>
 <tbody>
  <tr>
   <td align="center"><img alt="[SignPath]" src="https://avatars.githubusercontent.com/u/34448643" height="30"/></td>
   <td>Free code signing provided by <a href="https://signpath.io?utm_source=foundation&utm_medium=github&utm_campaign=ExplorerTabUtility">SignPath.io</a>, certificate by <a href="https://signpath.org?utm_source=foundation&utm_medium=github&utm_campaign=ExplorerTabUtility">SignPath Foundation</a></td>
  </tr>
 </tbody>
</table>
