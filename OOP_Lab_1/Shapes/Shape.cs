using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Drawing;

namespace OOP_Lab_1.Shapes
{
    public abstract class Shape
    {
        public Color scolor, fcolor;
        public int x1=0, 
                   x2=0, 
                   y1=0, 
                   y2=0;
        private int width;
        private int height;
        private int ShapeWidth()
        {
            if (x1 < x2)
            {
                int Width = x2 - x1;
                return Width;
            }
            else
            {
                int Width = x1 - x2;
                return Width;
            }
        }

        private int ShapeHeight()
        {
            if (y1 < y2)
            {
                int Height = y2 - y1;
                return Height;
            }
            else
            {
                int Height = y1 - y2;
                return Height;
            }
        }

    }
}
