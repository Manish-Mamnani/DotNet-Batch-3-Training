using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DictionaryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int,List<int>>();

            int choice = 1;
            do
            {
                switch (choice)
                {
                    case 1:
                        {
                            if (!dict.ContainsKey(input))
                            {
                                dict[input] = new List<int>();
                            }
                            dict[input].Add(value);
                            break;
                        }
                }
            } while (choice != 2);
        }
    }
}
