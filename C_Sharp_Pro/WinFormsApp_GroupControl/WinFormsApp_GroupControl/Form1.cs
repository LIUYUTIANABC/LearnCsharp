namespace WinFormsApp_GroupControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            richTextBox1.Text = "����������\n�Ա���\n���䣺28\n���壺��\nְҵ������Ա";

            tabControl1.ImageList = imageList1;
            tabPage1.Text = "ѡ�1";
            tabPage1.ImageIndex = 0;
            tabPage2.Text = "ѡ�2";
            tabPage2.ImageIndex = 1;
            tabPage3.Text = "ѡ�3";
            tabPage3.ImageIndex = 0;

            Button btn1 = new Button();
            btn1.Text = "��Ӱ�ť";
            btn1.Click += btn1_Click;
            TextBox tbx1 = new TextBox();
            tbx1.Text = "����ı�";
            tabPage1.Controls.Add(btn1);
            tabPage2.Controls.Add(tbx1);
            tabPage3.Controls.Add(btn1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("����������");
                textBox1.Focus();
            }
            else
            {
                if (textBox1.Text.Trim() == "����")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("���޴���");
                    textBox1.Text = "";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ֶ�����ı���ѡ�1");
            TextBox tbx1 = new TextBox();
            tbx1.Text = "�ֶ���ӵ��ı�";
            tabPage1.Controls.Add(tbx1);
        }
    }
}