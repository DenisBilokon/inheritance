using System;

public class Animal
{
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string species, int age)
    {
        Species = species;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Вид: {Species}, Возраст: {Age} лет");
    }
}

// Лев - зверь, наследуеться от класа "Зверь".
public class Lion : Animal
{
    public Lion(int age) : base("Лев", age)
    {
    }
}


public class Tiger : Animal
{
    public Tiger(int age) : base("Тигр", age)
    {
    }
}

class Program
{
    static void Main()
    {
        Animal lion = new Lion(8);
        Animal tiger = new Tiger(6);

        lion.DisplayInfo();  
        tiger.DisplayInfo(); 
    }
}
