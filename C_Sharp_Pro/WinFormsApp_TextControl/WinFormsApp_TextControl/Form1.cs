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
            textBox6.Text = "��ҹ���������һҹ";
            textBox6.SelectionStart = 3;  // �ӵ�2���ֽڿ�ʼ
            textBox6.SelectionLength = 3;  // ѡ��3���ֽ�
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

            richTextBox3.Text = "���� RichTextBox ���������ɫ����";
            Font f = new Font("����", 15F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Font = f;
            richTextBox3.ForeColor = Color.Blue;

            richTextBox5.SelectionBullet = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ Botton2 ������");
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