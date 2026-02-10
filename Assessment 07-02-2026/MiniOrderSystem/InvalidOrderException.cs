using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOrderSystem
{
    public class InvalidOrderException : Exception
    {
        public InvalidOrderException() { }
        public InvalidOrderException(string message) : base(message) { }
    }
}
