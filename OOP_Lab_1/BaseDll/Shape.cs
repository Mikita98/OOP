﻿using System;
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
    [Serializable]
    public abstract class Shape
    {
        public Color scolor, 
                fcolor;
        public int Pwidth;
        public int x1, 
                   x2, 
                   y1, 
                   y2;
        public int width;
        public int height;
        public int xtemp;
        public int ytemp;
        public void ShapeParam()
        {
            width = Math.Abs(x1 - x2);
            height = Math.Abs(y1 - y2);
        }

    }
}
