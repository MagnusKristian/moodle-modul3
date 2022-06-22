using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Food : Product
    {
        public string ExpirationDate { get; set; }

        public Food(string name, int id, int price, int inventory, string expirationDate) : base(name, id, price, inventory)
        {
            ExpirationDate = expirationDate;
        }


    }
}