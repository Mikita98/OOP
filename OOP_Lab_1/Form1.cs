using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_Lab_1
{
    public partial class 
        Form1 : Form
    {
        Graphics gObject;
        Shapes.Shape shape;
        Bitmap DrawArrea;
        Pen pen;
        List<PaintElem> listTemp;
        Factories.MainFactory Factory;
        bool ispress = false;
        List<PaintElem> list;
        int TempX, TempY = 0;
        public Form1()
        {
            InitializeComponent();
            Initial();
        }
        [STAThreadAttribute]
        private static void Main()
        {
            Application.Run(new Form1());
        }
        [Serializable]
        public class PaintElem
        {
            public Shapes.Shape shape;
            public Factories.MainFactory Factory;
            public PaintElem(Shapes.Shape shape1, Factories.MainFactory Factory1)
            {
                shape = shape1;
                Factory = Factory1;
            }
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
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;
                    case "Ellipse":
                        Factory = new Factories.EllipseFactory();
                        shape = Factory.FactoryMethod();
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;
                    case "Rectangle":
                        Factory = new Factories.RectangleFactory();
                        shape = Factory.FactoryMethod();
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;
                    case "Square":
                        Factory = new Factories.SquareFactory();
                        shape = Factory.FactoryMethod();
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;
                    case "Triangle":
                        Factory = new Factories.TriangleFactory();
                        shape = Factory.FactoryMethod();
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;
                    case "Circle":
                        Factory = new Factories.CircleFactory();
                        shape = Factory.FactoryMethod();
                        shape.scolor = colorDialog1.Color;
                        shape.Pwidth = trackBar1.Value;
                        pen = new Pen(shape.scolor, shape.Pwidth);
                        break;

                }
            }
        }

        private void Initial()
        {
            DrawArrea = new Bitmap(pct1.Width, pct1.Height);
            gObject = Graphics.FromImage(DrawArrea);
            colorDialog1.Color = Color.Black;
            list = new List<PaintElem>();
            Pcolor.BackColor = colorDialog1.Color;
            ispress = false;
           }

        private void DrawFigures()
        {
            gObject.Clear(Color.White);
            for (int i=0; i < list.Count; i++)
            {
                var FactoryTemp = list[i].Factory;
                //shape.pen.Color = list[i].shape.scolor;
                Pen pentemp = new Pen(list[i].shape.scolor, list[i].shape.Pwidth);
                FactoryTemp.Draw(list[i].shape, gObject, pentemp);
            }
            pct1.Image = DrawArrea;
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
            list.Clear();
            LBox1.Items.Clear();
            pct1.Image = DrawArrea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pct1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ispress)
            {
                ispress = true;
                //CheckShape();
                TempX = e.X;
                TempY = e.Y;
                /*shape.x1 = e.X;
                shape.y1 = e.Y;*/
            }
            else
            {
                ispress = false;
            }
        }

        private void pct1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ispress)
            {
                x1.Text = (e.X).ToString();
                y1.Text = (e.Y).ToString();
            }
            else
            {
                CheckShape();
                shape.x1 = TempX;
                shape.y1 = TempY;
                x2.Text = (e.X).ToString();
                y2.Text = (e.Y).ToString();
                shape.x2 = e.X;
                shape.y2 = e.Y;
                gObject.Clear(Color.White);
                if (list.Count != 0)
                {
                    DrawFigures();
                }
                Factory.Draw(shape, gObject, pen);
                pct1.Image = DrawArrea;
            }
        }

        private void pct1_MouseUp(object sender, MouseEventArgs e)
        {
            ispress = false;
            TempX = 0;
            TempY = 0;
            var Paint = new PaintElem(shape, Factory);
            list.Add(Paint);
            LBox1.Items.Add(Paint.shape);
            pct1.Image = DrawArrea;
        }

        private void Bcolor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                Pcolor.BackColor = colorDialog1.Color;
                if (LBox1.SelectedIndex != -1)
                {
                    list[LBox1.SelectedIndex].shape.scolor = colorDialog1.Color;
                    gObject.Clear(Color.White);
                    for (int i = 0; i < list.Count; i++)
                    {
                        var FactoryTemp = list[i].Factory;
                        Pen pentemp = new Pen(list[i].shape.scolor, list[i].shape.Pwidth);
                        FactoryTemp.Draw(list[i].shape, gObject, pentemp);
                    }
                    pct1.Image = DrawArrea;
                }
            }
        }

        private void MSave_Click(object sender, EventArgs e)
        {
            bool error = false;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, list);
                    }
                }
                catch(SerializationException b)
                {
                    error = true;
                    MessageBox.Show(b.Message, "Ошибка сериализации", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void MOpen_Click(object sender, EventArgs e)
        {
            bool error = false;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                    {
                        listTemp = (List<PaintElem>)formatter.Deserialize(fs);
                    }
                }
                catch(SerializationException b)
                {
                    error = true;
                    MessageBox.Show(b.Message, "Ошибка десериализации ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                if (!error)
                {
                    list.Clear();
                    LBox1.Items.Clear();
                    list.AddRange(listTemp);
                    gObject.Clear(Color.White);
                    for (int i = 0; i < list.Count; i++)
                    {
                        LBox1.Items.Add(list[i].shape);
                        var FactoryTemp = list[i].Factory;
                        Pen pentemp = new Pen(list[i].shape.scolor, list[i].shape.Pwidth);
                        FactoryTemp.Draw(list[i].shape, gObject, pentemp);
                    }
                    pct1.Image = DrawArrea;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (LBox1.SelectedIndex != -1)
            {
                list[LBox1.SelectedIndex].shape.Pwidth = trackBar1.Value;
                gObject.Clear(Color.White);
                for (int i = 0; i < list.Count; i++)
                {
                    var FactoryTemp = list[i].Factory;
                    Pen pentemp = new Pen(list[i].shape.scolor, list[i].shape.Pwidth);
                    FactoryTemp.Draw(list[i].shape, gObject, pentemp);
                }
                pct1.Image = DrawArrea;
            }
        }

        private void clearfig_Click(object sender, EventArgs e)
        {
            if (LBox1.SelectedIndex != -1)
            {
                list.RemoveAt(LBox1.SelectedIndex);
                LBox1.Items.RemoveAt(LBox1.SelectedIndex);
                DrawFigures();
            }
        }
    }
}
