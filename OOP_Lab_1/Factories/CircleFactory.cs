using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace OOP_Lab_1.Factories
{
    class CircleFactory : MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Circle();
        }
    }
}
