using System.Windows.Forms;

namespace WinFormsApp_MDI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "MDI演示程序";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello！！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.MdiParent = this;

            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.MdiParent = this;
            
        }

        private void Cascade_Click(object sender, EventArgs e)

        //实现对主窗体中的MDI窗体的层叠操作

        {

            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void TileH_Click(object sender, EventArgs e)

        //实现对主窗体中的MDI窗体的水平平铺操作

        {

            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void TileV_Click(object sender, EventArgs e)

        //实现对主窗体中的MDI窗体的垂直平铺操作

        {

            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}