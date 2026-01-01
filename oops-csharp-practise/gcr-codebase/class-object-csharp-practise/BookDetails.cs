using System;
class Book{
  public string title;
  public string author;
  public double price;

  public void Display(){
    Console.WriteLine("Name of the book: " + title);
    Console.WriteLine("Book is written by: " + author);
    Console.WriteLine("Price for the book is: " + price);
  }
}
class BookDetails{
  static void Main(){
    Book b1 = new Book();
    b1.name = "Gitanjli";
    b1.author = "Dr. Rabindranath Tagore";
    b1.price = 200.00;
    b1.Display();
  }
}