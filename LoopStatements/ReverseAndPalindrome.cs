using System;

namespace LoopStatements;

public class ReverseAndPalindrome
{
    public void ReverseMain()
    {
        Console.Write("Enter a number: ");
        bool check = int.TryParse(Console.ReadLine(), out int number);

        if(!check || number < 0)
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        int temp = number;
        int reverse = 0;

        while(temp > 0)
        {
            int r = temp % 10;
            reverse = reverse * 10 + r;
            temp /= 10;
        }

        Console.WriteLine($"Reversed Number: {reverse}");
        Console.WriteLine(reverse==number?$"{number} is a Palindrome.":$"{number} is not a Palindrome.");
        
    }
}
