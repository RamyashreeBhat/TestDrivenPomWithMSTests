using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class SearchResultsPage
    {
        public int FindLinksCount(string searchText) {
            var links = Browser.FindPageElements(By.PartialLinkText(searchText));

            //foreach (IWebElement element in links)
            //{
            //    Console.WriteLine(element.Text+"\n");
            //}
            Console.WriteLine("Count of links = "+links.Count());
            return links.Count();
           
        }
    }
}
