using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_MAGNUS
{
    internal class CounterTerrorist : Player
    {

        public void DefuseBomb()
        {
            //bruker 5 tidsenheter på å fullføre.
            // alle t må være døde før den kan kalles
            // hvis den rekker å bli ferdig før den sprenger så vinner CT

            Console.WriteLine($"'DefuseBomb()' kjørte, og '{Name}' kjørte den.");
        }

        public CounterTerrorist()
        {
            
        }
        public CounterTerrorist(string name)
        {
            Name = name;
        }

        
        public void KillTerrorist(Terrorist terrorist, bool successful)
        {
            Console.WriteLine($"'KillTerrorist()' kjørte på '{terrorist}', og '{Name}' kjørte den. Successful?: {successful}");
            if (successful == true)
            {
                terrorist.IsDead = true;
            }
            
        }

    }
}