# C#上位机开发串口通信编程

## 资料来源

- 杜洋工作室：C# 上位机开发串口通信编程
- B站搜索：C# 上位机开发串口通信编程
- 参考网址：https://www.bilibili.com/video/BV1Rx411R71p/?p=2&spm_id_from=pageDriver&vd_source=5ac76088cfc54cf5d53fc595b231551d

## 程序代码

- 开发环境：VS2022
- 源程序文件夹：..\HostComputer

## 倒计时程序

- 新的内容：
  - 1、添加定时器；定时器打开，关闭
    - timer1
  - 2、进度条；更新
    - progressBar1
  - 3、提示音；播放系统提示音
    - System.Media.SystemSounds.Asterisk.Play()

- 程序代码："..\HostComputer\HostComputerTimer"

## 串口编程 - 只有发送

- 新的内容：
  - 1、WinForm 窗体里面没有 seriaPort 控件；
    - 创建工程的时候，应该选择 WinForm(.NET firmware) 的窗体工程
  - 2、MessageBox 可以设置标题
    - MessageBox.Show("串口打开错误！！","自定义标题");

- 程序代码："..\HostComputer\HostComputerUsart.Net"
