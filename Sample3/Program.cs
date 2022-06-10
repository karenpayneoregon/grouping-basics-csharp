using System;
using System.Linq;
using Sample3.Classes;
using Sample3.Models;

namespace Sample3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var grouped = Mock.Books()
                .GroupBy(group => group.AuthorName, StringComparer.CurrentCultureIgnoreCase)
                .Select(grouping => new AuthorListing(grouping.Key, grouping.ToList()
                    .Select(book => book.Titles.ToList())))
                .OrderBy(x => x.Author)
                .ToList();

            foreach (AuthorListing listing in grouped)
            {
                Console.WriteLine(listing.Author);
                foreach (var title in listing.Titles)
                {
                    Console.WriteLine($"\t{title}");
                }

                Console.WriteLine();

            }


            Console.ReadLine();
        }
    }
}
