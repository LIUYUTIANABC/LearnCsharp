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

