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
            comboBox1.Items.Add("选项一");
            comboBox1.Items.Add("选项二");
            comboBox1.Items.Add("选项三");

            // radioButton1
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            // NumericUpDown
            numericUpDown1.Value = 4;
            numericUpDown1.Maximum = 8;
            numericUpDown1.Minimum = 0;
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
                MessageBox.Show("CheckBox 控件被选中");
            }
            else
            {
                MessageBox.Show("CheckBox 控件被取消");
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                label4.Text = "CheckBox 控件被选中";
            }
            else
            {
                label4.Text = "CheckBox 控件被取消";
            }
        }

        int radioIndex = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIndex == 0)
            {
                radioIndex  = 1;
                label6.Text = "radioButton1 选项改变触发: " + radioIndex;
            }
            else
            {
                radioIndex = 0;
                label6.Text = "radioButton1 选项改变触发: " + radioIndex;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("radioButton1 控件被选中");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("radioButton2 控件被选中");
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("radioButton3 控件被选中");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "numericUpDown1 显示的值是： " + numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要添加的数据");
            }
            else
            { 
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的项目");
            }
            else
            { 
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}