using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ThreeDLighting :TypesDecoratorBase
    {
        public ThreeDLighting(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " ThreeD lighting";
        }
    }
}
