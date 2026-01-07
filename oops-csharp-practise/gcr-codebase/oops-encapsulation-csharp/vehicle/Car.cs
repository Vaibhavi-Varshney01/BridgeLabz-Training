using System;
public class Car : Vehicle, IGPS{
    private string currentLocation;
    public Car(){
        ratePerKm = 15;
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
