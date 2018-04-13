using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_1.Factories
{
    abstract class MainFactory
    {
        public abstract Shapes.Shape FactoryMethod();
        public abstract Shapes.Shape Draw();
    }
}
