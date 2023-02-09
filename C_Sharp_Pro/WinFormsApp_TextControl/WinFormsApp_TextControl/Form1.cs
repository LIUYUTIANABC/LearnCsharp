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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "I like C#";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.AcceptButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("µ¥»÷ÁË Botton2 °´¼ü£»");
        }
    }
}