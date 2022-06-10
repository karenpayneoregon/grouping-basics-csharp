using System;
using System.Collections.Generic;
using Sample4.Classes;
using Sample4.Models;

namespace Sample4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Operations.OnIterate += OnIterate;
            Operations.GetAuthorAndBooks();
            Console.ReadLine();
        }

        private static void OnIterate(string authorName, List<Book> books)
        {
            Console.WriteLine(authorName);
            foreach (var book in books)
            {
                Console.WriteLine($"\t{book.Id,-8}{book.Title}");
            }
        }
    }

}
