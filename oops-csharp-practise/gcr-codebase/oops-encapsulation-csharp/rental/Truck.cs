using System;
public class Truck : Vehicle, IInsurable{
    public Truck(){
        rentalRate = 4000;
    }
    public override double CalculateRentalCost(int days){
        return rentalRate * days;
    }
    public double CalculateInsurance(){
        return 1000;
    }
    public string GetInsuranceDetails(){
        return "Truck Insurance";
    }
}
