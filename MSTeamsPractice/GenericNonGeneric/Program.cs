using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNonGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Non-Generic
            ArrayList nonGenList = new ArrayList();

            nonGenList.Add(10);
            nonGenList.Add("Hello");
            nonGenList.Add(20);

            foreach (object item in nonGenList)
            {
                Console.WriteLine(item);
            }

            //Generic
            List<int> genList = new List<int>();

            genList.Add(10);
            genList.Add(20);

            foreach (int item in genList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
