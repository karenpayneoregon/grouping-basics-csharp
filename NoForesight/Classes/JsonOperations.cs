﻿using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NoForesight.Models;

namespace NoForesight.Classes
{
    class JsonOperations
    {
        private static string _fileName = "books.json";

        public static void CreateFile()
        {
            File.WriteAllText(_fileName, 
                JsonSerializer.Serialize(Books, 
                    new JsonSerializerOptions { WriteIndented = true, }));
        }


        public static List<Book> BookList()
            => JsonSerializer.Deserialize<List<Book>>(
                File.ReadAllText(_fileName));

        private static List<Book> Books { get; } = new()
        {
            new Book { Id = 1, Title = "Learn EF Core", Price = 19.0000M },
            new Book { Id = 2, Title = "C# Basics", Price = 18.0000M },
            new Book { Id = 3, Title = "ASP.NET Core advance", Price = 30.0000M },
            new Book { Id = 4, Title = "VB.NET To C#", Price = 9.0000M, },
        };
    }
}
