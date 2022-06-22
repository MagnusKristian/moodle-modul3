using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }

        public Product(string name, int id, int price, int inventory)
        {
            Name = name;
            Id = id;
            Price = price;
            Inventory = inventory;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"Name: {Name}. Id:{Id}. Price:{Price}. Inventory:{Inventory}");
        }
        

    }
}
