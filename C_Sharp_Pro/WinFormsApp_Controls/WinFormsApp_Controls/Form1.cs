namespace WinFormsApp_Controls
{
    public partial class Form1 : Form
    {
        int cboPointY = 30;
        int btnPointY = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboPointY += 30;
            ComboBox cbo = new ComboBox();
            cbo.Location = new Point(20, cboPointY);
            this.Controls.Add(cbo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPointY += 30;
            Button btn = new Button();
            btn.Location = new Point(200, btnPointY);
            btn.Text = btnPointY.ToString();
            this.Controls.Add(btn);
        }
    }
}