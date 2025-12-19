using System;

namespace LoopStatements;

public class GCDandLCM
{
    public void GCDMain()
    {
        Console.Write("Enter first number: ");
        bool check1 = int.TryParse(Console.ReadLine(), out int num1);
        Console.Write("Enter second number: ");
        bool check2 = int.TryParse(Console.ReadLine(), out int num2);

        if(!check1 || !check2 || num1 <= 0 || num2 <= 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int x = num1;
        int y = num2;

        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        int gcd = x;
        int lcm = (num1*num2)/gcd;

        Console.WriteLine("GCD: "+gcd+"\nLCM: "+lcm);
    }
}
