using System;
class Program{
    static void Main(string[] args){
        // Electronics Product
        Product p1 = new Electronics();
        p1.ProductId = 101;
        p1.Name = "Laptop";
        p1.Price = 60000;
        ITaxable tax1 = (ITaxable)p1;
        p1.DisplayProductDetails();
        double finalPrice1 = p1.Price + tax1.CalculateTax() - p1.CalculateDiscount();
        Console.WriteLine("Tax        : " + tax1.GetTaxDetails());
        Console.WriteLine("Final Price: " + finalPrice1);
        Console.WriteLine("-----------------------------");

        // Clothing Product
        Product p2 = new Clothing();
        p2.ProductId = 201;
        p2.Name = "Jacket";
        p2.Price = 3000;
        ITaxable tax2 = (ITaxable)p2;
        p2.DisplayProductDetails();
        double finalPrice2 = p2.Price + tax2.CalculateTax() - p2.CalculateDiscount();
        Console.WriteLine("Tax        : " + tax2.GetTaxDetails());
        Console.WriteLine("Final Price: " + finalPrice2);
        Console.ReadLine();
    }
}
