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
            shape.ShapeHeight();
            shape.ShapeWidth();
            if (shape.width > shape.height)
                gObject.DrawEllipse(pen, shape.x1, shape.y1, shape.width, shape.width);
            else
                gObject.DrawEllipse(pen, shape.x1, shape.y1, shape.height, shape.height);
        }

    }
}
