using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Bank
    {
        private List<Customer> _customers;
        private List<Account> _accounts;
        private long _nextAccountNumber;

        public Bank()
        {
            _accounts = new List<Account>();
            _customers = new List<Customer>();
            _nextAccountNumber = 11112233333;
        }

        public Customer CreateCustomer(string name)
        {
            var customer = new Customer(name, this);
            _customers.Add(customer);
            return customer;
        }

        public Account CreateAccount(Customer customer, string accountName)
        {
            var account = new Account(_nextAccountNumber, accountName, customer, this);
            _nextAccountNumber++;
            customer.AddAccount(account);
            _accounts.Add(account);
            return account;
        }

        public void Transfer(
            Customer customer,
            Account account1,
            Account account2,
            decimal amount,
            DateTime date)
        {
            // vi sender med kunde. Hvis kunden ikke eier fra-konto => feil

            account1.AddTransaction(
                -amount,
                date,
                "Overført til konto " + account2.AccountNumber);
            account2.AddTransaction(
                amount,
                date,
                "Overført fra konto " + account1.AccountNumber);
        }
    }
}
