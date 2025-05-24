using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostComputer_OnOffControl.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HostComputer_OnOffControl
{
    public partial class Form1 : Form
    {
        //device 1
        const byte DeviceOpen1 = 0x01;
        const byte DeviceClosel = 0x81;
        //device 2
        const byte DeviceOpen2 = 0x02;
        const byte DeviceClose2 = 0x82;
        //device 3
        const byte DeviceOpen3 = 0x03;
        const byte DeviceClose3 = 0x83;
        
        // Versiables
        bool ButtonStatus = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 允许跨线程访问，但是此不稳定，要慎用
            // 线程间操作无效：从不是创建控件label的线程去访问它。
            // 正常应该采用委托的方法调用
            // System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            SearchAndAddSerialToComboBox(serialPort1, comboBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, comboBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) //串口打开就关闭
            {
                try
                {
                    serialPort1.Close();
                    //label1.BackColor = Color.Gray;
                }
                catch //确保万无一失
                {

                }
                // button2.Text = "打开串口";
                ButtonStatus = false;// 按钮状态
                button2.BackgroundImage = Properties.Resources.image_red;
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox2.Text; //端口号
                    serialPort1.Open();                    //打开端口
                    //button2.Text = "关闭串口";
                    //label1.BackColor = Color.Green;
                    ButtonStatus = true;// 按钮状态
                    button2.BackgroundImage = Properties.Resources.image_green;
                }
                catch
                {
                    MessageBox.Show("串口打开失败","错误");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            // 视频中识别 2 位数字
            //try
            //{
            //    i = Convert.ToInt32(textBox1.Text.Substring(0,2)); //先处理两位数，如果出错就
            //}
            //catch
            //{
            //    try
            //    {
            //        i = Convert.ToInt32(textBox1.Text.Substring(0,1));//处理一位款
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的数字");
            //        return;
            //    }
            //}
            // 识别 3 位数字
            try
            {
                string str = textBox1.Text;
                i = Convert.ToInt32(str);
            }
            catch (Exception err)
            { 
                //MessageBox.Show($"Error: {err.Message}");
                MessageBox.Show("请输入数字","Error!!");
                return;
            }
            if (serialPort1.IsOpen)//避免定时器浪费时间和用户等
            {
                if (i == 0)
                {
                    return;
                }
                else
                {
                    timer1.Interval = i * 100;  //可以这样写，不需要计数器
                    timer1.Start(); //开定时器
                    button3.Enabled = false; //开按钮不能按了…
                    label1.BackColor = Color.Green;
                }
            }
            WriteByteToSerialPort(DeviceOpen1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop(); //如果定时器没开，则错误处理
            }
            catch
            {
            }
            button3.Enabled = true;
            WriteByteToSerialPort(DeviceClosel);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceClose2);
            label3.BackColor = Color.Gray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                string str = textBox2.Text;
                i = Convert.ToInt32(str);
            }
            catch (Exception err)
            {
                //MessageBox.Show($"Error: {err.Message}");
                MessageBox.Show("请输入数字", "Error!!");
                return;
            }
            if (serialPort1.IsOpen)//避免定时器浪费时间和用户等
            {
                if (i == 0)
                {
                    return;
                }
                else
                {
                    timer2.Interval = i * 100;  //可以这样写，不需要计数器
                    timer2.Start(); //开定时器
                    button6.Enabled = false; //开按钮不能按了…
                }
            }
            // WriteByteToSerialPort(DeviceOpen2);
            // label3.BackColor = Color.Green;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceOpen3);
            label4.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceClose3);
            label4.BackColor = Color.Gray;
        }

        private void SearchAndAddSerialToComboBox(SerialPort MyPort, System.Windows.Forms.ComboBox MyBox) //将可用端口号添加到Combobox
        {
            // string[] MyString= new string[20]; //最多容纳20个，太多会影响调试效率
            string Buffer; //缓存
            MyBox.Items.Clear(); //清空ComboBox内容
            for (int i = 1;  i < 20; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                    MyPort.Open();    //如果失败，后面的代码不会执行
                    // MyString[i -1]= Buffer;
                    MyBox.Items.Add(Buffer);  //打开成功，添加至下俩列表
                    MyPort.Close();
                }
                catch
                {

                }
            }
            // MyBox.Text = MyString[0];  //初始化
            if (MyBox.Items.Count > 0)
            {
                //MyBox.SelectedIndex = 0;  // 选择第一个Item
                MyBox.Text = MyBox.Items[0].ToString();
                //MyBox.SelectedIndex = MyBox.Items.Count-1;  // 选择第一个Item
            }
        }

        private void WriteByteToSerialPort(byte data)  //单字节写入串口
        {
            byte[] Buffer = new byte[2] { 0x00, data }; //定义数组
            if (serialPort1.IsOpen) //传输数据的前提是端口已打开
            {
                try
                {
                    serialPort1.Write(Buffer, 0, 2);
                }
                catch
                {
                    MessageBox.Show("串口数据发送出错，请检査,","错误");//错误处理
                }
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (ButtonStatus) //鼠标移开，返回原来状态
            {
                button2.BackgroundImage = Properties.Resources.image_green; //鼠标指上去则使用Image-red
            }
            else 
            {            
                button2.BackgroundImage = Properties.Resources.image_red; //鼠标指上去则使用Image-red
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.image_gray; //鼠标指上去则使用image-gray
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.Enabled = true; //开按钮可以按
            timer1.Stop();  //一定要先关闭定时器
            //MessageBox.Show(nul1):
            WriteByteToSerialPort(DeviceClosel); //器件一关
            label1.BackColor = Color.Gray;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button6.Enabled = true; //开按钮可以按
            timer2.Stop();  //一定要先关闭定时器
            WriteByteToSerialPort(DeviceOpen2);
            label3.BackColor = Color.Green;
        }
    }
}
