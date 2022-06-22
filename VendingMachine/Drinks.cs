using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drinks : Product
    {
       public Drinks(string name, int id, int price, int inventory) : base(name, id, price, inventory)
        {
            
        }
      
    }
}
