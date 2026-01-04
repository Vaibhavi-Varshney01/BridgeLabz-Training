using System;
static string LibraryName;
class Book{
  public string title;
  public string author;
  public readonly ISBN;
  
  public Book(string title, string author, long ISBN){
    this.title = title;
    this.author = author;
    this.ISBN =  ISBN;
  }

  public void Display(){
    Console.WriteLine("")
  }



}