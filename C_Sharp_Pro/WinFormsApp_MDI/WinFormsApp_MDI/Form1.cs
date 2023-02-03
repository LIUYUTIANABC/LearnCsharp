using System.Windows.Forms;

namespace WinFormsApp_MDI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "MDIÑÝÊ¾³ÌÐò";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello£¡£¡");
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
        private void HorizontallyTileMyWindows(object sender, System.EventArgs e)
        {
            // Tile all child forms horizontally.
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VerticallyTileMyWindows(object sender, System.EventArgs e)
        {
            // Tile all child forms vertically.
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void CascadeMyWindows(object sender, System.EventArgs e)
        {
            // Cascade all MDI child windows.
            this.LayoutMdi(MdiLayout.Cascade);
        }

    }
}