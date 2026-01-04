using System;
class Animal1{
    public string Name;
    public int Age;
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal1{
    public override void MakeSound(){
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal1{
    public override void MakeSound(){
        Console.WriteLine("Cat meows");
    }
}
class Bird : Animal1{
    public override void MakeSound(){
        Console.WriteLine("Bird chirps");
    }
}
class Animal{
    static void Main(){
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        Animal a3 = new Bird();
        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
