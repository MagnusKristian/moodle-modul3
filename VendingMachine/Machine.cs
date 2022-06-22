using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Machine
    {
        public List<Drinks> DrinksList { get; set; }
        public List<Food> FoodsList { get; set; }

        public Machine()
        {
            DrinksList = new List<Drinks>();
            FoodsList = new List<Food>();
        }

        public void AddDrink(string name, int id, int price, int inventory)
        {
            DrinksList.Add(new Drinks(name, id, price, inventory));
        }

        public void AddFood(string name, int id, int price, int inventory, string expirationDate)
        {
            FoodsList.Add(new Food(name, id, price, inventory, expirationDate));
        }



        public void BuyItem()
        {
            //
            // X.inventory--;
        }

        public void PrintAllDrinks()
        {
            foreach (var drink in DrinksList)
            {
                drink.PrintProduct();
            }
        }

        public void PrintAllFoods()
        {
            foreach (var food in FoodsList)
            {
                food.PrintProduct();
            }
        }
    }
}


/* //public void Kjøp()
        //{
        //    // når id blir valgt 
        //    //sjekk inventory om det er nok ==5
        //    //sjekk saldo at det er nok der ==MachienOne.Saldo MachienOne.Saldo == pris
        //    //alt stemmer. MachineOne.Saldo -= id/fanta.pris. id/fanta.Inventory -1;

            //fanta,id1,20,4
        }
      */