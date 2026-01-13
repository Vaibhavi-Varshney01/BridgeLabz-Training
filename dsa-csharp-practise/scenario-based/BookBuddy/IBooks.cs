namespace BookBuddyApp
{
    interface IBookService
    {
        void AddBook(Book book);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
        void ExportBooks();
    }
}
