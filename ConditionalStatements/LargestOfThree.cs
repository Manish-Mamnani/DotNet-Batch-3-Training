using System;

namespace ConditionalStatements;

public class Largest
{
    public void LargestMain()
    {
        Console.Write("Enter the first whole number: ");
        bool check1 = int.TryParse(Console.ReadLine(), out int firstNumber);
        Console.Write("Enter the second whole number: ");
        bool check2 = int.TryParse(Console.ReadLine(), out int secondNumber);
        Console.Write("Enter the third whole number: ");
        bool check3 = int.TryParse(Console.ReadLine(), out int thirdNumber);

        if (!check1 && !check2 && !check3)
        {
            System.Console.WriteLine("Invalid Input! Enter a whole number.");
            return;
        }

        if (firstNumber <= secondNumber)
        {
            if (secondNumber <= thirdNumber)
            {
                System.Console.WriteLine(thirdNumber+" is the greatest number.");
            }
            else
            {
                System.Console.WriteLine(secondNumber+" is the greatest number.");
            }
        }
        else
        {
            if (firstNumber <= thirdNumber)
            {
                System.Console.WriteLine(thirdNumber+" is the greatest number.");
            }
            else
            {
                System.Console.WriteLine(firstNumber+" is the greatest number.");
            }
        }
    }
}
