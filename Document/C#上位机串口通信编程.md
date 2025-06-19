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

## 比较全面的串口调试助手

- 新的内容：
  - 1、容器 Panel 可以框起来单选框 radioButton
  - 2、GroupBox 框起来
  - 3、comboBox 也可以在在属性页添加 Items，代码添加也可以
  - 4、button1 的 Enabled 属性，设置是否可以点击

- 程序代码："..\HostComputer\HostComputerSerialCommunication"

## 串口调试助手 - 开关控制

- 新的内容：
  - 1、用 label 做指示灯，是方形的
    - 可以改变 label1.BackColor = Color.Gray; 属性，实现颜色的变化

- 程序代码："..\HostComputer\HostComputer-OnOffControl"

## 串口调试助手 - 图片按钮 和 定时开关

- 1、制作开关按钮，添加图片的形式
  - 添加图片资源
    - 工程名右击-属性-资源-添加资源-添加现有文件
    - 添加成功后，在解决方案下面有 “Resources” 表示资源
- 2、按钮使用图片替代
  - 属性：BackgroundImage 选择静态图片背景
  - 属性：BackgroundImageLayout 选择静态图片布局方式
    - Zoom 是按比例放大到合适大小
    - Center 是居中
    - Stretch 是拉伸
- 3、设置button、label等控件的背景色为透明
  - 将 button 的 backcolor 属性设置为 Transparent，该属性在web选项的第一个；
  - 将 button 的 FlatStyle 属性设置为Flat。
  - 如果还想将 button 的边框线去掉，在 button 的 FlatAppearance 属性中的BorderSize 的参数设置为 0
- 4、添加了资源，要添加事件
  - 在 Form1.Designer.cs 添加鼠标事件
    - this.button1.MouseLeave += new System.EventHandler(this.buttonl_MouseLeave)
      - 方法："buttonl_MouseLeave" 鼠标离开事件
    - this.button1.MouseHover += new System.EventHandler(this.buttonl_MouseHover)
      - 方法："buttonl_MouseHover" 鼠标停留事件
- 5、TestBox1 输入数据
  - 做文本框，输入框都可以
- 6、Timer 的注意事项
  - 定时器开启的是另一条线程，当计时结束后线程并没有结束，UI 阻塞太久，会重复进入中断
- 7、【作业】
  - 1.定时输入框可识别3位数字.
  - 2.制作定时开机的功能

- 程序代码："..\HostComputer\HostComputer-ImageButtonAndTimerOff"

## 串口调试助手 - 数据校验

- 1、校验方式：数据取反，是比较好的方式。校验成功，就点亮灯。
- 2、button 或其他控件，可以设置属性 Tag 用于区分
- 3、Visual Basic PowerPacks 这个包 VS 不支持了，没搞成功
  - 下载这个 dll 安装，然后 "工具箱右击" "添加选项卡"
  - 选项卡添加成功后，"选项卡名右击" "添加项" "选择添加的工具"
  - 导入后的工具可以在 “路径” 看到 dll 的路径
  - 注意：发布程序的时候要把这个 dll 也放到相同目录下
  - 注意：ovalShape1 的属性 FillStyle 必须为 Solid 才可以修改控件的填充颜色
- 4、【作业】
  - 1、在按下按键后变灰(不可按)
  - 2、数据发送及校验并用灯显示下位机状态

- 程序代码："..\HostComputer\HostComputer-VerificationButton"

## 串口调试助手 - 汉字编码转换

- 汉字编码知识
  - 1、Windows 的编码一般是 UTF-8 字库
  - 2、Keil, LCD12864 的编码一般是 GB2312 字库
- 要传递汉字，实际传递的是数据编码
  - UTF-8 编码： 0xE4BDA0 是 "你"; 0xE5A5BD 是 "好"; 
  - GB2312 编码:  0xC4E3 是 "你"; 0xBAC3 是 "好"; 

- 程序代码："..\HostComputer\HostComputer-EncodingGB2312"

- 串口调试助手，接收汉字
  - 1、serialPort1.Encoding = Encoding.GetEncoding("GB2312"); 修改串口助手的编码方式为 GB2312
  - 2、操作系统的串口是非实时性的，所以一次串口中断可能是多个字节
  - 3、串口接收数据，要一次性取所有缓冲区数据

