using System;
using System.Collections.Generic;
using System.Linq;
using Tap2021Demo.DomainEntities;

namespace Tap2021Demo.Utilities.DataImport
{
    class ConsolePrinter
    {
        public void PrintData(IEnumerable<IAccount> data)
        {
            if (!data.Any())
            {
                Console.WriteLine("No data to print");
                return;
            }

            foreach (var item in data)
            {
                var person = item.AccountHolder;
                Console.WriteLine($"Account: Iban={item.Iban}, Balance={item.Balance}; AccountHolder: FirstName={person.FirstName}, LastName={person.LastName}, IdNo={person.IdNo}");
            }
        }
    }
}
