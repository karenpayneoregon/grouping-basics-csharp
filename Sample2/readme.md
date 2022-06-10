# About

Group by two properties, one an `int` while the other an `enum` with `anonymous type` result.

```csharp
namespace Sample2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var usersGroupedByCountryAndAge = Mocked.Users()
                .GroupBy(user => new { HomeCountry = user.Country, user.Age });

            foreach (var group in usersGroupedByCountryAndAge)
            {
                
                Console.WriteLine($"Users from {group.Key.HomeCountry} at the age of {group.Key.Age}:");

                foreach (var user in group)
                {
                    Console.WriteLine($"\t{user.Name,-20} [{user.Age} years]");
                }
            }

            Console.ReadLine();
        }
    }
}
```