- 程序代码："..\HostComputer\HostComputerSerialCommunication"

## 串口调试助手 - ADC 数据进度条显示

- GroupBox 可以设置显示隐藏
  - groupBox2.Visible = true;
- Form 可以设置 Size，改变大小
  - this.Size = new Size(620, 117);
- ProcessBar 可以设置最大值最小值，value 显示比例
  - Maximum； Minimum；
- this 关键字，是一个 Form1 类，表示是 Form1 窗体。可以设置 Form1 属性

- 程序代码："..\HostComputer\HostComputer-ADCProgressBar"

## 串口调试助手 - 10 组 ADC 数据进度条显示

- trackBar 滑块控件
  - 也可以设置最大值，最下值
- 多个相同控件的布局方式
  - 对齐，等间距的排列

- 程序代码："..\HostComputer\HostComputer-ADCProgressBar-10"

## 串口调试助手 - 保存窗体设置到 data.ini 文件

- 引入 [DllImport("kernel32")] 的函数：
  - 写入数据到 ‘data.ini’:   WritePrivateProfileString
  - 从 ‘data.ini’ 读取数据:  GetPrivateProfileString
- 获取当前文件的路径：System.AppDomain.CurrentDomain.BaseDirectory

- 程序代码："..\HostComputer\HostComputer-ADCProgressBar-10"

## 串口调试助手 - 类的介绍

- 官方教学网站，介绍类的用法  http://msdn.microsoft.com
- "类库" 的使用
- 封装成 dll 使用，动态链接库

在控制台程序中调用窗体对话框

- 控制台程序应该选择 "控制台应用（.NET Framework）" 
  - 在VS中 -- 右击工程 -- 添加 -- 窗体
- 以对话框的方式打开窗体
  - form.ShowDialog();   // 阻塞主进程
  - form.Show();  // 只是显示窗体，但是不阻塞主进程，无法操作窗体

- 程序代码："..\HostComputer\HostComputer-ConsoleApp-Form"

## 串口调试助手 - 绘制曲线，线程间访问-委托

子窗体修改父窗体控件，要用委托

- Form1 访问 Form2 的控件，可以声明一个全局 Form2 对象；Form1 调用 Form2 的 public 函数，修改 Form2 属性。
- 但是，Form2 由 Form1 创建，Form2 想修改 Form1 窗体的控件，必须用委托
  - https://blog.csdn.net/qq_16504163/article/details/104244722

不同线程间访问 UI 控件，要用委托

- 注意：全局变量在不同的线程间是可以访问的。线程只是不能访问 UI 控件而已。
- 创建线程后，访问 UI 控件，要用委托
  - 委托有两种方法：
    - 委托五步法（基础调用）
    - 用 Action 调用，更简单
- 参考网址: https://blog.csdn.net/sinat_40003796/article/details/126246744

在窗体绘制图形

- 通过按键触发绘制不同的图形
  - 参考网址：https://www.cnblogs.com/zyadmin/p/8405974.html
- 使用 Form3_Paint 绘制图形
  - 参考网址：https://blog.csdn.net/m0_65636467/article/details/129133811

双缓冲器和按键检测

- 可以避免图形 Invalidate(); // 刷新显示 的时候闪屏

C# WinForm 软件发布

- 1、修改解决方案配置为 Release；
- 2、右击Winform项目 → 生成。
- 注：选择Debug同样也会生成项目文件，但生成的是没优化的代码。
  - Debug (调试)：不进行优化，便于程序员调试应用程序。
  - Release (发布)：进行完全优化，减少代码大小，提高运行速度。

打包发布 exe 文件常见的问题。

- 注意：打包的常见问题
  - 1、异常处理不完善。
    - 比如，没有串口设备，却访问串口，就会提示异常，但是可以继续运行。
  - 2、.dll 动态链接库缺少，程序中引用了某些库，但是没有放到 exe 文件的目录下。
    - 比如，.NET 框架不支持。使用 VS 开发，默认用的是 .NET 框架支持的。某些系统没有 .NET 框架，需要外部下载。一般的 WIN7，WIN10，WIN11 系统自带 .NET 框架的

- 程序代码："..\HostComputer\HostComputer-SerialComm-DrawLine"



