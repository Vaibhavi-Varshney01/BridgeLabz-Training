using System;
using System.Collections;

namespace BookBuddyApp
{
    class BookShelf : IBookService
    {
        private ArrayList books = new ArrayList();

        public void AddBook(Book book)
        {
            if (book == null || string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
            {
                Console.WriteLine("Invalid book details");
                return;
            }

            books.Add(book.GetFormattedBook());
            Console.WriteLine("Book added");
        }

        public void SortBooksAlphabetically()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Bookshelf is empty");
                return;
            }

            books.Sort();
            Console.WriteLine("Books sorted alphabetically");
        }

        public void SearchByAuthor(string author)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available");
                return;
            }

            bool found = false;

            foreach (string book in books)
            {
                string[] parts = book.Split('-'); // String.split()

                if (parts.Length != 2)
                    continue;

                string bookAuthor = parts[1].Trim();

                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author");
        }

        public void ExportBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books to export");
                return;
            }

            string[] bookArray = (string[])books.ToArray(typeof(string));

            Console.WriteLine("Exported Books:");
            foreach (string b in bookArray)
            {
                Console.WriteLine(b);
            }
        }
    }
}
