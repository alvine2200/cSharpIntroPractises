using System;
class AverageValue
{
    public static void Main(string[] args)
    {
        double value1, value2, value3, average;

        Console.WriteLine("Enter First Number : ");
        value1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Second Number : ");
        value2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Third Number : ");
        value3 = Convert.ToDouble(Console.ReadLine());

        average = (value1 + value2 + value3) / 3;
        Console.WriteLine(" \n The Average Value for Numbers {0}, {1}, {2} : " + average + "\n", value1, value2, value3, average);

    }
}