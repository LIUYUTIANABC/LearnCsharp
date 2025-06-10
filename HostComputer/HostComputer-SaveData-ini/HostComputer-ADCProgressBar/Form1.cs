using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HostComputer_ADCProgressBar
{
    public partial class Form1 : Form
    {
        //[DllImport("kerne132")]
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue,
            StringBuilder resultValue, int size, string filePath);

        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "data.ini"; //ini文件名
        StringBuilder temp = new StringBuilder(255); //存储读出ini内容变单
        string CurrentPortNane = "COM1";
        
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortDataReceivedEvent);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void PortDataReceivedEvent(object sender, SerialDataReceivedEventArgs args)
        {
            byte Data = (byte)serialPort1.ReadByte();
            progressBar1.Value = Data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPrivateProfileString("PortData", "PortName","COM1", temp, 256, FileName); //读取ini值，默认是COM1
            comboBox1.Text = temp.ToString(); //初始化
        }

        private void buttonl_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                groupBox2.Visible = false;
                this.Size = new Size(560,140);
                serialPort1.Close();
                button1.Text = "打开串口";
            }
            else
            {
                try
                {
                    CurrentPortNane = comboBox1.Text;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    groupBox2.Visible = true;
                    this.Size = new Size(560,220);
                    button1.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("串口打开错误", "错误");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("PortData", "PortName", CurrentPortNane, FileName); //窗口关闭，保存
        }
    }
}
