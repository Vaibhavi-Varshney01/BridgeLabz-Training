using System;
public class Bike : Vehicle, IInsurable{
    public Bike(){
        rentalRate = 500;
    }
    public override double CalculateRentalCost(int days){
        return rentalRate * days;
    }
    public double CalculateInsurance(){
        return 200;
    }
    public string GetInsuranceDetails(){
        return "Bike Insurance";
    }
}
