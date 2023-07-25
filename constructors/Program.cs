// See https://aka.ms/new-console-template for more information
class Car
{
    public string color = "red";
    public string model = "blue";



    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
        Console.WriteLine(Ford.color);
    }

}