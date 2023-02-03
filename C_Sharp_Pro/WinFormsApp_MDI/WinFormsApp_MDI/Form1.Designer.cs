namespace WinFormsApp_MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.加载子窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.子窗体1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.子窗体2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HorizontallyTileMyWindows);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VerticallyTileMyWindows);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CascadeMyWindows);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载子窗体ToolStripMenuItem,
            this.水平ToolStripMenuItem,
            this.垂直ToolStripMenuItem,
            this.重叠ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 加载子窗体ToolStripMenuItem
            // 
            this.加载子窗体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.子窗体1ToolStripMenuItem,
            this.子窗体2ToolStripMenuItem});
            this.加载子窗体ToolStripMenuItem.Name = "加载子窗体ToolStripMenuItem";
            this.加载子窗体ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.加载子窗体ToolStripMenuItem.Text = "加载子窗体";
            this.加载子窗体ToolStripMenuItem.Click += new System.EventHandler(this.Form1_Load);
            // 
            // 水平ToolStripMenuItem
            // 
            this.水平ToolStripMenuItem.Name = "水平ToolStripMenuItem";
            this.水平ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.水平ToolStripMenuItem.Text = "水平";
            this.水平ToolStripMenuItem.Click += new System.EventHandler(this.HorizontallyTileMyWindows);
            // 
            // 垂直ToolStripMenuItem
            // 
            this.垂直ToolStripMenuItem.Name = "垂直ToolStripMenuItem";
            this.垂直ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.垂直ToolStripMenuItem.Text = "垂直";
            this.垂直ToolStripMenuItem.Click += new System.EventHandler(this.VerticallyTileMyWindows);
            // 
            // 重叠ToolStripMenuItem
            // 
            this.重叠ToolStripMenuItem.Name = "重叠ToolStripMenuItem";
            this.重叠ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.重叠ToolStripMenuItem.Text = "重叠";
            this.重叠ToolStripMenuItem.Click += new System.EventHandler(this.CascadeMyWindows);
            // 
            // 子窗体1ToolStripMenuItem
            // 
            this.子窗体1ToolStripMenuItem.Name = "子窗体1ToolStripMenuItem";
            this.子窗体1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.子窗体1ToolStripMenuItem.Text = "子窗体1";
            // 
            // 子窗体2ToolStripMenuItem
            // 
            this.子窗体2ToolStripMenuItem.Name = "子窗体2ToolStripMenuItem";
            this.子窗体2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.子窗体2ToolStripMenuItem.Text = "子窗体2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 加载子窗体ToolStripMenuItem;
        private ToolStripMenuItem 水平ToolStripMenuItem;
        private ToolStripMenuItem 垂直ToolStripMenuItem;
        private ToolStripMenuItem 重叠ToolStripMenuItem;
        private ToolStripMenuItem 子窗体1ToolStripMenuItem;
        private ToolStripMenuItem 子窗体2ToolStripMenuItem;
    }
}