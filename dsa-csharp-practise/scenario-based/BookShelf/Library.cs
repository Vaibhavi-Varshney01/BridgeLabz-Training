using System;
using System.Collections.Generic;
namespace BookShelf{
    class Library{
        private Dictionary<string, LinkedList<Book>> catalog =
            new Dictionary<string, LinkedList<Book>>();
        private HashSet<string> bookSet = new HashSet<string>();
        public void AddBook(string genre, Book book)
        {
            string key = genre + book.Title;

            if (bookSet.Contains(key))
            {
                Console.WriteLine("Duplicate book not allowed");
                return;
            }

            if (!catalog.ContainsKey(genre))
                catalog[genre] = new LinkedList<Book>();

            catalog[genre].AddLast(book);
            bookSet.Add(key);

            Console.WriteLine($"Book added: {book}");
        } 
        public void BorrowBook(string genre, string title)
        {
            if (!catalog.ContainsKey(genre))
            {
                Console.WriteLine("Genre not found");
                return;
            }

            var list = catalog[genre];
            foreach (var book in list)
            {
                if (book.Title == title)
                {
                    list.Remove(book);
                    bookSet.Remove(genre + title);
                    Console.WriteLine($"Book borrowed: {book}");
                    return;
                }
            }

            Console.WriteLine("Book not found");
        }

        public void Display()
        {
            foreach (var genre in catalog)
            {
                Console.WriteLine("\nGenre: " + genre.Key);
                foreach (var book in genre.Value)
                {
                    Console.WriteLine(" - " + book);
                }
            }
        }
    }
}
