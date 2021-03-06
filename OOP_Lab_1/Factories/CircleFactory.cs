﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OOP_Lab_1.Shapes;
using FactoryDll;
namespace OOP_Lab_1.Factories
{
    [Serializable]
    class CircleFactory : FactoryDll.MainFactory
    {
        public override BaseDll.Shape FactoryMethod()
        {
            return new Shapes.Circle();
        }

        private bool CalcWidth(BaseDll.Shape shape)
        {
            if ((Math.Abs(shape.x1 - shape.x2) >= Math.Abs(shape.y2 - shape.y1)))
            {
                shape.width = Math.Abs(shape.y2 - shape.y1);
                return true;
            }
            else
            {
                shape.width = Math.Abs(shape.x2 - shape.x1);
                return false;
            }
        }

        private void Draw1(BaseDll.Shape shape, Graphics gObject, Pen pen, bool xby)
        {
            if (xby)
                gObject.DrawEllipse(pen, new Rectangle(shape.x1, shape.y2, shape.width, shape.width));
            else
                gObject.DrawEllipse(pen, new Rectangle(shape.x1, shape.y1 - Math.Abs(shape.x1 - shape.x2), shape.width, shape.width));
        }

        private void Draw2(BaseDll.Shape shape, Graphics gObject, Pen pen, bool xby)
        {
            if (xby)
                gObject.DrawEllipse(pen, new Rectangle(shape.x1 - Math.Abs(shape.y1 - shape.y2), shape.y2, shape.width, shape.width));
            else
                gObject.DrawEllipse(pen, new Rectangle(shape.x2, shape.y1 - Math.Abs(shape.x1 - shape.x2), shape.width, shape.width));
        }

        private void Draw3(BaseDll.Shape shape, Graphics gObject, Pen pen, bool xby)
        {
            if (xby)
                gObject.DrawEllipse(pen, new Rectangle(shape.x1 - Math.Abs(shape.y1 - shape.y2), shape.y1, shape.width, shape.width));
            else
                gObject.DrawEllipse(pen, new Rectangle(shape.x2, shape.y1, shape.width, shape.width));
        }

        private void Draw4(BaseDll.Shape shape, Graphics gObject, Pen pen, bool xby)
        {
            if (xby)
                gObject.DrawEllipse(pen, new Rectangle(shape.x1, shape.y1, shape.width, shape.width));
            else
                gObject.DrawEllipse(pen, new Rectangle(shape.x1, shape.y1, shape.width, shape.width));
        }

        public override void Draw(BaseDll.Shape shape, Graphics gObject, Pen pen)
        {
            bool xby;
            xby = CalcWidth(shape);
            if (shape.x1 > shape.x2 && shape.y1 > shape.y2)
            {
                Draw2(shape, gObject, pen, xby);
            }
            else if (shape.y1 > shape.y2 && shape.x1 < shape.x2)
            {
                Draw1(shape, gObject, pen, xby);
            }
            else if (shape.x1 > shape.x2 && shape.y1 < shape.y2)
            {
                Draw3(shape, gObject, pen, xby);
            }
            else
            {
                Draw4(shape, gObject, pen, xby);
            }

        }

    }
}
