using System;
class Program{
    static void Main(string[] args){
        // Book Object
        LibraryItem item1 = new Book();
        item1.ItemId = 101;
        item1.Title = "C# Programming";
        item1.Author = "Herbert Schildt";
        IReservable res1 = (IReservable)item1;
        item1.GetItemDetails();
        Console.WriteLine("Available: " + res1.CheckAvailability());
        res1.ReserveItem();
        Console.WriteLine("-----------------------------");
        // Magazine Object
        LibraryItem item2 = new Magazine();
        item2.ItemId = 201;
        item2.Title = "Tech Today";
        item2.Author = "Editorial Team";
        IReservable res2 = (IReservable)item2;
        item2.GetItemDetails();
        Console.WriteLine("Available: " + res2.CheckAvailability());
        Console.ReadLine();
    }
}
