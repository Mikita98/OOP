using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using OOP_Lab_1.Shapes;
using System.Drawing;

namespace OOP_Lab_1.Factories
{
    [Serializable]
    class RectangleFactory: MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Rectangles();
        }

        public override void Draw(Shapes.Shape shape, Graphics gObject, Pen pen)
        {
                    if (shape.x1 > shape.x2 && shape.y1 > shape.y2)
                    {

                        gObject.DrawRectangle(pen, new Rectangle(shape.x2, shape.y2, Math.Abs(shape.x1 - shape.x2), Math.Abs(shape.y1 - shape.y2)));

                    }
                    else if (shape.y1 > shape.y2 && shape.x1 < shape.x2)
                    {

                        gObject.DrawRectangle(pen, new Rectangle(shape.x1, shape.y2, Math.Abs(shape.x2 - shape.x1), Math.Abs(shape.y2 - shape.y1)));
                    }
                    else if (shape.x1 > shape.x2 && shape.y1 < shape.y2)
                    {
                        gObject.DrawRectangle(pen, new Rectangle(shape.x2, shape.y1, Math.Abs(shape.x2 - shape.x1), Math.Abs(shape.y2 - shape.y1)));
                    }
                    else gObject.DrawRectangle(pen, new Rectangle(shape.x1, shape.y1, Math.Abs(shape.x2 - shape.x1), Math.Abs(shape.y2 - shape.y1)));

                
        }

    }
}
