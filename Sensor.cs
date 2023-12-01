using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressureAlarmLibary
{
    public class Sensor : ISensor
    {

        private readonly Random rand = new Random();

        public double QueryHardwareForPsiValue()

        {

            // placeholder implementation that simulates a real sensor in a real tire

            return rand.NextDouble() * (40 -10) + 10; // some value; simulates a real sensor with random pressure between 10 and 40 psi

        }
    }
}
