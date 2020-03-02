using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CarProxy: IMonitorService
    {
        public CarProxy()
        {

        }

        public string ShowFuelMode()
        {
            IMonitorService Car = new RealCar(); //
            return Car.ShowFuelMode();
        }

        public string ShowLocation()
        {
            IMonitorService Car = new RealCar();
            return Car.ShowLocation();
        }
    }
}
