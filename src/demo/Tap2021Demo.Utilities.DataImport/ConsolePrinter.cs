using System.Collections.Generic;
using System.Linq;
using Tap2021Demo.DomainEntities;

namespace Tap2021Demo.Utilities.DataImport
{
    public delegate void WriteLine(string line);

    class ConsolePrinter
    {
        private readonly WriteLine printer;


        public ConsolePrinter(WriteLine printer)
        {
            this.printer = printer;
        }

        public void PrintData(IEnumerable<IAccount> data)
        {
            if (!data.Any())
            {
                printer("No data to print");
                return;
            }

            foreach (var item in data)
            {
                var person = item.AccountHolder;
                printer($"Account: Iban={item.Iban}, Balance={item.Balance}; AccountHolder: FirstName={person.FirstName}, LastName={person.LastName}, IdNo={person.IdNo}");
            }
        }
    }
}
