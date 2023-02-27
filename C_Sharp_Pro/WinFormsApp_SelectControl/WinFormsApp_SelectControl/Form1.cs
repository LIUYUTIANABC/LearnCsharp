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

        int radioIndex = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIndex == 0)
            {
                radioIndex  = 1;
                label6.Text = "radioButton1 ѡ��ı䴥��: " + radioIndex;
            }
            else
            {
                radioIndex = 0;
                label6.Text = "radioButton1 ѡ��ı䴥��: " + radioIndex;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("radioButton1 �ؼ���ѡ��");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("radioButton2 �ؼ���ѡ��");
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("radioButton3 �ؼ���ѡ��");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "numericUpDown1 ��ʾ��ֵ�ǣ� " + numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("������Ҫ��ӵ�����");
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
                MessageBox.Show("��ѡ��Ҫɾ������Ŀ");
            }
            else
            { 
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}