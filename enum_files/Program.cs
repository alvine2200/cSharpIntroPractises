using System;
//enum
enum Level
{
    Low, Medium, High
}


class Program
{

    static void Main(string[] args)
    {
        //how to access enums
        Level myLow = Level.Low;
        Level myMedium = Level.Medium;
        Level myHigh = Level.High;
        Console.WriteLine("My Enum Levels include " + myLow + " " + myMedium + " " + myHigh + "");
    }

}
