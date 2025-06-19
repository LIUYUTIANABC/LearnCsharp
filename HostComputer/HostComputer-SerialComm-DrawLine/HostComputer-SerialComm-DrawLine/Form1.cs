using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static HostComputer_SerialComm_DrawLine.Form1;

namespace HostComputer_SerialComm_DrawLine
{
    // 声明委托
    public delegate void ShowWindow();
    public delegate void HideWindow();
    public delegate void OpenPort();
    public delegate void ClosePort();
    public delegate Point GetMainPos();
    public delegate void GetMainWidth();
    public delegate void MainClose();

    public partial class Form1 : Form
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder resultValue, int size, string filePath);

        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "data.ini"; //ini文件名
        StringBuilder temp = new StringBuilder(255); //存储读出ini内容变单

        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");
        }


        /* 定义委托函数 */
        public void CloseMainForm() // 关闭窗口，委托调用
        {
            this.Close();
        }

        public void ClosePort() // 关闭串口，委托调用
        {
            try
            {
                serialPort1.Close();
            }
            catch
            { 
            
            }
        }

        public Point GetMyPos() // 供委托调用
        { 
            return this.Location;
        }

        public void OpenPort() // 打开串口，委托调用
        {
            try
            {
                serialPort1.Open();
            }
            catch(System.Exception)
            {
                MessageBox.Show("打开串口失败");
            }
        }

        public void ShowMe()// 供委托调用
        { 
            this.Show();
        }

        public void HideMe()// 供委托调用
        {
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string PortNum = "COM1";
            for (int i = 1; i < 20; i++)
            {
                try
                {
                    PortNum = "COM" + i.ToString();
                    serialPort1.PortName = PortNum;
                    serialPort1.Open();    //如果失败，后面的代码不会执行
                    // MyString[i -1]= Buffer;
                    comboBox1.Items.Add(PortNum);  //打开成功，添加至下俩列表
                    serialPort1.Close();
                }
                catch
                {

                }
            }
            //comboBox1.Text = (string)comboBox1.Items[0];
            PortNum = (string)comboBox1.Items[0];

            // 调用 ini 文件保存的数据
            GetPrivateProfileString("PortData", "PortName", PortNum, temp, 256, FileName); //读取ini值，默认是COM1
            comboBox1.Text = temp.ToString(); //初始化
            GetPrivateProfileString("PortData", "BoundRate", "9600", temp, 256, FileName); //读取ini值，默认是COM1
            comboBox2.Text = temp.ToString(); //初始化
            GetPrivateProfileString("PortData", "TxMode", "ASCII", temp, 256, FileName); //读取ini值，默认是COM1
            if (temp.ToString() == "ASCII")
            {
                radioButton1.Checked = true;
                //radioButton2.Checked = false;
            }
            else
            {
                //radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            GetPrivateProfileString("PortData", "RxMode", "ASCII", temp, 256, FileName); //读取ini值，默认是COM1
            if (temp.ToString() == "ASCII")
            {
                radioButton4.Checked = true;
                //radioButton3.Checked = false;
            }
            else
            {
                //radioButton4.Checked = false;
                radioButton3.Checked = true;
            }

            // 设置UI 状态
            button3.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (radioButton1.Checked)
            {
                WritePrivateProfileString("PortData", "TxMode", "ASCII", FileName); //窗口关闭，保存
            }
            else
            {
                WritePrivateProfileString("PortData", "TxMode", "HEX", FileName); //窗口关闭，保存
            }
            if (radioButton4.Checked)
            {
                WritePrivateProfileString("PortData", "RxMode", "ASCII", FileName); //窗口关闭，保存
            }
            else
            {
                WritePrivateProfileString("PortData", "RxMode", "HEX", FileName); //窗口关闭，保存
            }
            WritePrivateProfileString("PortData", "PortName", comboBox1.Text, FileName); //窗口关闭，保存
            WritePrivateProfileString("PortData", "BoundRate", comboBox2.Text, FileName); //窗口关闭，保存
        }

        private void ExcuteMethod()
        {
            textBox1.Text = "接收到数据";
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // byte Data = (byte)serialPort1.ReadByte();
            // textBox1.Text = Data.ToString();  // 错误的调用，线程间操作无效

            // 可以用
            //Action action = new Action(ExcuteMethod);
            //this.Invoke(action);
            // 可以用
            // this.Invoke(new Action(ExcuteMethod));
            // 最简洁用法
            //this.Invoke(new Action(() =>
            //{
            //    textBox1.Text = Data.ToString();
            //}));

            /* 转换串口缓冲区的所有字节 */
            //定义缓冲区，因为串口事件触发时缓冲区可能有多个数据
            byte[] data = new byte[serialPort1.BytesToRead];
            serialPort1.Read(data, 0, data.Length);
            if (form3 != null)
            { 
                form3.AddData(data);  // 数据添加到链表中
            }
            foreach (byte MyByte in data)
            {
                string str = Convert.ToString(MyByte, 16).ToUpper();
                this.Invoke(new Action(() =>
                {
                    textBox1.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form3 form3 = new Form3();
            form3.Show();

            /* 绑定委托 */
            form3.mShowMinWindow += new ShowWindow(ShowMe);
            form3.mHideWindow += new HideWindow(HideMe);
            form3.mOpenPort += new OpenPort(OpenPort);
            form3.mClosePort += new ClosePort(ClosePort);
            form3.mGetMainPos += new GetMainPos(GetMyPos);
            form3.mMainClose += new MainClose(CloseMainForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = false;
                button3.Enabled = true;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("串口打开错误", "错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                button2.Enabled = true;
                button3.Enabled = false;
                serialPort1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1]; //作用同上集
            if (serialPort1.IsOpen) //判断串口是否打开，如果打开执行下一步操作
            {
                if (textBox2.Text != "")
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




        /*  子窗体修改父窗体控件，要用委托 */

        Form2 f2 = new Form2();
        private void button5_Click(object sender, EventArgs e)
        {
            // 3.1、订阅委托
            f2.CallForm1TextBox3String += new Form1TextBox3String(CreatForm1TextBox3String);
            f2.Show();
        }

        // 3.2、具体委托事件的实现
        private void CreatForm1TextBox3String(string str)
        {
            textBox3.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f2.MainFormCall("主窗体直接修改子窗体控件");
        }




        /* 创建一个线程，访问窗体控件，要用委托 */
        // [ 1 ] 声明委托，这里的委托不能带参数，访问不了。
        public delegate void SetTextBox4();
        // [ 2 ] 创建委托对象
        public SetTextBox4 setTextBox4;
        // [ 3 ] 委托关联方法，也不能带参数
        public int count = 0;
        private void ExcuteSetTextBox4()
        {
            textBox4.Text = count.ToString();
        }

        private Thread th = null;  // 实例化线程
        private void button7_Click(object sender, EventArgs e)
        {
            // [ 4 ] 绑定委托
            this.setTextBox4 = ExcuteSetTextBox4;
            //this.setTextBox4 += new SetTextBox4(ExcuteSetTextBox4);
            th = new Thread(threadTextBox4);
            th.IsBackground = true;
            th.Start();
        }
        // 定义一个线程
        private void threadTextBox4()
        {
            int i = 0;
            while (i++ < 50)
            {
                count++;
                // [ 5 ] 正确调用委托
                // 错误调用报的是“线程间操作无效，不是从创建的线程访问它”
                // 因为，想要在多线程里访问主线程控件要用 Invoke ，经过主线程同意
                // setTextBox4(i.ToString());  错误调用
                this.Invoke(setTextBox4);
                Thread.Sleep(100);
            }
        }




        /* 最简洁 Action 的委托 */
        private void button8_Click(object sender, EventArgs e)
        {
            th = new Thread(threadTextBox4_1);
            th.IsBackground = true;
            th.Start();
        }
        // 定义一个线程
        private void threadTextBox4_1()
        {
            int i = 0;
            while (i++ < 50)
            {
                count++;
                // 创建委托，绑定委托，调用委托
                //this.Invoke(new Action(ExcuteSetTextBox4));
                // 更简单的方法
                this.Invoke(new Action(() =>
                {
                    textBox4.Text = i.ToString();
                }));
                Thread.Sleep(100);
            }
        }
    }
}
