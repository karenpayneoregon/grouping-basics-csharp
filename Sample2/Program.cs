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
        var root = new Tree("[lightsteelblue]Country and age[/]");

        var usersGroupedByCountryAndAge = SomeExample();
        foreach (var group in usersGroupedByCountryAndAge)
        {
            var currentNode = root.AddNode($"From [yellow]{@group.Key.HomeCountry}[/] at the age of [yellow]{@group.Key.Age}[/]");
            foreach (var user in @group)
            {
                currentNode.AddNode($"{user.Name} - {user.Age} years");
            }
        }

        AnsiConsole.Write(root);

        Console.ReadLine();
    }


    private static IEnumerable<IGrouping<CountryAndAgeGroups, User>> SomeExample() 
        => Mocked
            .Users()
            .GroupBy(user => new CountryAndAgeGroups(user.Country, user.Age));

}