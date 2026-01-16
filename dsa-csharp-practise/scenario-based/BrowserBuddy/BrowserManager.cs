using System;
using System.Collections.Generic;
namespace BrowserBuddy{
    class BrowserManager{
        private BrowserTab currentTab;
        private Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();

        public void OpenTab(string homepage){
            currentTab = new BrowserTab(homepage);
            Console.WriteLine("New tab opened: " + homepage);
        }

        public BrowserTab GetCurrentTab(){
            return currentTab;
        }
        public void CloseTab(){
            if (currentTab != null)
            {
                closedTabs.Push(currentTab);
                currentTab = null;
                Console.WriteLine("Tab closed");
            }
        }
        public void RestoreTab(){
            if (closedTabs.Count > 0){
                currentTab = closedTabs.Pop();
                Console.WriteLine("Closed tab restored");
            }
            else{
                Console.WriteLine("No closed tabs available");
            }
        }
    }
}
