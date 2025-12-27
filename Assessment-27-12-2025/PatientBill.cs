using System;

namespace Assessment_27_12_2025;

public class PatientBill
{

    #region Properties

    public string BillId{get; set;}
    public string PatientName{get; set;}
    public bool HasInsurance{get;set;}
    public double ConsultationFee{get;set;}
    public double LabCharges{get;set;}
    public double MedicationCharges{get;set;}
    double GrossAmount{get;set;}
    double DiscountAmount{get;set;}
    double FinalPayable{get;set;}
    static PatientBill LastBill{get;set;} = null;
    static bool HasLastBill{get;set;} = false;

    #endregion

    #region Methods

    public void RegisterPatient()
    {
        System.Console.Write("Enter Bill Id: ");
        BillId = Console.ReadLine();

        if(BillId == null)
        {
            System.Console.WriteLine("Bill Id cannot be empty.");
            return;
        }

        System.Console.Write("Enter Patient Name: ");
        PatientName = Console.ReadLine();

        System.Console.Write("Is the patient insured? (Y/N): ");
        char insuranceChoice = Char.ToUpper(Console.ReadLine()[0]);

        HasInsurance = insuranceChoice == 'Y' ? true : false;

        System.Console.Write("Enter Consultation Fee: ");
        ConsultationFee = double.Parse(Console.ReadLine());

        if(ConsultationFee <= 0)
        {
            System.Console.WriteLine("Consultation Fee must be greater than zero.");
            return;
        }

        System.Console.Write("Enter Lab Charges: ");
        LabCharges = double.Parse(Console.ReadLine());

        if(LabCharges < 0)
        {
            System.Console.WriteLine("Lab Charges cannot be negative.");
            return;
        }        

        System.Console.Write("Enter Medicine Charges: ");
        MedicationCharges = double.Parse(Console.ReadLine());

        if(MedicationCharges < 0)
        {
            System.Console.WriteLine("Medication Charges cannot be negative.");
            return;
        } 

        GrossAmount = ConsultationFee + LabCharges + MedicationCharges;

        if (HasInsurance)
        {
            DiscountAmount = GrossAmount * 0.10;
        }
        else
        {
            DiscountAmount = 0;
        }

        FinalPayable = GrossAmount - DiscountAmount;

        LastBill = this;
        HasLastBill = true;

        System.Console.WriteLine("\nBill created successfully.");
        System.Console.WriteLine($"Gross Amount: {Math.Round(this.GrossAmount,2)}");
        System.Console.WriteLine($"Discount Amount: {Math.Round(this.DiscountAmount,2)}");
        System.Console.WriteLine($"Final Payable: {Math.Round(this.FinalPayable,2)}");

    }

    public void DisplayLastBill()
    {
        if (!HasLastBill)
        {
            System.Console.WriteLine("\nNo bill available. Please create a new bill first.");
            return;
        }

        System.Console.WriteLine("\n----------- Last Bill -----------");

        System.Console.WriteLine($"BillID: {LastBill.BillId}");
        System.Console.WriteLine($"Patient: {LastBill.PatientName}");
        System.Console.WriteLine($"Insured: {LastBill.HasInsurance}");
        System.Console.WriteLine($"Consultation Fee: {Math.Round(LastBill.ConsultationFee,2)}");
        System.Console.WriteLine($"Lab Charges: {Math.Round(LastBill.LabCharges,2)}");
        System.Console.WriteLine($"Medicine Charges: {Math.Round(LastBill.MedicationCharges,2)}");
        System.Console.WriteLine($"Gross Amount: {Math.Round(LastBill.GrossAmount,2)}");
        System.Console.WriteLine($"Discount Amount: {Math.Round(LastBill.DiscountAmount,2)}");
        System.Console.WriteLine($"Final Payable: {Math.Round(LastBill.FinalPayable,2)}");

        System.Console.WriteLine("------------------------------------");
    }

    public void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;

        System.Console.WriteLine("\nLast bill cleared.");
    }

    #endregion

}
