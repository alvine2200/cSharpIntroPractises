using System;

namespace CheckInteger;
class Integer
{
    public static void Main(string[] args)
    {
        Console.Write("Enter The First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter The Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The Result is : " + checkIntegerIfPositiveOrNegative(firstNumber, secondNumber));
    }

    static bool checkIntegerIfPositiveOrNegative(int firstNumber, int secondNumber)
    {
        if ((firstNumber < 0 && secondNumber > 0) || (secondNumber < 0 && firstNumber > 0) || (firstNumber < 0 && secondNumber < 0))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}