using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    interface IVehicle
    {
        const int minSpeed = 0;
        static int maxSpeed = 200;
        static double GetTime(double distance, double speed) => distance/speed;
        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }
    }


    class InterfaceTask1
    {
    }
}
