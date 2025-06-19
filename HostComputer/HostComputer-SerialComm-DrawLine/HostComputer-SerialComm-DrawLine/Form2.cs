using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostComputer_SerialComm_DrawLine
{
    // 在 Form2 中修改 Form1 的控件，要把委托定义写到 Form2，
    // Form2 调用 Form1 的方法
    // 方法体在 Form1 中

    // 1、命名空间中，声明一个委托
    public delegate void Form1TextBox3String(String str);  // 命名空间中，声明一个委托

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 2、实例化一个委托
        public event Form1TextBox3String CallForm1TextBox3String;

        private void button1_Click(object sender, EventArgs e)
        {
            // 4、调用委托
            CallForm1TextBox3String("Form2 使用委托的方法，修改 Form1 的 TextBox3 的内容");
        }

        public void MainFormCall(string str)
        { 
            textBox1.Text = str;
        }
    }
}
