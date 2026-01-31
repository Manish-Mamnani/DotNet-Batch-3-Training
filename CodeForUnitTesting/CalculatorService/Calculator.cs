using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class Calculator
    {

        public int Addme(int num1, int num2)
        {
            return num1 + num2;
        }

        public int SubMe(int num1, int num2) => num1 - num2;

        public float DivMe(float num1, float num2)
        {
            float numRes = 0;
            if (num2 > 0)
            {
                numRes = num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("You cannot divide by zero");
            }
            return numRes;
        }
    }
}
