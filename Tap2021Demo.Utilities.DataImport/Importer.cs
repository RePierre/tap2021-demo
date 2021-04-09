#define XBOX
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Tap2021Demo.DomainEntities;

namespace Tap2021Demo.Utilities.DataImport
{
    internal partial class Importer
    {
        private readonly string fileName;

        public Importer(string fileName)
        {
            this.fileName = fileName;
        }


        public IEnumerable<IAccount> ImportData(string cultureName)
        {
            IEnumerable<DataRecord> data = null;
            var stream = new StreamReader(this.fileName);
            using (var reader = new CsvHelper.CsvReader(stream, new CultureInfo(cultureName)))
            {
                data = reader.GetRecords<DataRecord>().ToList();
            }
            RunOnXboxOnly($"In {nameof(ImportData)}.");
            var result = new List<IAccount>();
            foreach (var item in data)
            {
                var accHolder = new AccountHolder(item.IdNo, item.FirstName, item.LastName);
                var account = new DebitAccount(item.Iban, item.Balance, accHolder);
                result.Add(account);
            }
            return result;
        }

        [Conditional("XBOX")]
        void RunOnXboxOnly(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
