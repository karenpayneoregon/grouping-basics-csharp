using System;
using System.Data;
using System.Globalization;
using System.Linq;
using Spectre.Console;


namespace Sample5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var table1 = GenericTable("Source");
            var table2 = GenericTable("Grouped");

            var sourceDataTable = MockedDataTable();
            var resultDataTable = GroupData(sourceDataTable);

            foreach (DataRow row in sourceDataTable.Rows)
            {
                string[] itemArray = row.ItemArray
                    .Cast<decimal>()
                    .Select(value => value.ToString(CultureInfo.CurrentCulture))
                    .ToArray();

                table1.AddRow(itemArray);
            }

            AnsiConsole.Write(table1);

            foreach (DataRow row in resultDataTable.Rows)
            {
                string[] itemArray = row.ItemArray
                    .Cast<decimal>()
                    .Select(value => value.ToString(CultureInfo.CurrentCulture))
                    .ToArray();

                table2.AddRow(itemArray);
            }

            AnsiConsole.Write(table2);
            Console.ReadLine();
        }
    }
}
