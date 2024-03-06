using System;

abstract class Animal
{
    public abstract string Name { get; set; }

    public abstract string Describe();
    public string WhatAmI()
    {
        return "I am an animal";
    }
}

class Dog : Animal
{
    public string Breed { get; set; }
    public int Age { get; set; }

    public Dog()
    {
        Breed = string.Empty;
        Age = 0;
    }

    public Dog(string name, string breed, int age)
    {
        Name = name;  
        Breed = breed;
        Age = age;
    }

    public override string Describe()
    {
        return $"I am a {Age}-year-old {Breed} named {Name}.";
    }

    public override string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog("Wrigley", "Boxer", 3);
        Console.WriteLine("Using Default Constructor:");
        Console.WriteLine(dog1.Describe());
        Console.WriteLine(dog1.WhatAmI());
        Console.WriteLine();

        Dog dog2 = new Dog("Nova", "German Shepard Husky", 3);
        Console.WriteLine("Using Parameterized Constructor");
        Console.WriteLine(dog2.Describe());
        Console.WriteLine(dog2.WhatAmI());
    }
}

