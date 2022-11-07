using System;
using System.Collections.Generic;
using System.Linq;
using Sample1.LanguageExtensions;
using Spectre.Console;


namespace Sample1;

partial class Program
{
    static void Main(string[] args)
    {

        string[] lines = {
            "This is a test",
            "This is a apple",
            "This is a Banana",
            "This is a orange",
            "This is a grape",
            "This is a test",
            "This is a orange",
            "This is a test"
        };

        if (lines.ContainsDuplicates())
        {
            // Get items in lines that have duplicates
            List<string> duplicates = lines.GroupBy(line => line)
                .Where(group => @group.Count() > 1)
                .Select(grouping => grouping.Key)
                .ToList();

            // display duplicates
            AnsiConsole.MarkupLine("[white on blue]Duplicates in[/][yellow on blue] lines[/] ");
            duplicates.ForEach(Console.WriteLine);

            Console.WriteLine();

            // get indices in lines for `This is a test`
            AnsiConsole.MarkupLine("[white on blue]\"This is a test\" indices[/] ");
            
            List<int> indices = lines.Select((value, index) => new { value, index })
                .Where(a => string.Equals(a.value, "This is a test"))
                .Select(a => a.index).ToList();

            // redundant check
            if (indices.Any())
            {
                indices.ForEach(Console.WriteLine);
            }

        }

        ExitPrompt();
    }
}