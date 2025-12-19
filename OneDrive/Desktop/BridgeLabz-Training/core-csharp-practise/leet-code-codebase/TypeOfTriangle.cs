using System;

public class TypeOfTriangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first side:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second side:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third side:");
        int c = int.Parse(Console.ReadLine());

        // Triangle validity check
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
        else
        {
            Console.WriteLine("Triangle is not valid");
        }
    }
}
