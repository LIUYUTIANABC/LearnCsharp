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
            richTextBox1.Text = "姓名：张三\n性别：男\n年龄：28\n民族：汉\n职业：程序员";

            tabControl1.ImageList = imageList1;
            tabPage1.Text = "选项卡1";
            tabPage1.ImageIndex = 0;
            tabPage2.Text = "选项卡2";
            tabPage2.ImageIndex = 1;
            tabPage3.Text = "选项卡3";
            tabPage3.ImageIndex = 0;

            Button btn1 = new Button();
            btn1.Text = "添加按钮";
            btn1.Click += btn1_Click;
            TextBox tbx1 = new TextBox();
            tbx1.Text = "添加文本";
            tabPage1.Controls.Add(btn1);
            tabPage2.Controls.Add(tbx1);
            tabPage3.Controls.Add(btn1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入姓名");
                textBox1.Focus();
            }
            else
            {
                if (textBox1.Text.Trim() == "张三")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("查无此人");
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
            MessageBox.Show("手动添加文本到选项卡1");
            TextBox tbx1 = new TextBox();
            tbx1.Text = "手动添加的文本";
            tabPage1.Controls.Add(tbx1);
        }
    }
}