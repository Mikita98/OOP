using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using FactoryDll;
using BaseDll;
using LineLib;


namespace LineLib
{
    [Serializable]
    class LineFactory : FactoryDll.MainFactory
    {
        public LineFactory()
        {

        }

        public override BaseDll.Shape FactoryMethod()
        {
            return new Line();
        }

        public override void Draw(BaseDll.Shape shape, Graphics gObject, Pen pen)
        {
            gObject.DrawLine(pen, shape.x1, shape.y1, shape.x2, shape.y2);
        }

    }
}
