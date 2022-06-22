using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class MachineOne
    {
        public MachineOne()
        {
            var machineOne = new Machine();
            

            machineOne.AddDrink("fanta", 0, 20, 5);
            machineOne.AddDrink("Cola", 1, 22, 3);

            machineOne.AddFood("Energy Bar", 0, 23, 10, "23.06.22");
            machineOne.AddFood("Snickers", 1, 25, 5, "26.06.22");

            //machineOne.AddCandy(tyrkisk pepper, id , pris)
            //machineOne.PrintAllDrinks();
            //machineOne.PrintAllFoods();

            var Userinterface = new UserInterface();
            Userinterface.PrintAllGods(machineOne);
        }



    }
}
