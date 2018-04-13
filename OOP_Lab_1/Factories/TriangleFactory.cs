using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace OOP_Lab_1.Factories
{
    class TriangleFactory:MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Triangle();
        }

        public override void Draw(Shapes.Shape shape, Graphics gObject, Pen pen)
        {
            Point point1 = new Point(shape.x1, shape.y1);
            Point point2 = new Point(shape.x2 / 2, shape.y2);
            Point point3 = new Point(shape.x1, shape.y2);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            gObject.DrawPolygon(pen, curvePoints);
        }

    }
}
