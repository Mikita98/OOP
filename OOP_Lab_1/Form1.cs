using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_1
{
    public partial class Form1 : Form
    {
        Graphics gObject;
        Shapes.Shape shape;
        Pen redPen;
        Factories.MainFactory Factory;
        bool ispress = false;
        public Form1()
        {
            InitializeComponent();
            Initial();
        }
        private static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*Graphics gObject = canvas.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);
            gObject.DrawLine(redPen, 10, 10, 400, 376);*/
           
        }

        private void CheckShape()
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "Line":
                        Factory = new Factories.LineFactory();
                        break;
                    case "Ellipse":
                        Factory = new Factories.EllipseFactory();
                        break;
                    case "Rectagle":
                        Factory = new Factories.RectangleFactory();
                        break;
                    case "Square":
                        Factory = new Factories.SquareFactory();
                        break;
                    case "Triangle":
                        Factory = new Factories.TriangleFactory();
                        break;
                    case "Circle":
                        Factory = new Factories.CircleFactory();
                        break;

                }
            }
        }

        private void Initial()
        {
            gObject = canvas.CreateGraphics();
            shape = Factory.FactoryMethod();
            redPen = new Pen(Color.Red, 8);
            CheckShape();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            shape.x2 = e.X;
            shape.y2 = e.Y;
            if (ispress)
            {
                gObject.Clear(Color.White);
                Draw();
            }
        }
        public void Draw()
        {
            gObject.DrawLine(redPen, shape.x1, shape.y1, shape.x2, shape.y2);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (ispress)
                ispress = false;
            else
                ispress = true;
            shape.x1 = e.X;
            shape.y1 = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Line_Click(object sender, EventArgs e)
        {
            CheckShape();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            CheckShape();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            CheckShape();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            CheckShape();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            CheckShape();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            CheckShape();
        }
    }
}
