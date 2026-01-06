using System;
interface IFlyable{
    void Fly();
}
interface ISwimmable{
    void Swim();
}
// Base Class
class Bird{
    public string Name { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Bird Name: " + Name);
    }
}
// Eagle
class Eagle : Bird, IFlyable{
    public void Fly()
    {
        Console.WriteLine("Eagle is flying high 🦅");
    }
}
// Sparrow
class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying 🐦");
    }
}

// Duck
class Duck : Bird, ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Duck is swimming 🦆");
    }
}

// Penguin
class Penguin : Bird, ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming 🐧");
    }
}

// Seagull
class Seagull : Bird, IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Seagull is flying 🌊");
    }

    public void Swim()
    {
        Console.WriteLine("Seagull is swimming 🌊");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle { Name = "Golden Eagle" };
        birds[1] = new Sparrow { Name = "House Sparrow" };
        birds[2] = new Duck { Name = "Lake Duck" };
        birds[3] = new Penguin { Name = "Emperor Penguin" };
        birds[4] = new Seagull { Name = "Ocean Seagull" };

        foreach (Bird bird in birds)
        {
            bird.DisplayInfo();

            if (bird is IFlyable fly)
                fly.Fly();

            if (bird is ISwimmable swim)
                swim.Swim();

            Console.WriteLine("----------------------");
        }
    }
}
