using System;
class Vehicle{
    public string ownerName;
    public string vehicleType;
    public static double registrationFee = 2000;
    public Vehicle(string ownerName, string vehicleType){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }
    public void DisplayVehicleDetails(){
        Console.WriteLine($"{ownerName} owns a {vehicleType}. Fee: {registrationFee}");
    }
    public static void UpdateRegistrationFee(double fee){
        registrationFee = fee;
    }
}
