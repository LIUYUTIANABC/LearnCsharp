using System.Windows.Forms;

namespace WinFormsApp_MDI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "MDI��ʾ����";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello����");
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

        //ʵ�ֶ��������е�MDI����Ĳ������

        {

            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void TileH_Click(object sender, EventArgs e)

        //ʵ�ֶ��������е�MDI�����ˮƽƽ�̲���

        {

            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void TileV_Click(object sender, EventArgs e)

        //ʵ�ֶ��������е�MDI����Ĵ�ֱƽ�̲���

        {

            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}