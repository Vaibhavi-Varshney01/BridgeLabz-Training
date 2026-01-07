using System;
class Program{
    static void Main(string[] args){
        // Veg Food Item
        FoodItem food1 = new VegItem(200, 2);
        food1.ItemName = "Paneer Butter Masala";
        IDiscountable dis1 = (IDiscountable)food1;
        food1.GetItemDetails();
        Console.WriteLine("Discount : " + dis1.GetDiscountDetails());
        Console.WriteLine("-----------------------------");
        // Non-Veg Food Item
        FoodItem food2 = new NonVegItem(300, 1);
        food2.ItemName = "Chicken Biryani";
        IDiscountable dis2 = (IDiscountable)food2;
        food2.GetItemDetails();
        Console.WriteLine("Discount : " + dis2.GetDiscountDetails());
        Console.ReadLine();
    }
}
