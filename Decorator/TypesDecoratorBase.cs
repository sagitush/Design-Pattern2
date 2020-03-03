using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public abstract class TypesDecoratorBase: IWindow
    {
        protected IWindow window;
        public abstract string GetDetails();

        public TypesDecoratorBase(IWindow window)
        {
            this.window = window;
        }

    }
}
