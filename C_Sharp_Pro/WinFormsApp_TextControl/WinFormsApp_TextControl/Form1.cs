using System.Windows.Forms;

namespace WinFormsApp_TextControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Do you like C#";

            textBox6.Multiline = true;
            textBox6.Height = 160;
            textBox6.Text = "昨夜又是下雨的一夜";
            textBox6.SelectionStart = 3;  // 从第2个字节开始
            textBox6.SelectionLength = 3;  // 选中3个字节
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "I like C#";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.AcceptButton = button1;
            richTextBox2.Multiline = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;

            richTextBox3.Text = "设置 RichTextBox 的字体和颜色！！";
            Font f = new Font("楷体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Font = f;
            richTextBox3.ForeColor = Color.Blue;

            richTextBox5.SelectionBullet = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("单击了 Botton2 按键；");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox5.Text = textBox3.Text;
        }

        private void richTextBox3_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBox4_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}