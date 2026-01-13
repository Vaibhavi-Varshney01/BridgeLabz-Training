namespace BookBuddyApp
{
    class Menu
    {
        private IBookService service;

        public Menu()
        {
            service = new BookShelf(); // interface ref
        }

        public void ShowMenu()
        {
            service.AddBook(new Book("Atomic Habits", "James Clear"));
            service.AddBook(new Book("Deep Work", "Cal Newport"));
            service.AddBook(new Book("Clean Code", "Robert Martin"));
            service.AddBook(new Book("The Alchemist", "Paulo Coelho"));

            service.SortBooksAlphabetically();
            service.SearchByAuthor("James Clear");
            service.ExportBooks();
        }
    }
}
