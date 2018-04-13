using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Lab_1.Shapes;

namespace OOP_Lab_1.Factories
{
    class EllipseFactory: MainFactory
    {
        public override Shape FactoryMethod()
        {
            return new Shapes.Ellipse();
        }
    }
}
