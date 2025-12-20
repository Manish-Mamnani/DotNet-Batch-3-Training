using System;
using System.Linq.Expressions;

namespace StudentManagementSystemApp;

public class StudentBL
{
    Student sObj = null;
    public StudentBL()
    {
        sObj = new Student();
    }
    public void AcceptStudentDetails()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.WriteLine("    Student Management System     ");
        System.Console.WriteLine("----------------------------------");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        try{
            System.Console.Write("Enter Roll No : ");
            sObj.RollNo = Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter Name : ");
            sObj.Name = Console.ReadLine();

            System.Console.Write("Enter Address : ");
            sObj.Address = Console.ReadLine();

            System.Console.Write("Enter Physics Marks : ");
            sObj.Phy = Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter Chemistry Marks : ");
            sObj.Chem = Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter Mathematics Marks : ");
            sObj.Math = Int32.Parse(Console.ReadLine());
        }
        catch(InvalidMarksException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            System.Console.WriteLine("Some Error Occurred : " + e.Message);
        }
        Console.ForegroundColor = ConsoleColor.White;

        
    }

    public int calcTotal()
    {
        sObj.Total = sObj.Phy + sObj.Chem + sObj.Math;
        return sObj.Total;
    }

    public float calcPerc()
    {
        sObj.Perc = (calcTotal() / 300.0f) * 100;
        return sObj.Perc;
    }

    public void calcResult(out int myTotal, out float myPerc)
    {
        myTotal = calcTotal();
        myPerc = calcPerc();
    }
    
}
