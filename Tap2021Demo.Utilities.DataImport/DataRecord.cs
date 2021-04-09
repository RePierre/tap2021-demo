#define XBOX
using CsvHelper.Configuration.Attributes;
using System.Diagnostics;

namespace Tap2021Demo.Utilities.DataImport
{

    [DebuggerDisplay("{FirstName} {LastName} {Balance}")]
    internal class DataRecord
    {
        [Name("IBAN")]
        public string Iban { get; set; }
        [Name("First Name")]
        public string FirstName { get; set; }
        [Name("Last Name")]
        public string LastName { get; set; }
        [Name("IdNo")]
        public string IdNo { get; set; }
        [Name("Balance")]
        public decimal Balance { get; set; }
    }

    static class DataRecordExtensions
    {
        public static bool IsNegativeBalance(this DataRecord record)
        {
            return record.Balance < 0;
        }
    }
}
