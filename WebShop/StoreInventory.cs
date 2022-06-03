using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class StoreInventory
    {
        public List<Games> InventoryList { get; private set; }
        public StoreInventory()
        {
            InventoryList = new List<Games>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new Pokemon());
            InventoryList.Add(new Cyberpunk());
            InventoryList.Add(new Battlefield());
        }

        

        //StoreInventory må inneholde:
        public List<Games> ListPhysicalItems()
        {
            // for å finne alle elementene i InventoryList som selges i fysisk format 
            return InventoryList.Where(Games => Games is IPhysical).ToList();
        }

        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownloadable());
            }
        }



    }
}
