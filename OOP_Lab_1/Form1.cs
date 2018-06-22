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
using System.Reflection;
using BaseDll;
using FactoryDll;
using GenPluginSystem;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace OOP_Lab_1
{
    public partial class 
        Form1 : Form
    {
        Graphics gObject;
        BaseDll.Shape shape;
        Bitmap DrawArrea;
        Pen pen;
        List<PaintElem> listTemp;
        FactoryDll.MainFactory Factory;
        bool ispress = false;
        List<PaintElem> list;
        List<PaintElem> ListClass;
        public ICollection<Type> plugins;
        public ICollection<Type> FactoryPlugins;
        int TempX, TempY = 0;
        string lang = "Русский";

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
            public BaseDll.Shape shape;
            public FactoryDll.MainFactory Factory;
            public PaintElem(BaseDll.Shape shape1, FactoryDll.MainFactory Factory1)
            {
                shape = shape1;
                Factory = Factory1;
            }
        }
        private void CheckShape()
        {
           
            SelectClass(LBoxClass.SelectedIndex);
        }

        private void SelectClass(int index)
        {
            switch (index)
            {
                case 0:
                    Factory = new Factories.LineFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                case 1:
                    Factory = new Factories.EllipseFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                case 2:
                    Factory = new Factories.CircleFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                case 3:
                    Factory = new Factories.RectangleFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                case 4:
                    Factory = new Factories.SquareFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                case 5:
                    Factory = new Factories.TriangleFactory();
                    shape = Factory.FactoryMethod();
                    shape.scolor = colorDialog1.Color;
                    shape.Pwidth = trackBar1.Value;
                    pen = new Pen(shape.scolor, shape.Pwidth);
                    break;
                default:
                    foreach (var p in FactoryPlugins)
                    {
                        if (LBoxClass.Text + "Factory" == p.Name.ToString())
                        {
                            Factory = (FactoryDll.MainFactory)Activator.CreateInstance(p);
                            //shape = (BaseDll.Shape)Activator.CreateInstance(p, "Line");
                            shape = Factory.FactoryMethod();
                            shape.scolor = colorDialog1.Color;
                            shape.Pwidth = trackBar1.Value;
                            pen = new Pen(shape.scolor, shape.Pwidth);
                            //IsOriginalShape = false;
                            break;
                        }
                    }
                    break;

            }
        }

        private void InitialLang()
        {
            try
            {
                XDocument xdoc = XDocument.Load("info.xml");
                foreach (XElement xe in xdoc.Elements("data").ToList())
                {
                    lang = xe.Element("LangName").Value;
                    ChangeLang();
                    this.BackColor = Color.FromArgb(Convert.ToInt32(xe.Element("FormColor").Value));
                }
            }
            catch(Exception ex)
            {
                if (ex is FileNotFoundException || ex is XmlException)
                MessageBox.Show(ex.Message, "Ошибка загрузки XML, будут установлены значения по умолчанию", MessageBoxButtons.OK,
                       MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                DefaultForm();
            }
            if (lang == "Русский")
            {
                MRus.Checked = true;
                MEng.Checked = false;
            }
            else
            {
                if(lang == "English")
                {
                    MRus.Checked = false;
                    MEng.Checked = true;
                }
            }
        }

        private void Initial()
        {
            InitialLang();
            DrawArrea = new Bitmap(pct1.Width, pct1.Height);
            gObject = Graphics.FromImage(DrawArrea);
            colorDialog1.Color = Color.Black;
            list = new List<PaintElem>();
            ListClass = new List<PaintElem>();
            Pcolor.BackColor = colorDialog1.Color;
            ispress = false;
            Factory = new Factories.LineFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            Factory = new Factories.EllipseFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            Factory = new Factories.CircleFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            Factory = new Factories.RectangleFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            Factory = new Factories.SquareFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            Factory = new Factories.TriangleFactory();
            shape = Factory.FactoryMethod();
            InitialClass(shape, Factory);
            LBoxClass.SelectedIndex = LBoxClass.Items.Count - 1;
            SelectClass(LBoxClass.SelectedIndex);
        }

        private void InitialClass(BaseDll.Shape shape, FactoryDll.MainFactory Factory)
        {
            var Paint = new PaintElem(shape, Factory);
            ListClass.Add(Paint);
            LBoxClass.Items.Add(Paint.shape.GetType().Name.ToString());
        }

        private void DrawFigures()
        {
            gObject.Clear(Color.White);
            for (int i=0; i < list.Count; i++)
            {
                var FactoryTemp = list[i].Factory;
                Pen pentemp = new Pen(list[i].shape.scolor, list[i].shape.Pwidth);
                FactoryTemp.Draw(list[i].shape, gObject, pentemp);
            }
            pct1.Image = DrawArrea;
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
                TempX = e.X;
                TempY = e.Y;
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
                SelectClass(LBoxClass.SelectedIndex);
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
                if (!error)
                {
                    MessageBox.Show("Сохранение успешно выполнено", "Сохранение", MessageBoxButtons.OK,
                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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

        private void LBoxClass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectClass(LBoxClass.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plugins = PluginLoader<BaseDll.Shape>.LoadPlugins("D:\\Visual Studio Projects\\OOP_Lab_1_test\\OOP\\OOP_Lab_1\\Plugins\\LineFactory\\LineFactory\\bin\\Debug");
            FactoryPlugins = FactoryLoader<FactoryDll.MainFactory>.LoadPlugins("D:\\Visual Studio Projects\\OOP_Lab_1_test\\OOP\\OOP_Lab_1\\Plugins\\LineFactory\\LineFactory\\bin\\Debug");
            if (plugins != null)
            {
                foreach (var p in plugins)
                {
                    LBoxClass.Items.Add(p.Name.ToString());
                    //  Shape pl = (Shape)Activator.CreateInstance(p, Color.Black, 5, 25, 600, 600, 600);
                    //  FList.AddToList(pl);
                    //  ReDraw();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void DefaultForm()
        {
                MOpen.Text = "Загрузить";
                MSave.Text = "Сохранить";
                Baddll.Text = "Добавить DLL";
                clearbutton.Text = "Очистить";
                clearfig.Text = "Удалить фигуру";
                Bcolor.Text = "Изменить цвет";
            this.BackColor = Color.White;
        }

        private void ChangeLang()
        {
            try {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("info.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
                // обход всех узлов в корневом элементе
                foreach (XmlNode xnode in xRoot)
                {
                    // получаем атрибут name
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        if (attr == null)
                        {
                            MessageBox.Show("Ошибка прочтения файла", "Ошибка XML ", MessageBoxButtons.OK,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            if (attr.Value.ToString() == lang)
                            {
                                foreach (XmlNode childnode in xnode.ChildNodes)
                                {
                                    if (childnode.Name == "LangLoad")
                                    {
                                        MOpen.Text = childnode.InnerText;
                                    }
                                    // если узел age
                                    if (childnode.Name == "LangSave")
                                    {
                                        MSave.Text = childnode.InnerText;
                                    }
                                    if (childnode.Name == "LangAdd")
                                    {
                                        Baddll.Text = childnode.InnerText;
                                    }
                                    if (childnode.Name == "LangClean")
                                    {
                                        clearbutton.Text = childnode.InnerText;
                                    }
                                    if (childnode.Name == "LangDel")
                                    {
                                        clearfig.Text = childnode.InnerText;
                                    }
                                    if (childnode.Name == "LangChoose")
                                    {
                                        Bcolor.Text = childnode.InnerText;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception x)
            {
                if (x is FileNotFoundException || x is XmlException)
                {
                    MessageBox.Show(x.Message, "Ошибка считывания XML, будут установлены стандартные значения", MessageBoxButtons.OK,
                       MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    DefaultForm();
                }
            }
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MRus.Checked = !(MRus.Checked);
            MEng.Checked = !(MEng.Checked);
            
        }

        private void MEng_Click(object sender, EventArgs e)
        {
            MEng.Checked = !(MEng.Checked);
            MRus.Checked = !(MRus.Checked);
            if (MRus.Checked)
            {
                lang = "Русский";
            }
            else
            {
                lang = "English";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
       }

        private void Form1_Leave(object sender, EventArgs e)
        {
           
        }

        private void MRus_CheckedChanged(object sender, EventArgs e)
        {
            if (MRus.Checked)
            {
                lang = "Русский";
            }
            else
            {
                lang = "English";
            }
            ChangeLang();

        }

        private void MEng_CheckedChanged(object sender, EventArgs e)
        {
            if (MRus.Checked)
            {
                lang = "Русский";
            }
            else
            {
                lang = "English";
            }
            ChangeLang();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XDocument xdoc;
            try
            {
                xdoc = XDocument.Load("info.xml");
                foreach (XElement xe in xdoc.Elements("data").ToList())
                {
                    xe.Element("LangName").Value = lang;
                    xe.Element("FormColor").Value = this.BackColor.ToArgb().ToString();
                    xdoc.Save("info.xml");
                }
            }
            catch (Exception x)
            {
                if (x is FileNotFoundException || x is XmlException)
                {
                    MessageBox.Show(x.Message, "Ошибка сохранения в XML", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(229, 229, 232);
        }

        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(61, 61, 56);
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
