using System;
public class Auto : Vehicle, IGPS{
    private string currentLocation;
    public Auto(){
        ratePerKm = 10;
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
