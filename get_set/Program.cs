using System.Dynamic;
using System;
// using System;
// class Car
// {
// 	private string color;
// 	public string Color
// 	{
// 		get { return color; }
// 		set { color = value; }
// 	}
// }

// class Program
// {
// 	static void Main(string[] args)
// 	{
// 		Car Ford = new Car();
// 		Ford.Color = "blue";
// 		Console.WriteLine(Ford.Color);
// 	}
// }

// automatic properties

class Car
{
    public string Color //property
    {

        { get; SetIndexBinder set; }

    }

}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.Color = "red";
        Console.WriteLine(myObj.Color);
    }
}


