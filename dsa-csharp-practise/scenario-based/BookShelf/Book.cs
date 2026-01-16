namespace BookShelf
{
    public class Book   // ⚠️ public VERY IMPORTANT
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return Title + " by " + Author;
        }
    }
}
