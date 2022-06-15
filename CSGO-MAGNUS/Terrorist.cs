using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_MAGNUS
{
    internal class Terrorist : Player
    {
        // IsSuccessful(10) returnerer enten true eller false.
        // kaller på metoden: FindBombSite(IsSuccessful(10));


        //terrorist constructor clean
        public Terrorist()
        {
            
        }
        //terrorist constructor med name
        public Terrorist(string name)
        {
            Name = name;
        }

        

        //terrorist metode finne bombsite eller ikke.
        public bool FindBombSite(bool successful)
        {
            Console.WriteLine($"'FindBombSite()', og '{Name}' kjørte den. Successful?: {successful}");
            //HER SKAL T FINNE ELLER IKKE FINNE BOMB SITE "A"
            if (successful == true)
            {
                Console.WriteLine($"T: {Name} FANT BOMBSITE A");
                PlantBomb();
                return true;
            }
            else
            {
                Console.WriteLine($"T: {Name} FANT IKKE BOMBSITE A");
                return false;
            }
        }
        //DENNE OVER ER GREI.... ?



        public void KillCounterTerrorist(CounterTerrorist ct, bool successfulOrNot)
        {
            Console.WriteLine($"'KillCounterTerrorist()', og '{Name}' kjørte den. Successful?: {successfulOrNot}");
            if (successfulOrNot == true) //vet denne er litt redundant, men har den der for nå før jeg rydder
            {
                ct.IsDead = true;
            }

        }

        //T sin plante bombe metode.
        public void PlantBomb()
        {
            Console.WriteLine($"'PlantBomb()', og '{Name}' kjørte den.");
            Console.WriteLine($"T: {Name} Planting the bomb...");
            int plantCountdown = 5;
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"Time left: {i}");
                Thread.Sleep(1000);
                plantCountdown--;
            }

            if (plantCountdown <= 0)
            {
                Console.WriteLine($"The bomb has been planted.");
                BombIsPlanted = true;
            }

            //Thread.Sleep(5000);

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
                Program.GameIsRunning = false;
            }
        }
    }
}