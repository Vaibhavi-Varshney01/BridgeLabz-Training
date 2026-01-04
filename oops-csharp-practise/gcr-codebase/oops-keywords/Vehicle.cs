using System;
class Vehicle{
    // static variable
    public static double RegistrationFee = 5000;
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;
    // constructor 
    public Vehicle(string ownerName, string vehicleType, string registrationNumber){
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }
    // static method
    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }
    public void Display(){
        Console.WriteLine($"Owner: {OwnerName}, Type: {VehicleType}, Reg No: {RegistrationNumber}, Fee: {RegistrationFee}");
    }
}
class Vehicle{
    static void Main(){
        Vehicle v1 = new Vehicle("Amit", "Car", "MH12AB1234");
        object obj = v1;
        if (obj is Vehicle){
            Vehicle veh = (Vehicle)obj;
            veh.Display();
        }
        Vehicle.UpdateRegistrationFee(6500);
    }
}
