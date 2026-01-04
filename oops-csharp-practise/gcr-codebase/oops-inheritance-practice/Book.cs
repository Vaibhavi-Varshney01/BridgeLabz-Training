using System;
class Book{
    public string Title;
    public int PublicationYear;
}
class Author : Book{
    public string Name;
    public string Bio;
    public void DisplayInfo(){
        Console.WriteLine($"{Title}, {PublicationYear}, {Name}, {Bio}");
    }
}
