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
                        shape = Factory.FactoryMethod();
                        break;
                    case "Ellipse":
                        Factory = new Factories.EllipseFactory();
                        shape = Factory.FactoryMethod();
                        break;
                    case "Rectangle":
                        Factory = new Factories.RectangleFactory();
                        shape = Factory.FactoryMethod();
                        break;
                    case "Square":
                        Factory = new Factories.SquareFactory();
                        shape = Factory.FactoryMethod();
                        break;
                    case "Triangle":
                        Factory = new Factories.TriangleFactory();
                        shape = Factory.FactoryMethod();
                        break;
                    case "Circle":
                        Factory = new Factories.CircleFactory();
                        shape = Factory.FactoryMethod();
                        break;

                }
            }
        }

        private void Initial()
        {
            gObject = canvas.CreateGraphics();
            redPen = new Pen(Color.Red, 8);
            CheckShape();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (ispress)
            {
                gObject.Clear(Color.White);
                shape.x2 = e.X;
                shape.y2 = e.Y;
                Factory.Draw(shape, gObject, redPen);
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
                ispress = true;
                shape.x1 = e.X;
                shape.y1 = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            ispress = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
