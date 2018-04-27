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
            this.Line = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clearbutton = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.coordinate1 = new System.Windows.Forms.Label();
            this.coordinate2 = new System.Windows.Forms.Label();
            this.pct1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(12, 42);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(100, 25);
            this.Line.TabIndex = 1;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
        
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(12, 69);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(170, 25);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(12, 96);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(100, 25);
            this.Ellipse.TabIndex = 3;
            this.Ellipse.TabStop = true;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(12, 123);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(100, 25);
            this.Circle.TabIndex = 4;
            this.Circle.TabStop = true;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(12, 150);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(130, 21);
            this.Triangle.TabIndex = 5;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(12, 177);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(120, 21);
            this.Square.TabIndex = 6;
            this.Square.TabStop = true;
            this.Square.Text = "Квадрат";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
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
            this.pct1.Location = new System.Drawing.Point(353, 12);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(1152, 516);
            this.pct1.TabIndex = 14;
            this.pct1.TabStop = false;
            this.pct1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseDown);
            this.pct1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseMove);
            this.pct1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 694);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.coordinate2);
            this.Controls.Add(this.coordinate1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Line);
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label coordinate1;
        private System.Windows.Forms.Label coordinate2;
        private System.Windows.Forms.PictureBox pct1;
    }
}