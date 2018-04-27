using System;
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
    class LineFactory: MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Line();
        }

        public override void Draw(Shapes.Shape shape, Graphics gObject)
        {
            gObject.DrawLine(shape.pen, shape.x1, shape.y1, shape.x2, shape.y2);
        }

    }
}
