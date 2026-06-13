# YomiNet

YomiNet 是一个面向 Windows 的网络工具箱，用于查看网络状态、诊断连接问题、扫描局域网设备、批量 Ping 主机、查询 DNS 与 IP 地理位置等常见网络运维场景。

本项目基于 NETworkManager 改造，保留核心网络诊断能力，并针对中文用户、局域网排查和日常桌面使用做了定制。

## 主要功能

- 仪表盘：显示本机公网 IP、局域网 IP、DNS 解析器、网络接口等状态。
- 网络接口：查看网卡、IP、网关、DNS、连接状态等信息。
- IP 扫描：默认根据本机 IP 与子网掩码填入当前局域网网段。
- 端口扫描：默认填入本机局域网网段和常用端口。
- 多目标 Ping：支持同时 Ping 多个 IP 或域名，支持一行一个、逗号或分号分隔。
- DNS 查询：支持常见 DNS 记录查询。
- IP 地理位置：查询 IP 所属国家/地区、城市、运营商、自治系统等信息。
- WiFi：查看附近无线网络、信号强度、频段、信道等信息。
- YomiCIDR：合并子网计算器能力，用于 CIDR、子网掩码和地址范围计算。
- 其他工具：路由表、ARP 表、监听端口、连接会话、主机文件编辑、防火墙等。

## 当前定制

- 界面语言只保留中文简体和中文繁体。
- 默认语言为中文简体。
- 删除捐赠按钮和捐赠链接。
- 隐藏远程桌面、TigerVNC 和 Web 控制台功能。
- 简化并优化多 Ping、WiFi、网络接口、IP 扫描、端口扫描等界面。
- IP 地理位置和 DNS 解析器请求优先返回中文结果。
- 软件图标和启动图更换为“金毛 + 网络背景”风格。

## 运行环境

- Windows 10 22H2 或更高版本。
- .NET 10 SDK 或对应运行时。
- Visual Studio 2026 / Visual Studio 2022 新版本，或可用的 `dotnet` CLI。

## 构建方式

在仓库根目录执行：

```powershell
dotnet restore Source\YomiNet.sln
dotnet build Source\YomiNet\YomiNet.csproj -c Debug -m:1 /p:DisableBeauty=True
```

生成后的程序位于：

```text
Source\YomiNet\bin\Debug\net10.0-windows10.0.22621.0\win-x64\YomiNet.exe
```

如果本机安装了多个 .NET 版本，也可以显式调用 SDK：

```powershell
& 'C:\Program Files\dotnet\dotnet.exe' build Source\YomiNet\YomiNet.csproj -c Debug -m:1 /p:DisableBeauty=True
```

## 目录结构

```text
Source/                 主程序与类库源码
Website/                文档网站源码
Images/                 图标与图片资源
Scripts/                构建和资源生成脚本
Chocolatey/             Chocolatey 打包文件
```

## 说明

项目中的部分网络信息来自系统 API 或第三方公开接口。公网 IP、地理位置、DNS 解析器等结果会受到本机网络、代理、防火墙和接口服务可用性的影响。

本项目已移除原项目中的捐赠入口，并隐藏不需要的远程控制类功能，但仍保留原始项目的大量网络诊断模块和代码结构。

## 许可证

本项目沿用原项目许可证，详见 `LICENSE`。
