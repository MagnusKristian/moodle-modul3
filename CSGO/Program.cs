using System;
using System.Collections.Generic;

namespace CSGO
{
    class Program
    {
        static void Main(string[] args)
        {

            Teams.LagNyeTerroristerOgListe();

            foreach (var VARIABLE in Teams.terrorlist)
            {
                Console.WriteLine(VARIABLE.IsDead);
            }

            //bool gameRunning = true;
            //MakeTeams();

            /*//T
            var terrorist1 = new Terrorist();
            var terrorist2 = new Terrorist();
            var terrorist3 = new Terrorist();
            var terrorist4 = new Terrorist();
            var terrorist5 = new Terrorist();
            //liste med T: 
            var tListe = new List<Terrorist>();
            tListe.Add(terrorist1);
            tListe.Add(terrorist2);
            tListe.Add(terrorist3);
            tListe.Add(terrorist4);
            tListe.Add(terrorist5);

            //CT
            var counterTerrorist1 = new CounterTerrorist();
            var counterTerrorist2 = new CounterTerrorist();
            var counterTerrorist3 = new CounterTerrorist();
            var counterTerrorist4 = new CounterTerrorist();
            var counterTerrorist5 = new CounterTerrorist();

            //liste med CT:

            var ctListe = new List<CounterTerrorist>();
            ctListe.Add(counterTerrorist1);
            ctListe.Add(counterTerrorist2);
            ctListe.Add(counterTerrorist3);
            ctListe.Add(counterTerrorist4);
            ctListe.Add(counterTerrorist5);

            //------------------------------------------------ fikse det over??----



            //terrorist1.PlantBombs();


            //terrorist1.FindBombSite(Player.IsSuccessful(10));
            terrorist1.PlantBomb();
            //GameRunning(gameRunning);
            terrorist1.KillCounterTerrorist(ctListe[0], Player.IsSuccessful(7));
            */
        }






        public static void MakeTeams()
        {
            //T
            var terrorist1 = new Terrorist();
            var terrorist2 = new Terrorist();
            var terrorist3 = new Terrorist();
            var terrorist4 = new Terrorist();
            var terrorist5 = new Terrorist();
            //liste med T: 
            var tListe = new List<Terrorist>();
            tListe.Add(terrorist1);
            tListe.Add(terrorist2);
            tListe.Add(terrorist3);
            tListe.Add(terrorist4);
            tListe.Add(terrorist5);

            //CT
            var counterTerrorist1 = new CounterTerrorist();
            var counterTerrorist2 = new CounterTerrorist();
            var counterTerrorist3 = new CounterTerrorist();
            var counterTerrorist4 = new CounterTerrorist();
            var counterTerrorist5 = new CounterTerrorist();

            //liste med CT:

            var ctListe = new List<CounterTerrorist>();
            ctListe.Add(counterTerrorist1);
            ctListe.Add(counterTerrorist2);
            ctListe.Add(counterTerrorist3);
            ctListe.Add(counterTerrorist4);
            ctListe.Add(counterTerrorist5);
        }



        public static void GameRunning(bool gameRunning)
        {
            while (gameRunning)
            {


            }
        }

    }
}





/*
 Vi skal programmere en konsoll-utgave av CS:GO med terrorists and counterterrorists. 

Et lag best??r av 5 team-members. Alle spillerene har en property bool IsDead {get; set;} 

Terroristene skal ha en metode bool FindBombSite() som g??r random mot ???A??? som bruker metoden IsSuccessful(10) for at de finner A. De har ogs?? en metode KillCounterTerrorist(CounterTerrorist ct) som bruker IsSuccessful(7). 
N??r A er funnet, skal de kalle p?? en metode som heter PlantBomb(). Da havner spillet i en tidsmodus som tikker ned inntil bomben er sprengt. (Bruk en For-l??kke som teller nedover istedenfor oppover) Det tar 5 tidsenheter ?? plante bomben og 15 tidsenheter fra den er plantet til den sprenger. 
N??r bomben sprenger avsluttes spillet og terroristene vinner kampen. 

Counter-terrorists har en metode som heter DefuseBomb() som bruker 5 tidsenheter p?? ?? fullf??re. De har ogs?? en metode KillTerrorist(Terrorist terrorist) IsSuccessful(5) for ?? finne en random fra terroristlaget og drepe han. Da settes propertien IsDead =true; 
N??r en bombe er plantet ??ker KillTerrorist() slik at den heller bruker IsSuccessful(3). Alle medlemene m?? v??re d??de f??r DefuseBomb() kan kalles. Dersom de rekker ?? fullf??re DefuseBomb() vinner counter-terroristene

Print ut til konsollen for hver metode som kalles hva som skjer i spillet.

Programmet kj??rer i en While(true) L??kke frem til et av lagene har vunnet, lagene tar tur med ?? kalle p?? metodene sine. Terroristene kan alternere mellom FindBombSite og KillCounterTerrorist og CounterTerroristene bruker KillTerrorist().

   public static bool IsSuccessful(int maxValue)

   {

            Random rand = new Random();

            return rand.Next(0, maxValue) == 2;

   }
 */