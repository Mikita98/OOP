namespace OOP_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clearbutton = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.coordinate1 = new System.Windows.Forms.Label();
            this.coordinate2 = new System.Windows.Forms.Label();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.Bcolor = new System.Windows.Forms.Button();
            this.Pcolor = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MRus = new System.Windows.Forms.ToolStripMenuItem();
            this.MEng = new System.Windows.Forms.ToolStripMenuItem();
            this.LBox1 = new System.Windows.Forms.ListBox();
            this.clearfig = new System.Windows.Forms.Button();
            this.LBoxClass = new System.Windows.Forms.ListBox();
            this.Baddll = new System.Windows.Forms.Button();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(12, 214);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(129, 25);
            this.clearbutton.TabIndex = 7;
            this.clearbutton.Text = "Очистить";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // x1
            // 
            this.x1.Enabled = false;
            this.x1.Location = new System.Drawing.Point(12, 293);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 22);
            this.x1.TabIndex = 8;
            // 
            // y1
            // 
            this.y1.Enabled = false;
            this.y1.Location = new System.Drawing.Point(12, 321);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 22);
            this.y1.TabIndex = 9;
            // 
            // x2
            // 
            this.x2.Enabled = false;
            this.x2.Location = new System.Drawing.Point(160, 293);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 22);
            this.x2.TabIndex = 10;
            // 
            // y2
            // 
            this.y2.Enabled = false;
            this.y2.Location = new System.Drawing.Point(160, 321);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 22);
            this.y2.TabIndex = 11;
            // 
            // coordinate1
            // 
            this.coordinate1.AutoSize = true;
            this.coordinate1.Location = new System.Drawing.Point(9, 263);
            this.coordinate1.Name = "coordinate1";
            this.coordinate1.Size = new System.Drawing.Size(139, 17);
            this.coordinate1.TabIndex = 12;
            this.coordinate1.Text = "Первая координата";
            // 
            // coordinate2
            // 
            this.coordinate2.AutoSize = true;
            this.coordinate2.Location = new System.Drawing.Point(157, 263);
            this.coordinate2.Name = "coordinate2";
            this.coordinate2.Size = new System.Drawing.Size(138, 17);
            this.coordinate2.TabIndex = 13;
            this.coordinate2.Text = "Вторая координата";
            // 
            // pct1
            // 
            this.pct1.BackColor = System.Drawing.Color.White;
            this.pct1.Location = new System.Drawing.Point(353, 12);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(1152, 516);
            this.pct1.TabIndex = 14;
            this.pct1.TabStop = false;
            this.pct1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseDown);
            this.pct1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseMove);
            this.pct1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseUp);
            // 
            // Bcolor
            // 
            this.Bcolor.Location = new System.Drawing.Point(12, 361);
            this.Bcolor.Name = "Bcolor";
            this.Bcolor.Size = new System.Drawing.Size(84, 57);
            this.Bcolor.TabIndex = 15;
            this.Bcolor.Text = "Выбрать цвет";
            this.Bcolor.UseVisualStyleBackColor = true;
            this.Bcolor.Click += new System.EventHandler(this.Bcolor_Click);
            // 
            // Pcolor
            // 
            this.Pcolor.Location = new System.Drawing.Point(102, 361);
            this.Pcolor.Name = "Pcolor";
            this.Pcolor.Size = new System.Drawing.Size(53, 57);
            this.Pcolor.TabIndex = 16;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(170, 381);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выбрать Толщину";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSave,
            this.MOpen,
            this.языкToolStripMenuItem,
            this.темаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1515, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MSave
            // 
            this.MSave.Name = "MSave";
            this.MSave.Size = new System.Drawing.Size(95, 24);
            this.MSave.Text = "Сохранить";
            this.MSave.Click += new System.EventHandler(this.MSave_Click);
            // 
            // MOpen
            // 
            this.MOpen.Name = "MOpen";
            this.MOpen.Size = new System.Drawing.Size(79, 24);
            this.MOpen.Text = "Открыть";
            this.MOpen.Click += new System.EventHandler(this.MOpen_Click);
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MRus,
            this.MEng});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.языкToolStripMenuItem.Text = "Язык";
            // 
            // MRus
            // 
            this.MRus.Checked = true;
            this.MRus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MRus.Name = "MRus";
            this.MRus.Size = new System.Drawing.Size(138, 26);
            this.MRus.Text = "Русский";
            this.MRus.CheckedChanged += new System.EventHandler(this.MRus_CheckedChanged);
            this.MRus.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // MEng
            // 
            this.MEng.Name = "MEng";
            this.MEng.Size = new System.Drawing.Size(138, 26);
            this.MEng.Text = "English";
            this.MEng.CheckedChanged += new System.EventHandler(this.MEng_CheckedChanged);
            this.MEng.Click += new System.EventHandler(this.MEng_Click);
            // 
            // LBox1
            // 
            this.LBox1.FormattingEnabled = true;
            this.LBox1.ItemHeight = 16;
            this.LBox1.Location = new System.Drawing.Point(12, 444);
            this.LBox1.Name = "LBox1";
            this.LBox1.Size = new System.Drawing.Size(198, 228);
            this.LBox1.TabIndex = 21;
            this.LBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clearfig
            // 
            this.clearfig.Location = new System.Drawing.Point(220, 443);
            this.clearfig.Name = "clearfig";
            this.clearfig.Size = new System.Drawing.Size(97, 50);
            this.clearfig.TabIndex = 22;
            this.clearfig.Text = "Удалить фигуру";
            this.clearfig.UseVisualStyleBackColor = true;
            this.clearfig.Click += new System.EventHandler(this.clearfig_Click);
            // 
            // LBoxClass
            // 
            this.LBoxClass.FormattingEnabled = true;
            this.LBoxClass.ItemHeight = 16;
            this.LBoxClass.Location = new System.Drawing.Point(12, 31);
            this.LBoxClass.Name = "LBoxClass";
            this.LBoxClass.Size = new System.Drawing.Size(336, 164);
            this.LBoxClass.TabIndex = 23;
            this.LBoxClass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBoxClass_MouseDoubleClick);
            // 
            // Baddll
            // 
            this.Baddll.Location = new System.Drawing.Point(185, 216);
            this.Baddll.Name = "Baddll";
            this.Baddll.Size = new System.Drawing.Size(121, 23);
            this.Baddll.TabIndex = 24;
            this.Baddll.Text = "Добавить DLL ";
            this.Baddll.UseVisualStyleBackColor = true;
            this.Baddll.Click += new System.EventHandler(this.button1_Click);
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлаяToolStripMenuItem,
            this.тёмнаяToolStripMenuItem});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // тёмнаяToolStripMenuItem
            // 
            this.тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            this.тёмнаяToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.тёмнаяToolStripMenuItem.Text = "Тёмная";
            this.тёмнаяToolStripMenuItem.Click += new System.EventHandler(this.тёмнаяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1515, 694);
            this.Controls.Add(this.Baddll);
            this.Controls.Add(this.LBoxClass);
            this.Controls.Add(this.clearfig);
            this.Controls.Add(this.LBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Pcolor);
            this.Controls.Add(this.Bcolor);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.coordinate2);
            this.Controls.Add(this.coordinate1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label coordinate1;
        private System.Windows.Forms.Label coordinate2;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Button Bcolor;
        private System.Windows.Forms.Panel Pcolor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSave;
        private System.Windows.Forms.ToolStripMenuItem MOpen;
        private System.Windows.Forms.ListBox LBox1;
        private System.Windows.Forms.Button clearfig;
        private System.Windows.Forms.ListBox LBoxClass;
        private System.Windows.Forms.Button Baddll;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MRus;
        private System.Windows.Forms.ToolStripMenuItem MEng;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тёмнаяToolStripMenuItem;
    }
}