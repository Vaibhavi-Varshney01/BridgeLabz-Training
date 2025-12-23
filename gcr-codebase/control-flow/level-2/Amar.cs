using System;
class Amar{
    static void Main(){
        Console.Write("Enter Amar's age & height: ");
        int aAge = int.Parse(Console.ReadLine());
        int aHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's age & height: ");
        int bAge = int.Parse(Console.ReadLine());
        int bHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's age & height: ");
        int cAge = int.Parse(Console.ReadLine());
        int cHeight = int.Parse(Console.ReadLine());
        int youngest = Math.Min(aAge, Math.Min(bAge, cAge));
        int tallest = Math.Max(aHeight, Math.Max(bHeight, cHeight));
        Console.WriteLine("Youngest Age: " + youngest);
        Console.WriteLine("Tallest Height: " + tallest);
    }
}
