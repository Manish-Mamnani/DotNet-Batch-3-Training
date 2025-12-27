// See https://aka.ms/new-console-template for more information
using System;

using Assessment_27_12_2025;

class Program
{
    public static void MediSureMenu()
    {
        PatientBill patient = new PatientBill();

        while (true)
        {            
            System.Console.WriteLine("==================== MediSure Clinic Billing ====================");
            System.Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            System.Console.WriteLine("2. View Last Bill");
            System.Console.WriteLine("3. Clear Last Bill");
            System.Console.WriteLine("4. Exit");

            System.Console.Write("Enter your option: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        patient.RegisterPatient();
                        break;
                    }
                case 2:
                    {
                        patient.DisplayLastBill();
                        break;
                    }
                case 3:
                    {
                        patient.ClearLastBill();
                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine("\nThank you. Application closed normally.");
                        return;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid choice!");
                        break;
                    }
            }
            
            System.Console.WriteLine("=================================================================");
        }
    }

    public static void QuickMartMenu()
    {
        SaleTransaction transaction = new SaleTransaction();

        while (true)
        {            
            System.Console.WriteLine("==================== QuickMart Traders ====================");
            System.Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            System.Console.WriteLine("2. View Last Transaction");
            System.Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            System.Console.WriteLine("4. Exit");

            System.Console.Write("Enter your option: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        transaction.RegisterTransaction();
                        break;
                    }
                case 2:
                    {
                        transaction.DisplayLastTransaction();
                        break;
                    }
                case 3:
                    {
                        transaction.Recompute();
                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine("\nThank you. Application closed normally.");
                        return;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid choice!");
                        break;
                    }
            }
            
            System.Console.WriteLine("=================================================================");
        }
    }
    static void Main(string[] args)
    {

        // MediSureMenu();
        QuickMartMenu();        
    }
}
