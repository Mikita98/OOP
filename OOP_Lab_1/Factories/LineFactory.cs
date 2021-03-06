﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using OOP_Lab_1.Shapes;

namespace OOP_Lab_1.Factories
{
    [Serializable]
    class LineFactory: FactoryDll.MainFactory
    {
        public override BaseDll.Shape FactoryMethod()
        {
            return new Shapes.Line();
        }

        public override void Draw(BaseDll.Shape shape, Graphics gObject, Pen pen)
        {
            gObject.DrawLine(pen, shape.x1, shape.y1, shape.x2, shape.y2);
        }

    }
}
