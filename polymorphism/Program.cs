using System;
// using System.Data;
// using Internal;
// using System;
// class Animal   //parent class
// {
// 	public void animalSound()
// 	{
// 		Console.WriteLine("The Animal have different sound");
// 	}
// }

// class Pig : Animal
// {
// 	public void animalSound()

// 	{
// 		Console.WriteLine("The Pig says weee");
// 	}
// }

// class Bird : Animal
// {
// 	public void animalSound()
// 	{
// 		Console.WriteLine("The bird sings");
// 	}
// }

// //when not using override method & virtual we get same class
// class Program
// {
// 	public static void Main(string[] args)
// 	{
// 		Animal animal = new Animal();
// 		Animal Pig = new Pig();
// 		Animal Bird = new Bird();

// 		animal.animalSound();
// 		Pig.animalSound();
// 		Bird.animalSound();
// 	}
// }


//polymorphism using virtual and override methods
class Car
{
    public virtual void sound()
    {
        Console.WriteLine("Car Has a sound");
    }
}

class Truck : Car
{
    public override void sound()
    {
        Console.WriteLine("The Truck has a strong sound");
    }
}

class Lambo : Car
{
    public override void sound()
    {
        Console.WriteLine("A lambo sound is great");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Car myCar = new Car();
        Car myTruck = new Truck();
        Car myLambo = new Lambo();


        myCar.sound();
        myTruck.sound();
        myLambo.sound();
    }
}