using System;

class Degree
{
    public static void Main(string[] args)
    {
        double fahrenheight, degree, kelvin;

        Console.WriteLine("Enter The Degree amount To Be Converted: \n");
        degree = Convert.ToDouble(Console.ReadLine());

        //convert to farenheight
        fahrenheight = degree / 33.8;
        kelvin = degree / 274.15;

        Console.WriteLine("To Fahrenheight : " + fahrenheight + "\n");
        Console.WriteLine("To Kelvin : " + kelvin + "\n");

    }
}