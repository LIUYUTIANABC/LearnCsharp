# 工作中有用的项目

- [工作中有用的项目](#工作中有用的项目)
  - [SerialPort](#serialport)
    - [实例化 SerialPort 对象](#实例化-serialport-对象)
    - [编写串口接收和发送的程序](#编写串口接收和发送的程序)

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
