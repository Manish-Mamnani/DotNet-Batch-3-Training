using System;

namespace LoopStatements;

public class PrimeNumberCheck
{
    public void PrimeMain()
    {
        Console.Write("Enter a number:");
        bool check = int.TryParse(Console.ReadLine(), out int number);

        if(!check || number <= 1)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        bool isPrime = true;

        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            System.Console.WriteLine("{0} is a prime number.",number);
        }
        else
        {
            System.Console.WriteLine("{0} is not a prime number.",number);
        }
    }
}
