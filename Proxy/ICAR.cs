using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ICAR
    {
        void StartDriving();

        void StopDriving();

        void IncreaseSpeed();

        void SlowDown();

        void TurnRight();

        void TurnLeft();

    }
}
