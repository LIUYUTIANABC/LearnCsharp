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
using Microsoft.VisualBasic.PowerPacks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HostComputer_OnOffControl
{
    public partial class Form1 : Form
    {
        byte DataSended = 0;
        byte[] DataToSend = new byte[] { 0x01, 0x02, 0x03 };
        bool ButtonStatus = false;
        public Form1()
        {
            InitializeComponent();
            // 允许跨线程访问，但是此不稳定，要慎用
            // 线程间操作无效：从不是创建控件label的线程去访问它。
            // 正常应该采用委托的方法调用
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            // 相当于一个函数指针，指向串口中断，串口接收完数据后调用的函数
            /* 必须手动添加串口接受事件 */
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        private void SetOvlShape(int which)
        {
            switch (which)
            {
                case 0x01:
                    label1.BackColor = Color.Green;
                    break;
                case 0x11:
                    label1.BackColor = Color.Red;
                    break;
                case 0x02:
                    label3.BackColor = Color.Green;
                    break;
                case 0x12:
                    label3.BackColor = Color.Red;
                    break;
                case 0x03:
                    label4.BackColor = Color.Green;
                    break;
                case 0x13:
                    label4.BackColor = Color.Red;
                    break;
                case 0x04:
                    label1.BackColor = Color.Green;
                    label3.BackColor = Color.Green;
                    label4.BackColor = Color.Green;
                    break;
                case 0x14:
                    label1.BackColor = Color.Red;
                    label3.BackColor = Color.Red;
                    label4.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 取反的话要注意编译器数据的问题，C#是按照有符号数存储的
            byte DataReceived = (byte)(~serialPort1.ReadByte());
            // 不取反
            byte DataReceived_Buffer = (byte)(~DataReceived);
            try
            {
                button3.Enabled = true;
                button6.Enabled = true;
                button8.Enabled = true;
                timer1.Stop();
            }
            catch { }
            SetOvlShape(DataReceived_Buffer);
            if (DataSended == 0)
            { 
                return;
            }
            try
            {
                if ((byte)(~DataToSend[DataSended - 1]) == DataReceived)
                {
                    MessageBox.Show("数据校验成功", "成功!");
                }
                else
                {
                    MessageBox.Show("数据校验失败", "數据校验失败");
                }
            }
            catch
            {

            }
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
                    MessageBox.Show("串口打开失败", "错误");
                }
            }
        }

        private void SendDataToSerialPort(SerialPort MyPort, byte DataToSend, System.Windows.Forms.Button MyBut)
        {
            byte[] DatasToWrite = new byte[] { DataToSend };
            if (serialPort1.IsOpen)
            {
                try
                {
                    MyBut.Enabled = false;
                    MyPort.Write(DatasToWrite, 0, 1);
                    timer1.Interval = 3 * 1000;
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("串口数据写入错误","错误");
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button MyButton = (System.Windows.Forms.Button)sender; // object 是所有类的父类。传递过来的是触发的控件的类
            DataSended = Convert.ToByte(MyButton.Tag);
            // MyButton.Enabled = false;
            SendDataToSerialPort(serialPort1, DataToSend[DataSended - 1], MyButton);
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
            string MyStr = DataSended.ToString() + "路数据校验超时，请檢查";
            timer1.Stop();
            button3.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;
            MessageBox.Show(MyStr, "错误");
            //byte[] DatasToWrite = new byte[] { 0x01 };
            //if (serialPort1.IsOpen)
            //{
            //    try
            //    {
            //        serialPort1.Write(DatasToWrite, 0, 1);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("串口数据写入错误", "错误");
            //    }
            //}
        }
    }
}
