﻿using System;
using System.Runtime.CompilerServices;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace NoForesight
{
    partial class Program
    {
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }
        private static Table CreateViewTable()
        {
            return new Table()
                .Border(TableBorder.Square)
                .BorderColor(Color.Grey100)
                .Title("[yellow][B]Books[/][/]")
                .AddColumn(new TableColumn("[u]Id[/]"))
                .AddColumn(new TableColumn("[u]price range[/]"))
                .AddColumn(new TableColumn("[u]Title[/]"))
                .AddColumn(new TableColumn("[u]Price[/]")
                );
        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - grouping data";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





