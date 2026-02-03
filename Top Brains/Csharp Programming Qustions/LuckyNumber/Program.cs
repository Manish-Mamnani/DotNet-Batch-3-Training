using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumber
{
    public class Program
    {
        public int DigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                sum += d;
                n /= 10;
            }
            return sum;
        }
        public int Lucky(int low,int high)
        {
            int count = 0;
            for(int  i = low; i <= high; i++)
            {
                if(DigitSum(i*i) == (DigitSum(i) * DigitSum(i)){
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int result = program.Lucky(20, 30);
            Console.WriteLine(result);
        }
    }
}
