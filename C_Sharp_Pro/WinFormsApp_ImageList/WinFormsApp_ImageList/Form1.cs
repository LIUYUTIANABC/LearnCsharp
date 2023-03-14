namespace WinFormsApp_ImageList
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = "D:\\Git\\__my_bg__";
            Path += @"\bg1.jpg";
            string Path1 = "D:\\Git\\__my_bg__";
            Path1 += @"\bg2.jpg";
            string Path2 = "D:\\Git\\__my_bg__";
            Path2 += @"\bg3.jpg";
            Image Ming = Image.FromFile(Path, true);
            imageList1.Images.Add(Ming);
            Image Ming1 = Image.FromFile(Path1, true);
            imageList1.Images.Add(Ming1);
            Image Ming2 = Image.FromFile(Path2, true);
            imageList1.Images.Add(Ming2);
            imageList1.ImageSize = new Size(200,165);
            pictureBox1.Width = 200;
            pictureBox1.Height = 165;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                if (index < imageList1.Images.Count - 1)
                {
                    index++;
                }
                pictureBox1.Image = imageList1.Images[index];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                if (index > 0)
                {
                    index--;
                }
                pictureBox1.Image = imageList1.Images[index];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                imageList1.Images.RemoveAt(imageList1.Images.Count - 1);
            }
            else
            {
                MessageBox.Show("√ª”–ÕºœÒ¡À£°");
                pictureBox1.Image = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imageList1.Images.Clear();
        }
    }
}