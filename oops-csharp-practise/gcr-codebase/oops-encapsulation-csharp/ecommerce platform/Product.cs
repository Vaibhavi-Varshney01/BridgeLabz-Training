using System;
public abstract class Product{
    private int productId;
    private string name;
    protected double price;
    public int ProductId{
        get { return productId; }
        set { productId = value; }
    }
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public double Price{
        get { return price; }
        set { price = value; }
    }
    public abstract double CalculateDiscount();
    public void DisplayProductDetails(){
        Console.WriteLine("Product ID : " + ProductId);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Base Price : " + Price);
    }
}
