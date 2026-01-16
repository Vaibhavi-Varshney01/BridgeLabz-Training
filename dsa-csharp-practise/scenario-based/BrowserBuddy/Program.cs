using System;

namespace BrowserBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            BrowserManager manager = new BrowserManager();

            manager.OpenTab("google.com");

            BrowserTab tab = manager.GetCurrentTab();
            tab.Visit("youtube.com");
            tab.Visit("github.com");

            tab.Back();
            tab.Forward();

            manager.CloseTab();
            manager.RestoreTab();

            Console.WriteLine("Current Page: " + manager.GetCurrentTab().CurrentPage());
        }
    }
}
