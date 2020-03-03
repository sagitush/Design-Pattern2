using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealCar : ICAR, IMonitorService
    {
        public void IncreaseSpeed()
        {
            Console.WriteLine("IncreaseSpeed"); 
        }

        public string ShowFuelMode()
        {
            return "the fuel mode is very good";
        }

        public string ShowLocation()
        {
            return "the location is good";
        }

        public void SlowDown()
        {
            Console.WriteLine("Slow down");
        }
      
        public void StartDriving()
        {
            Console.WriteLine("Start driving");
        }

        public void StopDriving()
        {
            Console.WriteLine("stop driving");
        }

        public void TurnLeft()
        {
            Console.WriteLine("turn left");
        }

        public void TurnRight()
        {
            Console.WriteLine("turn right");
        }
    }
}
