using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostComputerSerialCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add("COM" + i.ToString());
            }
            comboBox1.Text = "COM1";
            comboBox2.Text = "9600";

            /* 必须手动添加串口接受事件 */
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);

            // 允许跨线程访问，但是此不稳定，要慎用
            // 线程间操作无效：从不是创建控件label的线程去访问它。
            // 正常应该采用委托的方法调用
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)//串囗数据接收事件
        {
            if (radioButton4.Checked)  //如果接收模式为字符模式
            {
                // 字符模式
                string str = serialPort1.ReadExisting();//字符串方式读
                textBox1.AppendText(str);//添加内容
            }
            else //如果接收模式为数值接收
            {
                /* 转换一个字节 */
                //// 十六进制
                //byte data;
                //data = (byte)serialPort1.ReadByte();//此处需要强制类型转换，将(int)类型数据特换为(byte)英型数据
                //// 把数据转换为大写十六进制数据
                //string str = Convert.ToString(data, 16).ToUpper(); //转换为大写十六进制字符串
                //textBox1.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + "");
                ////上一句等同为: 
                //// if(str.Length == 1)
                ////      str = "0" + str;
                //// else
                ////     str = str;
                //// textBox1.AppendText("0x" + str);
                ///

                /* 转换串口缓冲区的所有字节 */
                //定义缓冲区，因为串口事件触发时缓冲区可能有多个数据
                byte[] data = new byte[serialPort1.BytesToRead];
                serialPort1.Read(data, 0, data.Length);
                foreach (byte MyByte in data)
                {
                    string str = Convert.ToString(MyByte, 16).ToUpper();
                    textBox1.AppendText("0x" + (str.Length == 1 ? "0"+str : str) + " ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text); //十进制数据族换
                //serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text, 10); //十进制数据族换
                serialPort1.Open();
                button1.Enabled = false; //打开串口按钮不可用
                button2.Enabled = true; //关闭串口按钮可用
            }
            catch
            {
                MessageBox.Show("端口错误,请检査串口","错误提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close(); //关闭串口
                button1.Enabled = true; //打开串口按钮可用
                button2.Enabled = false;
            }
            catch(Exception err) //一般情况下关闭串口不会出错，所以不需要加处理程序
            {
                MessageBox.Show("串口关闭错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1]; //作用同上集
            if (serialPort1.IsOpen) //判断串口是否打开，如果打开执行下一步操作
            {
                if (textBox2.Text != "")
                {
                    if (radioButton1.Checked) //如果发送模式是字符模式
                    {
                        try
                        {
                            serialPort1.WriteLine(textBox2.Text); //写数据
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("串口发送错误", "错误"); //出错提示
                            serialPort1.Close();
                            button1.Enabled = true; //打井串口按钳叫
                            button2.Enabled = false;
                        }
                    }
                    else
                    {
                        // 区分奇数个还是偶数个 8421码
                        for (int i = 0; i < (textBox2.Text.Length - (textBox2.Text.Length % 2)) / 2; i++) //取余2运算作用是算出字节数
                        {
                            Data[0] = Convert.ToByte(textBox2.Text.Substring(i * 2, 2), 16); // 取到一个字节的数，两个8421码
                            serialPort1.Write(Data, 0, 1);// 发送一个字节，不换行
                        }
                        if (textBox2.Text.Length % 2 != 0) // 奇数个继续发最后一个数据
                        {
                            Data[0] = Convert.ToByte(textBox2.Text.Substring(textBox2.Text.Length - 1, 1), 16); // 取到最后一个发送
                            serialPort1.Write(Data, 0, 1);
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 让滚动条在最下方
            textBox1.ScrollToCaret();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Enabled = true;
                button2.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            //this.Close();
        }

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
