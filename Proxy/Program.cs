using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCar car = new RealCar();
            GetProxy(new CarProxy());

            car.SlowDown();
            car.StartDriving();
            car.StopDriving();
            car.IncreaseSpeed();
            car.TurnLeft();
            car.TurnRight();
        }

        static void GetProxy(IMonitorService proxy)
        {
            Console.WriteLine(proxy.ShowFuelMode());
            Console.WriteLine(proxy.ShowLocation());
        }
    }
 }

