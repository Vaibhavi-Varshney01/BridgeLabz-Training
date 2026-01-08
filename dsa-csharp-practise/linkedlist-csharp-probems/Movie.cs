using System;
class MovieNode{
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode Prev, Next;

    public MovieNode(string t, string d, int y, double r)
    {
        Title = t; Director = d; Year = y; Rating = r;
    }
}
class Movie{
    MovieNode head, tail;
    public void AddAtEnd(string t, string d, int y, double r)
    {
        MovieNode node = new MovieNode(t, d, y, r);
        if (head == null)
        {
            head = tail = node;
            return;
        }
        tail.Next = node;
        node.Prev = tail;
        tail = node;
    }

    public void Remove(string title)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                if (temp.Prev != null) temp.Prev.Next = temp.Next;
                else head = temp.Next;

                if (temp.Next != null) temp.Next.Prev = temp.Prev;
                else tail = temp.Prev;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} {temp.Rating}");
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        MovieNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Title} {temp.Rating}");
            temp = temp.Prev;
        }
    }
}
