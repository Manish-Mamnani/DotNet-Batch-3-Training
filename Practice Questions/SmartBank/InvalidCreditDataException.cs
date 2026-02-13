using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class InvalidCreditDataException : Exception
    {
        public InvalidCreditDataException() { }

        public InvalidCreditDataException(string errorMsg) : base(errorMsg) { }
    }
}
