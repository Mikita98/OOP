using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1.Factories
{
    class LineFactory: MainFactory
    {
        public override Shapes.Shape FactoryMethod()
        {
            return new Shapes.Line();
        }
    }
}
