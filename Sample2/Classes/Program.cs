﻿using System;
using System.Runtime.CompilerServices;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace Sample2;

partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample: grouping simple with classes";
        W.SetConsoleWindowPosition(W.AnchorWindow.Center);
    }
    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }

    private static void ExitPrompt()
    {
        Console.WriteLine();
        Render(new Rule($"[yellow]Press a key to exit the demo[/]").RuleStyle(Style.Parse("silver")).Centered());
        Console.ReadLine();
    }
}