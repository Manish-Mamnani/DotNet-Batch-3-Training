using System;

namespace LoopStatements;

public class ArmstrongNumber
{
    public void ArmstrongMain()
    {
        System.Console.Write("Enter a number;");
        bool check = int.TryParse(Console.ReadLine(),out int number);

        if(!check || number < 0)
        {
            System.Console.WriteLine("Invalid Input!");
            return; 
        }

        int temp = number;
        int digits = number.ToString().Length;
        int sum = 0;

        while(temp > 0)
        {
            int r = temp % 10;
            sum += (int)Math.Pow(r,digits);
            temp /= 10;
        }

        Console.WriteLine(sum == number ? $"{number} is an Armstrong Number.":$"{number} is not an Armstrong Number.");
    }
}
