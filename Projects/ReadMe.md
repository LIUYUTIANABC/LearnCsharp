# 工作中有用的项目

- [工作中有用的项目](#工作中有用的项目)
  - [SerialPort](#serialport)
    - [实例化 SerialPort 对象](#实例化-serialport-对象)
    - [编写串口接收和发送的程序](#编写串口接收和发送的程序)
  - [SerialPortPro\_Remake](#serialportpro_remake)
  - [SerialPortPro\_AT32-DLL](#serialportpro_at32-dll)
    - [创建类库](#创建类库)
  - [VSCode\_solution-explorer](#vscode_solution-explorer)
  - [Frame\_WPF](#frame_wpf)

## SerialPort

- 使用 VSCode 创建的 C# 的串口通信程序

创建工程：

- 参考 ..\MyApp\Program.cs 里面有详细介绍
  - 使用旧程序样式

### 实例化 SerialPort 对象

注意：实例化 SerialPort 对象的时候会报错；因为，在 VSCode 中需要添加扩展包

- 添加扩展：NuGet Packege Manager
- 参考网址：https://blog.csdn.net/liwan09/article/details/82253016

注意：安装扩展包 NuGet Packege Manager 还有一个问题

```
vscode Nuget Package Manager 提示 Versioning information could not be retrieved from the NuGet package
```

- 这时候需要修改脚本：添加 toLowerCase()
- 参考网址：https://blog.csdn.net/wdw5413/article/details/114386138

这个时候，可以创建 SerialPort 对象了

### 编写串口接收和发送的程序

- 参考网址：https://blog.csdn.net/zxy13826134783/article/details/83045341

对应程序就是 SerialPort 工程代码

## SerialPortPro_Remake

- 是在工程 SerialPort 基础上，又结合 Daniel 的代码重新做的串口按字节接收和发送的程序

## SerialPortPro_AT32-DLL

- 创建工程，调用 Daniel 写的 DGevolt.Product.AT32V1.dll 类库，使用他封装好的代码与 UART 通信
- 自己用 VSCode 创建了一个类库 myDll 也可以正常使用

### 创建类库

方法一：使用 VS 创建类库；并且在项目中引用类库

- 参考网址：https://www.cnblogs.com/xingboy/p/10287425.html#:~:text=%E4%BA%8C%E3%80%81C%23%E4%B8%AD%E8%B0%83%E7%94%A8%E8%AF%A5DLL%201%E3%80%81%E6%96%B0%E5%BB%BAWPF%E9%A1%B9%E7%9B%AEtestUseMyDll%2C%E5%9C%A8%E5%BC%95%E7%94%A8%E9%87%8C%E6%B7%BB%E5%8A%A0testMyDll%E9%A1%B9%E7%9B%AE%E5%B0%81%E8%A3%85%E5%A5%BD%E7%9A%84%E7%B1%BB%E5%BA%93%E3%80%82,2%E3%80%81%E6%8A%8ADLL%E6%94%BE%E5%9C%A8%E9%A1%B9%E7%9B%AE%E6%96%87%E4%BB%B6%E5%A4%B9%E7%9A%84bin%E7%9B%AE%E5%BD%95%E7%9A%84Debug%E7%9B%AE%E5%BD%95%E4%B8%8B%203%E3%80%81%E7%82%B9%E5%87%BB%E9%A1%B9%E7%9B%AE%E9%87%8C%E7%9A%84%E5%BC%95%E7%94%A8%E6%B7%BB%E5%8A%A0DLL

- 创建类库：新建项目 -- 类库 -- 创建 -- build之后 -- 在 bin/debug 中生成 dll 文件
- 引用类库：新建 form 应用 -- 引用 -- 添加引用 -- COM -- 浏览 -- 选择自己的 dll -- 就可以调用 dll 里面的类了

方法二：使用 VSCode 创建类库；并且在项目中引用类库

- 参考网址：https://blog.csdn.net/qq_36848370/article/details/103913082
- 首先，安装插件 vscode-solution-explorer 解决方案资源管理器
  - 这个插件可以像在 VS 里面一样创建不同的项目；比如 窗体，控制台，类库等
  - 创建解决方案 -- 创建新工程 -- 类库 -- 添加方法 -- build -- 在 bin/debug 中生成 dll 文件
- 在 VSCode 项目中，引用刚才创建的类库 myDll.dll
  - 参考网址：https://www.coder.work/article/1576485
  - 第一步：把类库生成的 myDll.dll 拷贝到本地路径当中
  - 第二部：在工程项目 SerialPort.csproj 中添加 dll 引用
  - 第三部：在 Program.cs 中使用 using 包含命名空间

```
<!-- SerialPort.csproj 在对的位置插入： -->
<ItemGroup>
    <Reference Include="myDll.dll">
      <HintPath>.\myDll\myDll.dll</HintPath>
    </Reference>
</ItemGroup>
```

## VSCode_solution-explorer

- 创建的 myDll.dll 类库的源码；使用 VSCode 创建的类库
  - 注意：类库的 build 不能使用命令 dotnet run 创建 dll；
  - 必须在 solution 扩展中，右击解决方案 -- build
- 注意：使用 VSCode 创建的解决方案，在 VS 中可以打开，但是，会有很多错误；目前还不知道怎么解决

## Frame_WPF

- 参考网址：https://www.cnblogs.com/wml-it/p/14870223.html

WPF（Windows Presentation Foundation）Windows 演示基础

- 是微软推出的基于 Windows 的用户界面框架，属于.NET Framework 3.0 的一部分

- 创建 WPF 项目：创建项目 -- WPF 应用程序

生成文件介绍

- App.xmal: 程序主体，用来配置项目，指定窗体等
  - xmlns;  声明命名空间
  - StartupUri="MainWindow.xaml"  配置启动窗体
- App.xaml.cs，它是 app.xaml 的后台代码。
- MainWindow1.xmal：默认程序的主窗体。
  - 可以设置窗体属性（Title， Height, 等），添加控件（Button，Text 等）
- MainWindow1.xmal.cs 是 MainWindow1.xmal 的源码

Viewbox 组件

- ViewBox 组件的作用是缩放窗体的时候，使之有更好的布局及视觉效果
- winForm 界面控件，属于静态布局，缩放的时候，是不会变的
  - 烂代码是：一眼看不懂得代码，耦合在一起的代码，重复的代码，要重构
  - 参考网址：https://www.cnblogs.com/ramo/p/13500563.html
