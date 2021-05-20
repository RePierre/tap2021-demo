using System;
using Tap2021Demo.Extensions;

namespace Tap2021Demo.Utilities.DataImport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usage: dataimporter -i <file.csv>
            // Open input file
            // Read data & parse
            // Display data

            var importer = new Importer(@"C:\Git\tap2021-demo\data.csv");
            Console.WriteLine($"Importing data for {DateTime.Today.ToIsoShortDate()}");
            var printer = new ConsolePrinter(Console.WriteLine);
            printer.PrintData(importer.ImportData("ro-RO"));

        }
    }
}
