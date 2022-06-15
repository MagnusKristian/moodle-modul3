using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Terrorist : Player, Interface1
    {
        // IsSuccessful(10) returnerer enten true eller false.
        // kaller på metoden: FindBombSite(IsSuccessful(10));

        //public string Name;
        //public string Name { get; set; }
        //public string name
        //{
        //    get { return Name;}
        //    set { Name = value; }
        //}
        public bool FindBombSite(bool successful)
        {
            //HER SKAL T FINNE ELLER IKKE FINNE BOMB SITE "A"
            if (successful == true)
            {
                Console.WriteLine("T FANT BOMBSITE A");
                PlantBomb();
                return true;
            }
            else
            {
                Console.WriteLine("T FANT IKKE BOMBSITE A");
                return false;
            }
        }
        //DENNE OVER ER GREI.... ?

       

        public void KillCounterTerrorist(CounterTerrorist ct, bool successful)
        {
            ct.IsDead = true;
            //kille CT metode?
        }

        public void PlantBomb()
        {
            Console.WriteLine($"Planting the bomb...");
            Thread.Sleep(5000);
            Console.WriteLine($"The bomb has been planted.");
            int bombCountdown = 15;
            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine($"Time left: {i}");
                Thread.Sleep(1000);
                bombCountdown--;
            }

            if (bombCountdown <= 0)
            {
                Console.WriteLine("Terroristene vant!");
                //GameRunning = false;
            }
        }

    }
}
