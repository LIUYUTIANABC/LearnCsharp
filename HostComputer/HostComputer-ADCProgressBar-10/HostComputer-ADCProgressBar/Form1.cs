using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HostComputer_ADCProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortDataReceivedEvent);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        System.Windows.Forms.ProgressBar[] GetProgressbar()
        {
            return new System.Windows.Forms.ProgressBar[]{ progressBar1, progressBar2, progressBar3, progressBar4, progressBar5,
                progressBar6, progressBar7, progressBar8,progressBar9, progressBar10}; //返回一个对象数组
        }
        System.Windows.Forms.Label[] GetProgressbarLabel()
        {
            System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[10] {label2, label13, label14, label17, label16, 
                                                                                        label15, label20, label19, label18, label21};
            return labels; //返回一个对象数组
        }

        System.Windows.Forms.TrackBar[] GetTrackbar()
        {
            return new System.Windows.Forms.TrackBar[]{ trackBar1, trackBar2, trackBar4, trackBar3, trackBar8,
                trackBar7, trackBar6, trackBar5, trackBar10, trackBar9}; //返回一个对象数组
        }

        System.Windows.Forms.Label[] GetTrackbarLabel()
        {
            return new System.Windows.Forms.Label[10] {label22, label23, label24, label25, label26,
                                            label27, label28, label29, label30, label31}; //返回一个对象数组
        }

        private void PortDataReceivedEvent(object sender, SerialDataReceivedEventArgs args)
        {
            //byte Data = (byte)serialPort1.ReadByte();
            //progressBar1.Value = Data;

            System.Windows.Forms.ProgressBar[] MyProgressBar = GetProgressbar();
            System.Windows.Forms.Label[] labels = GetProgressbarLabel();
            System.Windows.Forms.TrackBar[] MyTrackBar = GetTrackbar();
            System.Windows.Forms.Label[] labels_T = GetTrackbarLabel();

            byte[] Data = new byte[serialPort1.BytesToRead];
            serialPort1.Read(Data, 0, Data.Length); //读
            foreach (byte MyData in Data)
            {
                for (int i = 1; i < 10; i++)
                {
                    MyProgressBar[10 - i].Value = MyProgressBar[10 - i - 1].Value;
                }
                progressBar1.Value = (int)MyData;
                // 添加字体
                //string str= MyData.ToString("x");
                //label2.Text = "0x" + (str.Length == 1 ? "0" + str : str);
                for (int i = 0; i < 10; i++)
                {
                    MyTrackBar[i].Value = MyProgressBar[i].Value;
                    string str = MyProgressBar[i].Value + "%";
                    labels[i].Text = str;
                    labels_T[i].Text = str;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            this.Size = new System.Drawing.Size(560,125);
        }

        private void buttonl_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ProgressBar[] MyProgressBar = GetProgressbar();
            System.Windows.Forms.Label[] labels = GetProgressbarLabel();
            System.Windows.Forms.TrackBar[] MyTrackBar = GetTrackbar();
            System.Windows.Forms.Label[] labels_T = GetTrackbarLabel();

            if (serialPort1.IsOpen)
            {
                for (int i = 0; i < 10; i++)
                {
                    MyProgressBar[i].Value = 0;
                    labels[i].Text = "0%";
                    MyTrackBar[i].Value = 0;
                    labels_T[i].Text = "0%";
                }

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                this.Size = new Size(560,125);
                serialPort1.Close();
                button1.Text = "打开串口";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    this.Size = new Size(560,700);
                    button1.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("串口打开错误", "错误");
                }
            }
        }
    }
}
