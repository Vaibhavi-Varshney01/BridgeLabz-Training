using System;
public class Car : Vehicle, IInsurable{
    public Car(){
        rentalRate = 2000;
    }
    public override double CalculateRentalCost(int days){
        return rentalRate * days;
    }
    public double CalculateInsurance(){
        return 500;
    }
    public string GetInsuranceDetails(){
        return "Car Insurance";
    }
}
