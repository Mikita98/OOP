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
        List<Figures> list;
        Figures Paints;

        public struct Figures
        {
            public Shapes.Shape shape;
            public Pen pen;
            public int width;
            public int height;
            public int x1;
            public int x2;
            public int y1;
            public int y2;
            
            public Figures(Shapes.Shape shape_,Pen pen_, int width_, int height_, int x1_, int x2_, int y1_, int y2_)
            {
                shape = shape_;
                pen = pen_;
                width = width_;
                height = height_;
                x1 = x1_;
                x2 = x2_;
                y1 = y1_;
                y2 = y2_;
            }

        }
        public Form1()
        {
            InitializeComponent();
            Initial();
        }
        private static void Main()
        {
            Application.Run(new Form1());
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
            list = new List<Figures>();
            CheckShape();
            ispress = false;
        }

        private void DrawFigures()
        {
            for (int i=0; i<list.Count; i++)
            {
                Paints = (Figures)list[i];
                //Paints.shape = Factory.FactoryMethod();
                shape = Paints.shape;
                redPen = Paints.pen;
                shape.width = Paints.width;
                shape.height = Paints.height;
                shape.x1 = Paints.x1;
                shape.x2 = Paints.x2;
                shape.y1 = Paints.y1;
                shape.y2 = Paints.y2;
                Factory.Draw(Paints.shape, gObject, Paints.pen);
            }
            
            
        }


        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (ispress == false)
            {
                ispress = true;
                shape.x1 = e.X;
                shape.y1 = e.Y;
            }
            else
            {
                ispress = false;
                shape.x2 = e.X;
                shape.y2 = e.Y;
                Factory.Draw(shape, gObject, redPen);
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
                list.Add(new Figures(shape, redPen, shape.width, shape.height, shape.x1, shape.x2, shape.y1, shape.y2));
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            gObject.Clear(Color.White);
        }
    }
}
