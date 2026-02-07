using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamsPractice2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st word: ");
            string first = Console.ReadLine();

            Console.Write("Enter 2nd word: ");
            string second = Console.ReadLine();

            int count = 0;

            Dictionary<char,int> dict = new Dictionary<char, int>();
            for(int i = 0; i < second.Length; i++)
            {
                if (dict.ContainsKey(second[i]))
                {
                    dict[second[i]]++;
                }
                else
                {
                    dict.Add(second[i], 1);
                }
            }

            for(int i = 0;i < first.Length;i++)
            {
                if (!dict.ContainsKey(first[i]))
                {
                    first = first.Remove(i, 1);
                    count++;
                    i--;
                }
                else
                {
                    if (dict[first[i]] > 0)
                    {
                        dict[first[i]]--;
                    }
                    else
                    {
                        first = first.Remove(i, 1);
                        count++;
                        i--;
                    }
                }
            }

            Console.WriteLine($"Count : {count}");
        }
    }
}
