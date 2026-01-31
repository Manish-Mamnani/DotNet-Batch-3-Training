using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOAIRSecurity
{
    public class UserInterface
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of entries: ");
            int n = Int32.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                EntryUtility entryObj = new EntryUtility();

                Console.Write("Enter the Employee ID: ");
                entryObj.EmployeeID = Console.ReadLine();

                Console.Write("Enter the Entry Type: ");
                entryObj.EntryType = Console.ReadLine();

                Console.Write("Enter the Duration: ");
                entryObj.Duration = Int32.Parse(Console.ReadLine());

                try
                {
                    if (entryObj.ValidateEmployeeID(entryObj.EmployeeID) && entryObj.ValidateDuration(entryObj.Duration))
                    {
                        Console.WriteLine("Valid Entry Details!");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Invalid Entry Details!");
                }

            }
        }
    }
}
