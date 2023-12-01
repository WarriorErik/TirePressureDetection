using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pressureAlarmLibary
{
    public class PressureAlarm
    {

        private const double lowPressureThreshold = 15;

        private const double highPressureThreshold = 32;

        ISensor sensor;

        public PressureAlarm(ISensor sensor)
        {
            this.sensor = sensor;
        }

        bool alarm = false;

        public void Check()

        {

            double pressure = sensor.QueryHardwareForPsiValue();

            if (pressure < lowPressureThreshold || highPressureThreshold < pressure)

            {

                alarm = true;

            }

        }

        public bool Alarm

        {

            get { return alarm; }

        }
    }
}
