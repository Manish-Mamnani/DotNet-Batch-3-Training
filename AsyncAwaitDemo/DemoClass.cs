using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class DemoClass
    {
        public async Task<int> DoTask1()
        {
            int sum = 0;
            for(int i = 1; i <= 50; i++)
            {
                await Task.Delay(1000);
                sum += i;
            }
            return sum; 
        }

        public async void DoTask2()
        {
            string[] arrName = { "Alok", "Amit", "Riya", "Mahesh", "Suresh", "Vivek","Yash" };

            foreach(string name in arrName)
            {
                char[] arrChar = name.ToCharArray();
                foreach(char c in arrChar)
                {
                    await Task.Delay(1000);
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }

    }
}
