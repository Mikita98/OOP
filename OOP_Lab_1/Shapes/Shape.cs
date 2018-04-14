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
        public int x1, 
                   x2, 
                   y1, 
                   y2;
        public int width;
        public int height;
        public void ShapeWidth()
        {
            if (x1 < x2)
            {
                width = x2 - x1;
                
            }
            else
            {
                width = x1 - x2;
            }
        }

        public void ShapeHeight()
        {
            if (y1 < y2)
            {
             height = y2 - y1;
                
            }
            else
            {
              height = y1 - y2;
            }
        }

    }
}
