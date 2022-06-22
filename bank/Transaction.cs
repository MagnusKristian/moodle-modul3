using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Transaction
    {
        public int Id { get; }
        public decimal Amount { get; }
        public string Text { get; }
        public DateTime Date { get; }
        public Account Account { get; }

        public Transaction(int id, decimal amount, string text, DateTime date, Account account)
        {
            Id = id;
            Amount = amount;
            Text = text;
            Date = date;
            Account = account;
        }
    }
}
