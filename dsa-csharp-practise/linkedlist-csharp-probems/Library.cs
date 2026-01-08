using System;
class BookNode{
    public int BookID;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(int id, string title, string author, string genre, bool available)
    {
        BookID = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = available;
        Prev = null;
        Next = null;
    }
}

class Library{
    BookNode head;
    BookNode tail;
    // Add at End
    public void AddAtEnd(int id, string title, string author, string genre, bool available)
    {
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }
    // Add at Beginning
    public void AddAtBeginning(int id, string title, string author, string genre, bool available){
        BookNode newNode = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    // Remove by Book ID
    public void RemoveBook(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookID == id)
            {
                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;
                else
                    head = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;
                else
                    tail = temp.Prev;

                Console.WriteLine("Book Removed Successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book Not Found");
    }

    // Search by Title or Author
    public void Search(string key)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No matching book found");
    }

    // Update Availability
    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookID == id)
            {
                temp.IsAvailable = status;
                Console.WriteLine("Availability Updated");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book Not Found");
    }

    // Display Forward
    public void DisplayForward()
    {
        BookNode temp = head;

        if (temp == null)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display Reverse
    public void DisplayReverse()
    {
        BookNode temp = tail;

        if (temp == null)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count Books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("Total Books = " + count);
    }

    // Helper Method
    void DisplayBook(BookNode book)
    {
        Console.WriteLine($"ID: {book.BookID}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();

        lib.AddAtEnd(1, "Clean Code", "Robert Martin", "Programming", true);
        lib.AddAtBeginning(2, "Atomic Habits", "James Clear", "Self Help", true);
        lib.AddAtEnd(3, "1984", "George Orwell", "Fiction", false);

        Console.WriteLine("\n--- Forward Display ---");
        lib.DisplayForward();

        Console.WriteLine("\n--- Reverse Display ---");
        lib.DisplayReverse();

        Console.WriteLine("\n--- Search Book ---");
        lib.Search("George Orwell");

        Console.WriteLine("\n--- Update Availability ---");
        lib.UpdateAvailability(3, true);

        Console.WriteLine("\n--- Remove Book ---");
        lib.RemoveBook(2);

        Console.WriteLine("\n--- Final List ---");
        lib.DisplayForward();

        lib.CountBooks();
    }
}
