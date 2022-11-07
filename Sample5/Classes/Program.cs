using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace Sample5
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample: DataTable";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }

        public static Table GenericTable(string title) =>
            new Table().RoundedBorder().AddColumn("[b]Tax rate[/]").AddColumn("[b]Value[/]").AddColumn("[b]Tax amount[/]").AddColumn("[b]Final amount[/]").Alignment(Justify.Center).BorderColor(Color.LightSlateGrey).Title($"[yellow]{title}[/]");

        private static void DeleteMe()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "Id", 
                DataType = typeof(int), 
                AutoIncrement = true, 
                AutoIncrementSeed = 10
            });
            dt.Columns.Add("Column1", typeof(decimal));
            dt.Columns.Add("Column2", typeof(decimal));
            dt.Columns.Add(new DataColumn() { ColumnName = "SubTotal", DataType = typeof(decimal), 
                Expression = "Column1 * Column2"
            });

            dt.Rows.Add(null,13, 2);
            dt.Rows.Add(null,13, 22);



            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row.Field<int>("id"), -4}{row.Field<decimal>("SubTotal")}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }

        /// <summary>
        /// Mini data coming from a database, text file etc.
        /// </summary>
        /// <returns><see cref="DataTable"/></returns>
        public static DataTable MockedDataTable()
        {
            var table = new DataTable();

            table.Columns.Add(new DataColumn("TaxRate", typeof(decimal)));
            table.Columns.Add(new DataColumn("Value", typeof(decimal)));
            table.Columns.Add(new DataColumn("TaxAmount", typeof(decimal)));
            table.Columns.Add(new DataColumn("FinalValue", typeof(decimal), "Value + TaxAmount"));

            table.Rows.Add(5, 1000, 50);
            table.Rows.Add(5, 2000, 100);

            table.Rows.Add(10, 1000, 100);
            table.Rows.Add(10, 2000, 200);

            table.Rows.Add(15, 1000, 150);
            table.Rows.Add(15, 2000, 300);

            return table;

        }

        /// <summary>
        /// Group by TaxRate column into a new DataTable
        /// </summary>
        /// <param name="dt"><see cref="DataTable"/></param>
        public static DataTable GroupData(DataTable dt)
        {

            return dt.AsEnumerable()
                .GroupBy(row => row.Field<decimal>("TaxRate"))
                .Select(grouped =>
                {
                    var row = dt.NewRow();

                    row["TaxRate"] = grouped.Key;
                    row["Value"] = grouped.Sum(dRow => dRow.Field<decimal>("Value"));
                    row["FinalValue"] = grouped.Sum(dRow => dRow.Field<decimal>("FinalValue"));
                    row["TaxAmount"] = grouped.Sum(dRow => dRow.Field<decimal>("TaxAmount"));

                    return row;

                })
                .CopyToDataTable();
        }

    }
}





