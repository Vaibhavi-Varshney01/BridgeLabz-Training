using System;
public class Clothing : Product, ITaxable{
    public override double CalculateDiscount(){
        return price * 0.20;   // 20% discount
    }
    public double CalculateTax(){
        return price * 0.05;   // 5% GST
    }
    public string GetTaxDetails(){
        return "GST 5% on Clothing";
    }
}
