using System;
using System.Collections.Generic;
using System.Linq;
using ChunkingConsoleApp.LanguageExtensions;
using static System.Globalization.DateTimeFormatInfo;
namespace ChunkingConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var chunked = MonthNames().ChunkBy(2);
            foreach (var item in chunked)
            {
                item.ForEach(Console.WriteLine);
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }


        public static List<string> MonthNames() => CurrentInfo!.MonthNames[..^1].ToList();
    }
}
