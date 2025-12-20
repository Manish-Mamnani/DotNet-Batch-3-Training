using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Console
{
    internal class Person
    {
        #region Fields
        int id;
        string name;
        int age;
        #endregion

        public Person()
        {
            Console.WriteLine("Person class constructor invoked.");
        }

        ~Person(){
            Console.WriteLine("Person class constructor invoked.");
        }
        
        /// <summary>
        /// Display method for demo
        /// </summary>
        /// <param name="obj"></param>
        public void Display(object obj)
        {

        }
    }
}
