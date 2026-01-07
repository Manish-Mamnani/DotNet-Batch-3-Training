using System;

namespace DigitalPettyCashLedger
{
    public class Program
    {
        static void Main(string[] args)
        {

            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();


            while (true)
            {
                System.Console.WriteLine("      Digital Petty Cash Ledger       ");
                System.Console.WriteLine("======================================\n");

                System.Console.WriteLine("1.Add New Entry");
                System.Console.WriteLine("2.View Transactions By Date");
                System.Console.WriteLine("3.View Total Amount");
                System.Console.WriteLine("4.View Summary Report");
                System.Console.WriteLine("5.Exit");

                System.Console.Write("Enter your choice: ");
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            System.Console.WriteLine("1.Income Transaction");
                            System.Console.WriteLine("2.Expense transaction");

                            System.Console.Write("Enter your choice: ");
                            int tChoice = Int32.Parse(Console.ReadLine());

                            switch (tChoice)
                            {
                                case 1:
                                    {
                                        IncomeTransaction incomeTransaction = new IncomeTransaction();
                                        
                                        System.Console.Write("Enter ID: ");
                                        incomeTransaction.Id = Int32.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Date (yyyy-mm-dd): ");
                                        incomeTransaction.Date = DateTime.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Amount: ");
                                        incomeTransaction.Amount = Double.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Description: ");
                                        incomeTransaction.Description = Console.ReadLine();

                                        System.Console.Write("Enter Source: ");
                                        incomeTransaction.Source = Console.ReadLine();

                                        incomeLedger.AddEntry(incomeTransaction);

                                        System.Console.WriteLine("\nIncome Transaction added successfully!\n");

                                        break;
                                    }
                                case 2:
                                    {
                                        ExpenseTransaction expenseTransaction = new ExpenseTransaction();
                                        
                                        System.Console.Write("Enter ID: ");
                                        expenseTransaction.Id = Int32.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Date (yyyy-mm-dd): ");
                                        expenseTransaction.Date = DateTime.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Amount: ");
                                        expenseTransaction.Amount = Double.Parse(Console.ReadLine());

                                        System.Console.Write("Enter Description: ");
                                        expenseTransaction.Description = Console.ReadLine();

                                        System.Console.Write("Enter Category: ");
                                        expenseTransaction.Category = Console.ReadLine();

                                        expenseLedger.AddEntry(expenseTransaction);

                                        System.Console.WriteLine("\nExpense Transaction added successfully!\n");
                                        break;
                                    }

                                default:
                                    {
                                        System.Console.WriteLine("Invalid Choice!");
                                        break;
                                    }
                            }

                            break;

                        }

                    case 2:
                        {
                            System.Console.Write("Enter Date (yyyy-mm-dd): ");
                            DateTime date = DateTime.Parse(Console.ReadLine());

                            if(incomeLedger != null)
                            {
                                List<IncomeTransaction> incomeList = incomeLedger.GetTransactionByDate(date);
                                System.Console.WriteLine("\nIncome Transactions:");
                                
                                int i = 1;
                                foreach(var it in incomeList)
                                {
                                    System.Console.WriteLine($"{i}. {it.Id}");
                                    i++;
                                }                        
                            }

                            if(expenseLedger != null)
                            {
                                List<ExpenseTransaction> expenseList = expenseLedger.GetTransactionByDate(date);
                                System.Console.WriteLine("\nExpense Transactions:");
                                
                                int i = 1;
                                foreach(var it in expenseList)
                                {
                                    System.Console.WriteLine($"{i}. {it.Id}");
                                    i++;
                                }                        
                            }    

                            break;
                        }

                    case 3:
                        {
                            double incomeTotal = 0;
                            double expenseTotal = 0;

                            if(incomeLedger != null)
                            {
                                incomeTotal = incomeLedger.CalculateTotal();
                                System.Console.WriteLine($"\nTotal Income Amount: {incomeTotal}");
                            }

                            if(expenseLedger != null)
                            {
                                expenseTotal = expenseLedger.CalculateTotal();
                                System.Console.WriteLine($"\nTotal Expense Amount: {expenseTotal}");
                            }

                            double netBalance = incomeTotal - expenseTotal;

                            System.Console.WriteLine($"\nNet Balance: {netBalance}\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nSUMMARY REPORT\n");

                            foreach (var income in incomeLedger.GetAll())
                            {
                                Console.WriteLine(income.GetSummary());
                            }

                            foreach (var expense in expenseLedger.GetAll())
                            {
                                Console.WriteLine(expense.GetSummary());
                            }

                            break;
                             
                        }

                    case 5:
                        {
                            System.Console.WriteLine("Thank you for using the application. Goodbye!");
                            return;
                        }
                    
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice!");
                            break;
                        }
                }

            }

        }
    }
}