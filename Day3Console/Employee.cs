using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Console
{
    internal class Employee: Person  //IS_A Relationship
    {
        string skill;
        string desig;
        int empID;
        int bSal;

        public Employee()
        {
            Console.WriteLine("Employee class constructor invoked.");
        }

        ~Employee()
        {
            Console.WriteLine("Employee class constructor invoked.");
        }

    }
}
