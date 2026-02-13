using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class UserInterfaceClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employment Type: ");
            string employmentType = Console.ReadLine();

            Console.WriteLine("Enter monthly income: ");
            double income = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter existing credit dues: ");
            double dues = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Credit score: ");
            int score = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of loan defaults: ");
            int defaults = Int32.Parse(Console.ReadLine());

            try
            {
                CreditRiskProcessor credObj = new CreditRiskProcessor();
                if(credObj.validateCustomerDetails(age, employmentType, income,dues,score, defaults))
                {
                    int creditLimit = credObj.calculateCreditLimit(income,dues,score,defaults);
                    Console.WriteLine($"Customer Name: {name}\nApproved Credit Limit: {creditLimit}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
