using System;

namespace BrowserBuddy    
{
    class BrowserTab       
    {
        private PageNode head;
        private PageNode current;

        public BrowserTab(string homepage)    
        {
            head = new PageNode(homepage);
            current = head;
        }

        public void Visit(string url)         
        {
            PageNode newPage = new PageNode(url);

            current.Next = null;               
            newPage.Prev = current;           
            current.Next = newPage;
            current = newPage;

            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No Previous Page");
            }
        }

        public void Forward()
        {
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No Forward Page");
            }
        }

        public string CurrentPage()
        {
            return current.Url;
        }
    }
}
