using System;

namespace ConditionalStatements;

public class Leap
{
    public void LeapMain()
    {
        Console.Write("Enter the year: ");

        bool check = int.TryParse(Console.ReadLine(), out int year);
        if (!check)
        {
            System.Console.WriteLine("Invalid Input! Enter a whole number.");
            return;
        }
        if(year%400==0 || (year%4 == 0 && year%100!=0))
        {
            System.Console.WriteLine(year+" year is a leap year.");
        }
        else
        {
            System.Console.WriteLine(year+" is not a leap year.");
        }
    }
}
