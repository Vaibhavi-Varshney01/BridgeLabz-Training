using System;
class Book{
  public string name;
  public string author;
  public double price;

// parameterized constructor
  public Book(string name, string author, double price){
    this.name = name;
    this.author = author;
    this.price = price;
  }

  // default constructor
  public Book(){
    name = "Not Assigned";
    author = "Unknown";
    price = 0.0;
  }

// display method
  public void Display(){
    Console.WriteLine("Title of the book is: " + name);
    Console.WriteLine("Author of the book is: " + author);
    Console.WriteLine("Price of the book is: " + price);
  }
}
class BookDetails{
  static void Main(){
    Book b1 = new Book("Othello" , "William Shakespear" , 250.00);
    b1.Display();
  }
}