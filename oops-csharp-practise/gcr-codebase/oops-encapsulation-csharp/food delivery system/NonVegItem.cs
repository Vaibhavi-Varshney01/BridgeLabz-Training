using System;
public class NonVegItem : FoodItem, IDiscountable{
    public NonVegItem(double price, int qty){
        this.price = price;
        quantity = qty;
    }
    public override double CalculateTotalPrice(){
        return (price * quantity) + 50 - ApplyDiscount(); // extra charge
    }
    public double ApplyDiscount(){
        return price * quantity * 0.05;   // 5% discount
    }
    public string GetDiscountDetails(){
        return "5% Non-Veg Discount";
    }
}
