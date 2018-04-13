using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using OOP_Lab_1.Shapes;

namespace OOP_Lab_1.Factories
{
    class CircleFactory : MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Circle();
        }

        public override void Draw(Shapes.Shape shape, Graphics gObject, System.Drawing.Pen pen)
        {
            int Width;
            int Height;
            if (shape.x1 < shape.x2)
            {
                Width = shape.x2 - shape.x1;
            }
            else
            {
                Width = shape.x1 - shape.x2;
            }
            if (shape.y1 < shape.y2)
            {
                Height = shape.y2 - shape.y1;
            }
            else
            {
                Height = shape.y1 - shape.y2;
            }
            if (Width > Height)
                gObject.DrawEllipse(pen, shape.x1, shape.y1, Width, Width);
            else
                gObject.DrawEllipse(pen, shape.x1, shape.y1, Height, Height);
        }

    }
}
