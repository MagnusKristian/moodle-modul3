using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codealong6
{
    public class Potions: Items
    {
        public string Potion { get; set; }

        public Potions(string name) : base(name)
        {
        }

    }
}
