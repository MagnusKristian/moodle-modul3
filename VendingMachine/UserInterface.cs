using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class UserInterface
    {
        public void PrintAllGods(Machine machine)
        {

            //machine.DrinksList[0].Inventory;
            //Console.WriteLine(machine.DrinksList[0].Name);
            machine.PrintAllDrinks();
            machine.PrintAllFoods();
        }
    }
}
