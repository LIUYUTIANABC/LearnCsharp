namespace WinFormsApp_Menu_Tool_Status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ±£¥ÊToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Minimum = 0;
            this.toolStripProgressBar1.Maximum = 5000;
            this.toolStripProgressBar1.Step = 2;
            for (int i = 0; i < 5000; i++)
            {
                this.toolStripProgressBar1.PerformStep();
            }
        }
    }
}