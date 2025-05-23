using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    label1.BackColor = Color.Gray;
                }
                catch //确保万无一失
                {

                }
                button2.Text = "打开串口";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox2.Text; //端口号
                    serialPort1.Open();                    //打开端口
                    button2.Text = "关闭串口";
                    label1.BackColor = Color.Green;
                }
                catch
                {
                    MessageBox.Show("串口打开失败","错误");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceOpen1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceClosel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceOpen2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceClose2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceOpen3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteByteToSerialPort(DeviceClose3);
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
    }
}
