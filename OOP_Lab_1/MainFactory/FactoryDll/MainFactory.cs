using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDll;
using System.Drawing;

namespace FactoryDll
{
    [Serializable]
    public abstract class MainFactory
    {
            public abstract BaseDll.Shape FactoryMethod();
            public virtual void Draw(BaseDll.Shape shape, Graphics gObject, Pen pen)
        {

        }
    }
}
