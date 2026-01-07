using System;
public class Bike : Vehicle, IGPS{
    private string currentLocation;
    public Bike(){
        ratePerKm = 8;
    }
    public override double CalculateFare(double distance){
        return distance * ratePerKm;
    }
    public void UpdateLocation(string location){
        currentLocation = location;
    }
    public string GetCurrentLocation(){
        return currentLocation;
    }
}
