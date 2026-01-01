using System;
class Book{
    public string ISBN;
    protected string title;
    private string author;
    public void SetAuthor(string author){
        this.author = author;
    }
    public string GetAuthor(){
        return author;
    }
}
class EBook : Book{
    public void DisplayBook(){
        Console.WriteLine($"ISBN: {ISBN}, Title: {title}");
    }
}
