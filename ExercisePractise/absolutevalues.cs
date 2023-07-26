using System;

namespace Abso;
class AbsoluteValues
{
    public static void Main(string[] args)
    {
        Console.Write("Enter The First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter The Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The Result is : " + calculateAbsolute(firstNumber, secondNumber));
    }

    static double calculateAbsolute(int firstNumber, int secondNumber)
    {
        int difference = Math.Abs(secondNumber - firstNumber);
        //find it absolute

        if (firstNumber > secondNumber)
        {
            return difference * 2;
        }

        return difference;
    }
}
