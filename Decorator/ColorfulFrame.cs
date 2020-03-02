using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ColorfulFrame: TypesDecoratorBase
    {
        public ColorfulFrame(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " colorful frame";
        }
    }
}
