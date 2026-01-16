namespace BrowserBuddy
{
    class PageNode
    {
        public string Url;
        public PageNode Prev;
        public PageNode Next;

        public PageNode(string url)
        {
            Url = url;
        }
    }
}
