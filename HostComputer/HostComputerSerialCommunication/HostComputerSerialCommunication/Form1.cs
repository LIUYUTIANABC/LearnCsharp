using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostComputerSerialCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            // serialPort1.DataReceived = new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived);

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (radioButton4.Checked)
            {
                // 字符模式
                string str = serialPort1.ReadExisting();
                textBox1.AppendText(str);

            }
            else
            {
                // 十六进制
                byte data;
                data = (byte)serialPort1.ReadByte();
                // 把数据转换为大写十六进制数据
                string str = Convert.ToString(data, 16).ToUpper();
                textBox1.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + "    ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text, 10);
                serialPort1.Open();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("打开串口错误");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                button1.Enabled = true;
                button2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("串口关闭错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];
            if (serialPort1.IsOpen)
            {
                if (textBox2.Text != "")
                {
                    try
                    {
                        serialPort1.Write(textBox2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("串口发送错误", "错误");
                        serialPort1.Close();
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                }
                else
                {
                    for (int i = 0; i < (textBox2.Text.Length - textBox2.Text.Length % 2) / 2; i++)
                    {
                        Data[0] = Convert.ToByte(textBox2.Text.Substring(i * 2, 2), 16);
                        serialPort1.Write(Data, 0, 1);
                    }
                    if (textBox2.Text.Length % 2 != 0)
                    {
                        Data[0] = Convert.ToByte(textBox2.Text.Substring(textBox2.Text.Length - 1, 1), 16);
                        serialPort1.Write(Data, 0, 1);
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
        }
    }
}
