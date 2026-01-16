using System;
namespace BookShelf
{
    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            lib.AddBook("Technology", new Book("C# Basics", "MS"));
            lib.AddBook("Technology", new Book("DSA", "CLRS"));
            lib.AddBook("Fiction", new Book("Harry Potter", "J K Rowling"));
            lib.Display();
            lib.BorrowBook("Technology", "DSA");
            lib.Display();
        }
    }
}
