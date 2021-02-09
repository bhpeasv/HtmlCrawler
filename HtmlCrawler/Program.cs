using HtmlAgilityPack;
using System;

namespace HtmlCrawler
{
    // Needs the nuget "HtmlAgilityPack" installed
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter link: ");
            var urlString = Console.ReadLine();

            var uri = new UriBuilder(urlString).Uri;

            var web = new HtmlWeb();
            var doc = web.Load(uri.ToString());

            var allLinks = doc.DocumentNode.SelectNodes("//a");
            
            Console.WriteLine("\n\nFound links:");
            foreach (var link in allLinks)
            { 
                string url = link.GetAttributeValue("href", "no url");
                Console.WriteLine(url);
            }
        }
    }
}
