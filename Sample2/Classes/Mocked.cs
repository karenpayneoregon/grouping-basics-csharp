using System.Collections.Generic;
using Sample2.Models;

namespace Sample2.Classes
{
    public class Mocked
    {
        public static List<User> Users() =>
            new()
            {
                new() { Name = "Frank Smith", Age = 42, Country = Country.USA },
                new() { Name = "Mary Adams", Age = 38, Country = Country.USA },
                new() { Name = "Bill Jenkins", Age = 19, Country = Country.Germany },
                new() { Name = "Anne Jones", Age = 19, Country = Country.Germany },
                new() { Name = "James Gallagher", Age = 8, Country = Country.USA },
            };
    }
}