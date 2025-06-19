using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostComputer_SerialComm_DrawLine
{
    public partial class Form3 : Form
    {
        private const int Unit_length = 32; // 单位格大小
        private int DrawStep = 8; // 默认绘制单位
        private const int MaxStep = 33; //绘制单位最大值
        private const int MinStep = 1; // 绘制单位最小值
        private const int StartPrint = 32;//点坐标偏移量
        private Point StartP = new Point(50,10);
        private Point EndP = new Point(50+50*16, 10+50*12);

        private SolidBrush b1 = new SolidBrush(Color.White);
        private Pen TablePen = new Pen(Color.FromArgb(0xFF,0xFF,0xFF)); // 轴线颜色；
        private Pen LinePen = new Pen(Color.FromArgb(0xa0, 0x00, 0x00)); // 波形颜色；

        // 实例化委托
        public ShowWindow mShowMinWindow;
        public HideWindow mHideWindow;
        public OpenPort mOpenPort;
        public ClosePort mClosePort;
        public GetMainPos mGetMainPos;
        public GetMainWidth mGetMainWidth;
        public MainClose mMainClose;

        private bool KeyShift, KeyShowMain, KeyHideMain, KeyExit, KeyOpen, KeyClose, KeyStepUp, KeyStepDown;

        private Byte[] MyTestData = new byte[20];
        private List<byte> DataList = new List<byte>(); //数据结构----线性链表


        public Form3()
        {
            // 开启双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
        }

        public void AddData(byte[] Data)
        {
            for (int i = 0; i < Data.Length; i++)
            { 
                DataList.Add(Data[i]); //链表尾部添加数据
            }
            Invalidate(); // 刷新显示
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            mMainClose();  // 调用委托
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            //Graphics f = e.Graphics; // 创建画板，这里的画板是由 Form 提供的
            //Pen penline = new Pen(Color.Black, 1); // 定义一个蓝色，宽度为2 的画笔
            //Pen penline2 = new Pen(Color.Black, 1);
            //f.DrawLine(penline2, 50, 50, 50, 80);  // 画一条线
            //f.DrawRectangle(penline2, 50, 50, 50, 80);  // 画矩形
            //f.DrawEllipse(penline2, 50, 50, 50, 80);  // 画椭圆
            // 画虚线
            //penline.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            // 画实线
            //penline.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            // 画箭头
            //penline.EndCap = LineCap.ArrowAnchor;

            /* 画刷 */
            //SolidBrush b1 = new SolidBrush(Color.Blue);
            //Rectangle rect = new Rectangle(10,10,50,50);
            //f.FillRectangle(b1, rect);
            // 字符串
            //f.DrawString("可以绘制字符串", new Font("宋体",10), b1, new PointF(90,10));

            string Str = "";
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            e.Graphics.FillRectangle(Brushes.Black, e.Graphics.ClipBounds);
            // 绘制虚线
            TablePen.DashStyle = DashStyle.Dot;
            // 绘制 Y 轴线 竖线
            for (int i = 0; i <= this.ClientRectangle.Width / Unit_length; i++)
            {
                // 画线
                e.Graphics.DrawLine(TablePen, StartPrint+i*Unit_length, StartPrint, StartPrint+i*Unit_length, StartPrint + 16 * Unit_length);
                // 写字
                //e.Graphics.DrawString(i.ToString(), new Font("宋体", 10), b1, new PointF(StartPrint+i*Unit_length - 5 , StartPrint + 17 * Unit_length));
                //gp.AddString(i.ToString(), this.Font.FontFamily, (int)FontStyle.Regular, 14, new Point(StartPrint + i * Unit_length, StartPrint), StringFormat.GenericDefault);
                gp.AddString(i.ToString(), this.Font.FontFamily, (int)FontStyle.Regular, 14, new RectangleF(StartPrint + i * Unit_length - 5, StartPrint + 16 * Unit_length, 20,20) , StringFormat.GenericDefault);
            }
            // 绘制 X 轴线 横线
            for (int i = 0; i <= this.ClientRectangle.Height / Unit_length; i++)
            {
                // 画线
                e.Graphics.DrawLine(TablePen, StartPrint, (i+1)*Unit_length, this.ClientRectangle.Width, (i+1)*Unit_length);
                // 写字
                // e.Graphics.DrawString(i.ToString(), new Font("宋体", 10), b1, new PointF(StartP.X + i * Unit_length -5, EndP.Y + 5));
                // 绘制数据线
                // e.Graphics.DrawLine(LinePen, StartP.X + i * Unit_length, StartP.Y + MyTestData[i] * Unit_length, StartP.X + (i+1) * Unit_length, StartP.Y + MyTestData[i + 1] * Unit_length);
                Str = ((16 - i) * 16).ToString("X");
                Str = "0x" + (Str.Length == 1 ? Str + "0" : Str);
                if (i == 0)
                    Str = "0xFF";
                if (i == 16)
                    break;
                //e.Graphics.DrawString(Str, new Font("宋体", 10), b1, new PointF(0, StartPrint-10 + (i + 1) * Unit_length));
                gp.AddString(Str, this.Font.FontFamily,(int)FontStyle.Regular,14, new Point(0, (i + 1) * Unit_length - 10), StringFormat.GenericDefault);
            }
            e.Graphics.DrawPath(Pens.White, gp);  //写文字
            // 绘制数据线
            //for (int i = 0; i < 10; i++)
            //{
            //    // 画线
            //    e.Graphics.DrawLine(LinePen, MyTestData[i] + i * Unit_length, MyTestData[i], MyTestData[i + 1] + i * Unit_length, MyTestData[i+1]);
            //}
            if (DataList.Count - 1 >= (this.ClientRectangle.Width - StartPrint) / DrawStep) // 如果数据超过了范围，就从 0 删除超出的数据
            {
                DataList.RemoveRange(1, DataList.Count-(this.ClientRectangle.Width-StartPrint)/DrawStep - 1);
            }
            for (int i = 0; i < DataList.Count-1; i++)
            {
                e.Graphics.DrawLine(LinePen, StartPrint + i*DrawStep, 17 * Unit_length - DataList[i]*2, StartPrint + (i+1) * DrawStep, 17 * Unit_length - DataList[i+1] * 2);
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ////创建画布
            //Graphics g = this.CreateGraphics();
            ////设置画笔颜色 画笔宽度
            //Pen redPen = new Pen(Color.Red, 3);
            ////绘制两个端点 
            //Point startPoint = new Point(10, 10);
            //Point endPoint = new Point(100, 200);
            ////用笔和端点绘制直线
            //g.DrawLine(redPen, startPoint, endPoint);

            // 直接划线
            //Graphics g = this.CreateGraphics();
            //Pen bluePen = new Pen(Color.Blue, 5);
            //g.DrawLine(bluePen, 270, 10, 150, 200);

            //绘制矩形
            //Graphics g = this.CreateGraphics();
            //Pen GreenPen = new Pen(Color.Green, 3);
            //Rectangle rect = new Rectangle(330, 10, 60, 80);
            //g.DrawRectangle(GreenPen, rect);

            //椭圆
            //Graphics g = this.CreateGraphics();
            //Pen purplePen = new Pen(Color.Purple, 3);
            //Rectangle rect = new Rectangle(330, 130, 120, 60);
            //g.DrawEllipse(purplePen, rect);

            //绘制圆弧
            //Graphics g = this.CreateGraphics();
            //Pen redPen = new Pen(Color.DarkRed, 5);
            //Rectangle rect = new Rectangle(430, 30, 220, 110);
            //g.DrawArc(redPen, rect, 120, 220);

            //Random random = new Random();
            //for (int i = 0; i < 11; i++)
            //{
            //    DataList.Add((byte)random.Next(0, 255)); //链表尾部添加数据
            //}
            //Invalidate(); // 刷新显示

            //this.mHideWindow();
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyShift)
            {
                if (KeyShowMain)
                {
                    mShowMinWindow();
                    Rectangle Rect = Screen.GetWorkingArea(this);
                    KeyShowMain = false;
                }
                else if (KeyOpen)
                {
                    mOpenPort(); // 打开串口
                    KeyOpen = false;
                }
                else if (KeyClose)
                {
                    mClosePort();
                    KeyClose = false;
                }
                else if (KeyExit)
                {
                    mMainClose();
                    KeyExit = false;
                }
                else if (KeyHideMain)
                {
                    mHideWindow();
                    KeyHideMain = false;
                }
                else if (KeyStepUp)
                {
                    if (DrawStep < MaxStep)
                    {
                        DrawStep++;
                    }
                    Invalidate();
                    KeyStepUp = false;
                }
                else if (KeyStepDown)
                {
                    if (DrawStep >MinStep)
                    {
                        DrawStep--;
                    }
                    Invalidate();
                    KeyStepDown = false;
                }
            }
            else
            {
                KeyShowMain = false;
                KeyOpen = false;
                KeyClose = false;
                KeyHideMain = false;
                KeyExit = false;
                KeyStepUp = false;
                KeyStepDown = false;
            }
            KeyShift = false;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)  // Shift 功能键按下
            {
                KeyShift = true;
            }
            switch (e.KeyCode)
            {
                case Keys.S:
                    KeyShowMain = true;
                    break;
                case Keys.E:
                    KeyExit = true;
                    break;
                case Keys.O:
                    KeyOpen = true;
                    break;
                case Keys.C:
                    KeyClose = true;
                    break;
                case Keys.Up:
                    KeyStepUp = true;
                    break;
                case Keys.Down:
                    KeyStepDown = true;
                    break;
                case Keys.H:
                    KeyHideMain = true;
                    break;
                default:
                    break;
            }
        }
    }
}
