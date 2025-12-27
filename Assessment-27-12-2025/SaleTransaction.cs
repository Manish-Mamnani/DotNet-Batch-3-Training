using System;

namespace Assessment_27_12_2025;

public class SaleTransaction
{

    #region Properties

    public string InvoiceNo{get;set;}
    public string CustomerName{get;set;}
    public string ItemName{get;set;}
    public int Quantity{get;set;}
    public double PurchaseAmount{get;set;}
    public double SellingAmount{get;set;}
    string ProfitOrLossStatus{get;set;}
    double ProfitOrLossAmount{get;set;}
    double ProfitMarginPercent{get;set;}

    static SaleTransaction LastTransaction{get;set;}=null;
    static bool HasLastTransaction{get;set;}=false;

    #endregion


    #region Methods

    public void RegisterTransaction()
    {
        System.Console.Write("Enter Invoice No: ");
        InvoiceNo = Console.ReadLine();

        if(InvoiceNo == null)
        {
            System.Console.WriteLine("Invoice No cannot be empty.");
            return;
        }

        System.Console.Write("Enter Customer Name: ");
        CustomerName = Console.ReadLine();

        System.Console.Write("Enter Item Name: ");
        ItemName = Console.ReadLine();

        System.Console.Write("Enter Quantity: ");
        Quantity = Int32.Parse(Console.ReadLine());

        if(Quantity <= 0)
        {
            System.Console.WriteLine("Quantity must be greater than zero.");
            return;
        }

        System.Console.Write("Enter Purchase Amount (total): ");
        PurchaseAmount = double.Parse(Console.ReadLine());

        if(PurchaseAmount <= 0)
        {
            System.Console.WriteLine("Purchase Amount must be greater than zero.");
            return;
        }        

        System.Console.Write("Enter Selling Amount (total): ");
        SellingAmount = double.Parse(Console.ReadLine());

        if(SellingAmount < 0)
        {
            System.Console.WriteLine("Selling Amount cannot be negative.");
            return;
        } 

        if(SellingAmount > PurchaseAmount)
        {
            ProfitOrLossStatus = "PROFIT";
            ProfitOrLossAmount = SellingAmount - PurchaseAmount;
        }
        else if(SellingAmount < PurchaseAmount)
        {
            ProfitOrLossStatus = "LOSS";
            ProfitOrLossAmount = PurchaseAmount - SellingAmount;
        }
        else
        {
            ProfitOrLossStatus = "BREAK-EVEN";
            ProfitOrLossAmount = 0;
        }

        ProfitMarginPercent = (ProfitOrLossAmount/PurchaseAmount)*100;

        LastTransaction = this;
        HasLastTransaction = true;

        System.Console.WriteLine("\nTransaction saved successfully.");
        System.Console.WriteLine($"Status: {this.ProfitOrLossStatus}");
        System.Console.WriteLine($"Profit/Loss Amount: {Math.Round(this.ProfitOrLossAmount,2)}");
        System.Console.WriteLine($"Profit Margin (%): {Math.Round(this.ProfitMarginPercent,2)}");

    }

    public void DisplayLastTransaction()
    {
        if (!HasLastTransaction)
        {
            System.Console.WriteLine("\nNo transaction available. Please create a new transaction first.");
            return;
        }

        System.Console.WriteLine("\n----------- Last Transaction -----------");

        System.Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
        System.Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
        System.Console.WriteLine($"Item: {LastTransaction.ItemName}");
        System.Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
        System.Console.WriteLine($"Purchase Amount: {Math.Round(LastTransaction.PurchaseAmount,2)}");
        System.Console.WriteLine($"Selling Amount: {Math.Round(LastTransaction.SellingAmount,2)}");
        System.Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        System.Console.WriteLine($"Profit/Loss Amount: {Math.Round(LastTransaction.ProfitOrLossAmount,2)}");
        System.Console.WriteLine($"Profit Margin (%): {Math.Round(LastTransaction.ProfitMarginPercent,2)}");

        System.Console.WriteLine("-------------------------------------------");
    }

    public void Recompute()
    {
        if (!HasLastTransaction)
        {
            System.Console.WriteLine("\nNo transaction available. Please create a new transaction first.");
            return;
        }

        if(LastTransaction.SellingAmount > LastTransaction.PurchaseAmount)
        {
            LastTransaction.ProfitOrLossStatus = "PROFIT";
            LastTransaction.ProfitOrLossAmount = LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
        }
        else if(LastTransaction.SellingAmount < LastTransaction.PurchaseAmount)
        {
            LastTransaction.ProfitOrLossStatus = "LOSS";
            LastTransaction.ProfitOrLossAmount = LastTransaction.PurchaseAmount - LastTransaction.SellingAmount;
        }
        else
        {
            LastTransaction.ProfitOrLossStatus = "BREAK-EVEN";
            LastTransaction.ProfitOrLossAmount = 0;
        }

        LastTransaction.ProfitMarginPercent = (LastTransaction.ProfitOrLossAmount/LastTransaction.PurchaseAmount)*100;

        System.Console.WriteLine("\nTransaction saved successfully.");
        System.Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        System.Console.WriteLine($"Profit/Loss Amount: {Math.Round(LastTransaction.ProfitOrLossAmount,2)}");
        System.Console.WriteLine($"Profit Margin (%): {Math.Round(LastTransaction.ProfitMarginPercent,2)}");        
        
    }

    #endregion

}
