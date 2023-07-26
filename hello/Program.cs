// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, User!");
// Console.WriteLine("Enter Your Username");

// string userName = Console.ReadLine();
// Console.WriteLine("Here is Your UserName:" + userName);

// type casting
// implicit & explicit type casting

// Console.WriteLine("What is Your Age?");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Here is Your Age" + age);


// // Full name
// string name = "John Doe";

// // Location of the letter D
// int charPos = name.IndexOf("D");

// // Get last name
// string lastName = name.Substring(charPos);

// // Print the result
// Console.WriteLine(lastName);


//constructors

class Car
{
    public string model;

    public Car()
    {
        model = "Mustang";
    }

    public static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
    }
}