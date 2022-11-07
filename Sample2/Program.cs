using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Sample2.Classes;
using Sample2.Models;
using Spectre.Console;

namespace Sample2;

partial class Program
{
    static void Main(string[] args)
    {


        var grouped =
            from student in Mocked.GetStudents()
            group student by new { Branch = student.Branch, student.Gender } into g
            orderby g.Key.Branch descending, g.Key.Gender ascending
            select new
            {
                Branch = g.Key.Branch, 
                Gender = g.Key.Gender, 
                Students = g.OrderBy(s => s.FullName)
            };


        foreach (var group in grouped)
        {
            AnsiConsole.MarkupLine($"[white]Branch[/] [cyan]{group.Branch}[/] [white]Gender[/] [cyan]{group.Gender}[/] [white]No of Students[/] [cyan]{group.Students.Count()}[/]");

            foreach (var student in group.Students)
            {
                AnsiConsole.MarkupLine($"  [white]Id[/] [orange1]{student.Id}[/] [white]Name[/] [orange1]{student.FullName}[/] [white]Age[/] [orange1]{student.Age}[/]");
            }
            Console.WriteLine();
        }

        ExitPrompt();
    }
}

