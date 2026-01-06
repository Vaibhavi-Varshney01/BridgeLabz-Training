using System;
class Bus{
    static void Main(){
        int totalDistance = 0;
        char choice = 'n';
        while (choice != 'y'){
            Console.Write("Enter distance for this stop (in km): ");
            int distance = Convert.ToInt32(Console.ReadLine());
            totalDistance += distance;
            Console.WriteLine("Total distance till now: " + totalDistance + " km");
            Console.Write("Do you want to get off? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine().ToLower());
        }
        Console.WriteLine("Passenger got off.");
        Console.WriteLine("Final distance travelled: " + totalDistance + " km");
    }
}
