using System;
class Program{
    static void Main(string[] args){
        // Car Ride
        Vehicle v1 = new Car();
        v1.VehicleId = 101;
        v1.DriverName = "Amit";
        IGPS gps1 = (IGPS)v1;
        gps1.UpdateLocation("Connaught Place");
        v1.GetVehicleDetails();
        Console.WriteLine("Location : " + gps1.GetCurrentLocation());
        Console.WriteLine("Fare     : " + v1.CalculateFare(10));
        Console.WriteLine("-----------------------------");

        // Bike Ride
        Vehicle v2 = new Bike();
        v2.VehicleId = 102;
        v2.DriverName = "Rohit";
        IGPS gps2 = (IGPS)v2;
        gps2.UpdateLocation("Karol Bagh");
        v2.GetVehicleDetails();
        Console.WriteLine("Location : " + gps2.GetCurrentLocation());
        Console.WriteLine("Fare     : " + v2.CalculateFare(10));

        Console.ReadLine();
    }
}
