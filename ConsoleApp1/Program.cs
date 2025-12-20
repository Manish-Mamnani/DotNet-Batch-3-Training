using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void SwapMe(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Inside SwapMe function :");
            Console.WriteLine("Num1: {0}, Num2: {1}",num1,num2);
        }

        public int AddToCart(params int[] p1)
        {
            int total=0;
            foreach(int i in p1)
            {
                total += i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("Before SwapMe function :");
            Console.WriteLine("Num1: {0}, Num2: {1}", num1, num2);
            SwapMe(ref num1, ref num2);
            Console.WriteLine("After SwapMe function :");
            Console.WriteLine("Num1: {0}, Num2: {1}", num1, num2);

            Program pObj = new Program();
            int total1 = pObj.AddToCart(10, 20);
            int total2 = pObj.AddToCart(10, 20, 30, 40, 60, 100);
            Console.WriteLine(total1+" "+total2);
        }
    }
}
