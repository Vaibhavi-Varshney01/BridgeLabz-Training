using System;
class Program{
    static void Main(string[] args){
        // Car Rental
        Vehicle v1 = new Car();
        v1.VehicleNumber = "DL01CAR123";
        IInsurable ins1 = (IInsurable)v1;
        v1.DisplayVehicleDetails();
        Console.WriteLine("Rental Cost  : " + v1.CalculateRentalCost(3));
        Console.WriteLine("Insurance    : " + ins1.CalculateInsurance());
        Console.WriteLine("-----------------------------");

        // Bike Rental
        Vehicle v2 = new Bike();
        v2.VehicleNumber = "DL02BIKE456";

        IInsurable ins2 = (IInsurable)v2;

        v2.DisplayVehicleDetails();
        Console.WriteLine("Rental Cost  : " + v2.CalculateRentalCost(5));
        Console.WriteLine("Insurance    : " + ins2.CalculateInsurance());

        Console.ReadLine();
    }
}
