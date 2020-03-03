using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow baseWindow = new BaseWindow();
            IWindow threeD = new ThreeDLighting(baseWindow);
            IWindow shadow = new Shadowing(threeD);
            //Console.WriteLine(shadow.GetDetails());
           

           IWindow colrfulShadowingThreeDPartialMirroFlashingBase= new ColorfulFrame(new Shadowing(new ThreeDLighting(new PartialMirroring(new BackgroundFlashing(new BaseWindow())))));
           Console.WriteLine(colrfulShadowingThreeDPartialMirroFlashingBase.GetDetails());
         

        }
    }
}
