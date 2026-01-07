using System;
public class Electronics : Product, ITaxable{
    public override double CalculateDiscount(){
        return price * 0.10;   // 10% discount
    }
    public double CalculateTax(){
        return price * 0.18;   // 18% GST
    }
    public string GetTaxDetails(){
        return "GST 18% on Electronics";
    }
}
