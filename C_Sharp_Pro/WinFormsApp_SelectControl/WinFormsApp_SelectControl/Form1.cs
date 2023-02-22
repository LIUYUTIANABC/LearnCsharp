namespace WinFormsApp_SelectControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.Add("ѡ��һ");
            comboBox1.Items.Add("ѡ���");
            comboBox1.Items.Add("ѡ����");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("CheckBox �ؼ���ѡ��");
            }
            else
            {
                MessageBox.Show("CheckBox �ؼ���ȡ��");
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                label4.Text = "CheckBox �ؼ���ѡ��";
            }
            else
            {
                label4.Text = "CheckBox �ؼ���ȡ��";
            }
        }
    }
}