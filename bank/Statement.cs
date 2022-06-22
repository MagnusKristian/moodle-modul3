using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Statement
    {
        private YearAndMonth _yearAndMonth;
        public Transaction[] Transactions { get; }

        public Statement(YearAndMonth yearAndMonth, IEnumerable<Transaction> transactions)
        {
            _yearAndMonth = yearAndMonth;
            Transactions = transactions.ToArray();
        }
    }
}
