using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    public class Games
    {

        public string GameName { get; set; }
        public double Price { get; set; }
        public string Id { get; set; }

        public virtual void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id} ");
        }
    }

}


/*
 * 
WebShopen skal ha en inventory med disse fire spillene:

Id: 1, Battlefield, pris: 150kr  (Kun nedlastbart)

Id: 2, Cyberpunk, pris: 250kr  (Kan lastes ned, eller kjøpes som disk)

Id: 3, Pokemon Let`s GO Evee, pris: 400kr (Kan kun kjøpes fysisk)

Id: 4, PUBG, pris: 100kr (Kan lastes ned eller kjøpes som disk)


Lag en klasse StoreInventory med følgende constructor: 

public StoreInventory()
{
            InventoryList = new List<GameItem>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
}

 */