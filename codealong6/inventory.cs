using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codealong6
{
    internal class Character
    {
        public string Name { get; set; }
        public string Potions { get; set; }
        public string Weapons { get; set; }
        public string Accessory { get; set; }

        public List<Items> Inventory { get; set; }

        public Character()
        {
            Inventory = new List<Items>();
        }
    }
}
