using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostComputerUsart.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str;
            for (int i = 0; i < 256; i++)
            {
                str = i.ToString("x").ToUpper();
                if (str.Length == 1)
                {
                    str = "0" + str;
                }
                comboBox1.Items.Add("0x" + str);
            }
            comboBox1.Text = "0x00";

            MessageBox.Show("窗口打开了！！", "自定义标题");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = comboBox1.Text;
            string convertdata = data.Substring(2,2);
            byte[] buffer = new byte[1];
            buffer[0] = Convert.ToByte(convertdata,16);
            try
            {
                serialPort1.Open();
                serialPort1.Write(buffer , 0 ,1);
                serialPort1.Close();
            }
            catch
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("串口打开错误！！","自定义标题");
                }
                throw;
            }
        }
    }
}
