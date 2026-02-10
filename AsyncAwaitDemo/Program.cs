using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            DemoClass demoObj = new DemoClass();
            
            int sum = demoObj.DoTask1();

            demoObj.DoTask2();
            Console.WriteLine("\nTotal is: "+sum);
        }
    }
}
