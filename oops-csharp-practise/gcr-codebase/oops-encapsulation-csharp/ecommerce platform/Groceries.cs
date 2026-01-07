using System;
public class Groceries : Product{
    public override double CalculateDiscount(){
        return price * 0.05;   // 5% discount
    }
}
