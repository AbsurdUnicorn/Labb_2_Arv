namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new(5, "Whiskers");
        Cow cow = new(8, "Bessie");
        Horse horse = new(10, "Spirit");

        BritishShorthair britishShorthair =
            new(4, "Mittens");

        Siamese siamese = new(3, "Luna");

        cat.MakeSound();
        cat.ExpectedAge();
        cat.DisplayInfo();
        cat.CheckCoolLevel();
        cow.MakeSound();
        horse.MakeSound();
        britishShorthair.MakeSound();
        siamese.MakeSound();
    }
}

abstract class Animal
{
    public string Name { get; set; } = "Unknown";
    public int Age { get; set; } = 0;
    public int Legs { get; set; } = 4;
    public bool Tail { get; set; } = true;
    public string Diet { get; set; } = "Unknown";
    
    public abstract void MakeSound();

    public abstract void ExpectedAge();
    
    public void CheckCoolLevel()
    {
        Random random = new();
        int coolness = random.Next(1, 101);

        Console.WriteLine($"Right now {Name} is {coolness}% cool!");
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine(
            $"Name: {Name}, Age: {Age}, Legs: {Legs}, Tail: {Tail}, Diet: {Diet}");
    }
}

class Cat : Animal
{
    public bool IndoorCat { get; set; } = true;

    public Cat(int age, string name = "Cat")
    {
        Name = name;
        Age = age;
        Diet = "Carnivore";
    }
    
    public void ScratchFurniture()
    {
        Console.WriteLine($"{Name} is scratching the furniture!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void ExpectedAge()
    {
        if (Age > 15)
        {
            Console.WriteLine(
                $"{Name} has lived {Age - 15} years beyond the average lifespan of 15 years.");
        }
        else
        {
            Console.WriteLine(
                $"{Name} has about {15 - Age} years until the average lifespan of 15 years.");
        }
    }
}

class Cow : Animal
{
    public double MilkProduction { get; set; } = 0;

    public Cow(int age, string name = "Cow")
    {
        Name = name;
        Age = age;
        Diet = "Herbivore";
    }
    
    
    public void ProduceMilk()
    {
        Console.WriteLine(
            $"{Name} produces {MilkProduction} litres of milk per day.");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Moo");
    }

    public override void ExpectedAge()
    {
        if (Age > 20)
        {
            Console.WriteLine(
                $"{Name} has lived {Age - 20} years beyond the average lifespan of 20 years.");
        }
        else
        {
            Console.WriteLine(
                $"{Name} has about {20 - Age} years until the average lifespan of 20 years.");
        }
    }
}

class Horse : Animal
{
    public bool CanBeRidden { get; set; } = true;

    public Horse(int age, string name = "Horse")
    {
        Name = name;
        Age = age;
        Diet = "Herbivore";
    }
    
    public void Gallop()
    {
        Console.WriteLine($"{Name} is galloping!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Neigh");
    }

    public override void ExpectedAge()
    {
        if (Age > 25)
        {
            Console.WriteLine(
                $"{Name} has lived {Age - 25} years beyond the average lifespan of 25 years.");
        }
        else
        {
            Console.WriteLine(
                $"{Name} has about {25 - Age} years until the average lifespan of 25 years.");
        }
    }
}


class BritishShorthair : Cat
{
    public bool HasRoundFace { get; set; } = true;

    public BritishShorthair(int age, string name = "British Shorthair") : base(age, name)
    {
        
    }
    
    public void Purr()
    {
        Console.WriteLine($"{Name} is purring.");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Siamese : Cat
{
    public bool IsVocal { get; set; } = true;

    public Siamese(int age, string name = "Siamese") : base(age, name)
    {
        
    }
    
    public void Talk()
    {
        Console.WriteLine($"{Name} is chattering!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Mee-yow!");
    }
}