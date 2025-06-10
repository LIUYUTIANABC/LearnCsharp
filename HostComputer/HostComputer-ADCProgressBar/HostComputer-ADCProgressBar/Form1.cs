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

        private void PortDataReceivedEvent(object sender, SerialDataReceivedEventArgs args)
        {
            byte Data = (byte)serialPort1.ReadByte();
            progressBar1.Value = Data;
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
    }
}
