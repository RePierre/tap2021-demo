using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Tap2021Demo.DomainEntities;

namespace Tap2021Demo.Utilities.DataImport
{
    internal class Importer
    {
        private readonly string fileName;

        class DataRecord
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

        public Importer(string fileName)
        {
            this.fileName = fileName;
        }

        public IEnumerable<IAccount> ImportData()
        {
            IEnumerable<DataRecord> data = null;
            using var stream = new StreamReader(this.fileName);
            using (var reader = new CsvHelper.CsvReader(stream, new CultureInfo("ro-RO")))
            {
                data = reader.GetRecords<DataRecord>().ToList();
            }

            var result = new List<IAccount>();
            foreach (var item in data)
            {
                var accHolder = new AccountHolder(item.IdNo, item.FirstName, item.LastName);
                var account = new DebitAccount(item.Iban, item.Balance, accHolder);
                result.Add(account);
            }
            return result;
        }
    }
}
