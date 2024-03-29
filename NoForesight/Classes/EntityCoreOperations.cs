﻿using System;
using NoForesight.Data;
using NoForesight.Models;

namespace NoForesight.Classes
{
    public class EntityCoreOperations
    {
        public static (bool success, Exception exception) CreateBookDatabase()
        {
            try
            {
                using var context = new BookContext();
                Helpers.CleanDatabase(context);
                return (true, null);
            }
            catch (Exception localException)
            {
                return (false, localException);
            }
        }

        public static bool Populate()
        {
            using var context = new BookContext();
            context.Books.Add(new Book() { Title = "Learn EF Core", Price = 19 });
            context.Books.Add(new Book() { Title = "C# Basics", Price = 18 });
            context.Books.Add(new Book() { Title = "ASP.NET Core advance", Price = 30 });
            context.Books.Add(new Book() { Title = "VB.NET To C#", Price = 9 });
            context.Books.Add(new Book() { Title = "Basic Azure", Price = 59 });

            return context.SaveChanges() == 5;
        }
    }
}
