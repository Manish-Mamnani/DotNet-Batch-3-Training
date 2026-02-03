using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopBrains_CsharpProgramming
{
    public class Program
    {
        public static bool checkVowel(char check)
        {
            check = char.ToLower(check);

            if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u') return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string firstWord = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string secondWord = Console.ReadLine();

            Dictionary<char, int> second = new Dictionary<char, int>();

            foreach (char c in secondWord)
            {
                char a = char.ToLower(c);
                if (!(checkVowel(a)))
                {
                    if (second.ContainsKey(a))
                    {
                        second[a]++;
                    }
                    else
                    {
                        second.Add(a, 1);
                    }
                }
            }

            for(int i=0;i<firstWord.Length;i++)
            {
                char check = char.ToLower(firstWord[i]);
                if (second.ContainsKey(check))
                {
                    firstWord = firstWord.Remove(i, 1);
                    i--;
                }
            }

            int j = 1;

            while(j<firstWord.Length)
            {
                if (firstWord[j] == firstWord[j - 1])
                {
                    firstWord = firstWord.Remove(j, 1);
                }
                else
                {
                    j++;
                }
            }

            Console.WriteLine(firstWord);
        }
    }
}
