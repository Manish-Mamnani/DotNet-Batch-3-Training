using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHazard
{
    public class RobotHazardAuditor
    {
        public double state(string machineryState)
        {
            double s = 0;
            if (machineryState == "Worn") s = 1.3;
            if (machineryState == "Faulty") s = 2.0;
            if (machineryState == "Critical") s = 3.0;
            return s;
        }
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            double hazardRisk = 0.0;
            if (armPrecision > 1.0 && armPrecision < 0.0)
            {
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            }
            if (workerDensity < 0 && workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }
            if (machineryState != "Worn" || machineryState != "Faulty" || machineryState != "Critical")
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }

            hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * state(machineryState));
            return hazardRisk;

        }
    }
}
