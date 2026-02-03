using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHazard
{
    public class RobotSafetyException : Exception
    {
        public RobotSafetyException() { }
        public RobotSafetyException(string message) : base(message) { }
    }
}
