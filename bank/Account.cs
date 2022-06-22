using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Account
    {
        private int _nextId;
        private string _name;
        private Customer _customer;
        private Bank _bank;
        private List<Transaction> _transactions;
        public long AccountNumber { get; }
        public decimal Balance { get; private set; }

        public Account(long accountNumber, string name, Customer customer, Bank bank)
        {
            AccountNumber = accountNumber;
            _bank = bank;
            _customer = customer;
            _name = name;
            _transactions = new List<Transaction>();
            _nextId = 0;
        }


        public Transaction Deposit(decimal amount, DateTime date)
        {
            return AddTransaction(amount, date, "Innskudd");
        }

        public Transaction Withdraw(decimal amount, DateTime date)
        {
            return AddTransaction(amount, date, "Uttak");
        }

        public Transaction AddTransaction(
            decimal amount,
            DateTime date,
            string text)
        {
            Balance += amount;
            var transaction = new Transaction(
                _nextId,
                amount,
                text,
                date,
                this);
            _nextId++;
            _transactions.Add(transaction);
            return transaction;
        }

        public Statement GetLatestStatement()
        {
            var latestCompletedMonth = YearAndMonth.GetLatestMonth();
            return GetStatement(latestCompletedMonth);
        }

        public Statement GetStatement(YearAndMonth yearAndMonth)
        {
            var transactions = _transactions
                .Where(t => yearAndMonth.Matches(t.Date));
            return new Statement(yearAndMonth, transactions);
        }
    }
}
