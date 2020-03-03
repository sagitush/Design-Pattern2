using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PartialMirroring:TypesDecoratorBase
    {
        public PartialMirroring(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return window.GetDetails() + " Partial mirroring";

        }
    }
}
