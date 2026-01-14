using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter 1st Number: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            num2 = Int32.Parse(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            int numResult = logic.AddMe(num1, num2);

            Console.WriteLine($"The sum of {num1} and {num2}: {numResult}");
        }
    }
}
