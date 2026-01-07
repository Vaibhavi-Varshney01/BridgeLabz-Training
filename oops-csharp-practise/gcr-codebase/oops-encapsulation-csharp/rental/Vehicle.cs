using System;
public abstract class Vehicle{
    private string vehicleNumber;
    protected double rentalRate;
    public string VehicleNumber{
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }
    public abstract double CalculateRentalCost(int days);
    public void DisplayVehicleDetails(){
        Console.WriteLine("Vehicle Number : " + VehicleNumber);
    }
}
