using System;
class LibraryMgmt{
    public string title;
    public string author;
    public double price;
    public bool availability;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        availability = true;
    }

    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine($"Book '{title}' borrowed successfully.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' is not available.");
        }
    }
}
