using System;
class Product{
    public static int Discount = 10;
    public readonly int productId;
    public string productName;
    public double price;
    public int quantity;
    // constructor 
    public Product(int productId, string productName, double price, int quantity){
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }
    // static method
    public static void UpdateDiscount(int newDiscount){
        Discount = newDiscount;
    }
    public void Display(){
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + productName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}
class Cart{
    static void Main(){
        Product p1 = new Product(101, "Laptop", 50000, 2);
        // static method call
        Product.UpdateDiscount(15);
        object obj = p1;
        // is operator
        if (obj is Product){
            Product pro = (Product)obj;
            pro.Display();
        }
    }
}
