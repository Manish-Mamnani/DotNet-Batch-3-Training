using System;

namespace LoopStatements;

public class FibonacciSeries
{
    public void FibonacciMain()
    {
        Console.Write("Enter N: ");
        bool check = int.TryParse(Console.ReadLine(), out int n);

        if(!check || n <= 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int a = 0, b = 1;
        Console.WriteLine("Fibonacci Series:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int sum = a + b;
            a = b;
            b = sum;
        }
        Console.WriteLine();
        
    }
}
