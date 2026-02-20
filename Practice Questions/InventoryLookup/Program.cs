using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLookup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>
        {
            { "P101", 25 },
            { "P102", 0 },
            { "P103", 14 }
        };

            Console.WriteLine("Enter code: ");
            string inputCode = Console.ReadLine();
            // TODO: Implement lookup and print result
            if (inventory.ContainsKey(inputCode))
            {
                Console.WriteLine($"Code: {inputCode}\nStock: {inventory[inputCode]}");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}
