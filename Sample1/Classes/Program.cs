using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace Sample1
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample: grouping simple with strings";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}

