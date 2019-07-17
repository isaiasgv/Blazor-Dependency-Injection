using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDependencyInjection.Shared
{
    public class AccountDetails
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }

    public class Transaction
    {
        public string Code { get; set; }
        public double Amount { get; set; }
        public string Name { get; set; }
    }
}
