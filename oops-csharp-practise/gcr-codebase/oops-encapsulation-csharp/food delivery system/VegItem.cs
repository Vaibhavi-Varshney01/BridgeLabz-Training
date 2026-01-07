using System;
public class VegItem : FoodItem, IDiscountable{
    public VegItem(double price, int qty){
        this.price = price;
        quantity = qty;
    }
    public override double CalculateTotalPrice(){
        return (price * quantity) - ApplyDiscount();
    }
    public double ApplyDiscount(){
        return price * quantity * 0.10;   // 10% discount
    }
    public string GetDiscountDetails()
    {
        return "10% Veg Discount";
    }
}
