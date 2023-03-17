namespace HostComputerTimer
{
    public partial class Form1 : Form
    {
        int count = 0;
        int time = 0;
        bool timerStatus = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                comboBox1.Items.Add(i.ToString() + " 秒");
            }
            System.Media.SystemSounds.Beep.Play(); // 提示音
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timerStatus)
            {
                button1.Text = "开始计时";
                timerStatus = false;
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play(); // 提示音
                MessageBox.Show("关闭计时！！");

                count = 0;
                progressBar1.Value = 0;

            }
            else
            { 
                if (comboBox1.Text != "")
                {
                    string str = comboBox1.Text;
                    time = Convert.ToInt32(str.Substring(0, 2));
                    progressBar1.Maximum = time;
                    timer1.Start();
                    timerStatus = true;
                    button1.Text = "关闭计时";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            label3.Text = (time - count).ToString() + "秒";
            progressBar1.Value = count;
            if (count == time)
            {
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play(); // 提示音
                MessageBox.Show("时间到了！！");

                count = 0;
                progressBar1.Value = 0;

                button1.Text = "开始计时";
                timerStatus = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}