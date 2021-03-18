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
            var printer = new ConsolePrinter();
            printer.PrintData(importer.ImportData());
        }
    }
}
