using System;

public class Travel {
    public static void Main(String[] args) {

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter from city:");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enter via city:");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enter destination city:");
        string toCity = Console.ReadLine();

        Console.WriteLine("Enter distance from " + fromCity + " to " + viaCity + " (in miles):");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter distance from " + viaCity + " to " + toCity + " (in miles):");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter time taken for journey (in hours):");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are: " 
            + totalDistance + " miles, " 
            + timeTaken + " hours, and " 
            + averageSpeed + " miles per hour");
    }
}
