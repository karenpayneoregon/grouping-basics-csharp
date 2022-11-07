using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ChunkingConsoleApp.LanguageExtensions;
using static System.Globalization.DateTimeFormatInfo;

namespace ChunkingConsoleApp;

partial class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }

    private static void ChunkNumbersCore6()
    {
        List<int[]> values = Enumerable.Range(1, 34).Chunk(12).ToList();

        foreach (var array in values)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }

    private static void ChunkNumbersCore5()
    {
        List<List<int>> values = Enumerable.Range(1, 34).ToList().ChunkBy(12);
        foreach (var value in values)
        {
            value.ForEach(Console.WriteLine);
            Console.WriteLine();
        }
    }

    private static void MonthsExample()
    {
        var chunked = MonthNames().ChunkBy(5);
        foreach (var item in chunked)
        {
            item.ForEach(Console.WriteLine);
            Console.WriteLine();
        }
    }


    public static List<string> MonthNames() => CurrentInfo!.MonthNames[..^1].ToList();
}