using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;
using static System.Globalization.DateTimeFormatInfo;
namespace Ranges
{
    partial class Program
    {
        static void Main(string[] args)
        {
            LikeExample();
        }



        private static string Likes(string[] name) =>
            name.Length switch
            {
                > 3 => $"{string.Join(", ", name[..2])} and {name.Length - 2} others like this",
                > 1 => $"{string.Join(", ", name[..^1])} and {name[^1]} others like this",
                1 => $"{name[0]} likes this",
                _ => "no one likes this"
            };

        private static void LikeExample()
        {
            var table = new Table()
                .RoundedBorder()
                .AddColumn("[b]Array[/]")
                .AddColumn("[b]Results[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title("[yellow]Likes[/]");

            List<string[]> nameList = new()
            {
                new[] { "Karen", "Mary", "Tom", "Adam", "Sue" },
                new[] { "Karen", "Mary", "Tom" },
                new[] { "Karen" }
            };

            foreach (var names in nameList)
            {
                table.AddRow($"{string.Join(",", names)}", $"{Likes(names)}");
            }

            AnsiConsole.Write(table);

            Console.ReadLine();
        }

    }

    public class Extensions
    {
        /// <summary>
        /// Returns a string list of month names for the current culture
        /// </summary>
        /// <returns>
        /// List of month names for current culture
        /// </returns>
        public static List<string> MonthNames()
            => CurrentInfo!.MonthNames[..^1].ToList();
    }

}
