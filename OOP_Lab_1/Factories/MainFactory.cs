using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;

namespace OOP_Lab_1.Factories
{
    public abstract class MainFactory
    {
        public abstract Shapes.Shape FactoryMethod();
        public virtual void Draw(Shapes.Shape shape, Graphics gObject, Pen pen){
        }
    }
}
