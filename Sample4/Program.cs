using System;
using System.Collections.Generic;
using Sample4.Classes;
using Sample4.Models;
using Spectre.Console;

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

            AnsiConsole.MarkupLine($"[cyan]{authorName}[/]");
            foreach (var book in books)
            {
                AnsiConsole.MarkupLine($"\t[green]{book.Id,-8}[/][yellow]{book.Title}[/]");
            }
        }
    }

}
