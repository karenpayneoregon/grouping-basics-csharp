using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;


// ReSharper disable once CheckNamespace
namespace GroupByMultiplePropertiesFindDuplicates
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            // center this window
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





