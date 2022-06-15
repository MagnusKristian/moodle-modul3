using System;

namespace CSGO_MAGNUS
{
    class Program
    {

        public static bool GameIsRunning { get; set; } = true;
        static void Main(string[] args)
        {
           
            Teams.MakeTerroristTeam();
            List<Terrorist> terroristTeam = Teams.TeamTerrorists;

            Teams.MakeCounterTerroristTeam();
            List<CounterTerrorist> counterTerroristTeam = Teams.TeamCounterTerrorists;
            //Det over lager players og teams.


            
            GameRunning(terroristTeam, counterTerroristTeam);
            //--------------------------------------------------- Det over skal være, foreløpig.
            //under er for building og debugging.




            //dette går gjennom alle T og printer id'n dems.
            int forlcount = 1;
            foreach (var T in terroristTeam)
            {
                Console.WriteLine($"Name of Terrorist {forlcount}: {T.Name}");
                forlcount++;
            }
            Console.WriteLine(terroristTeam[0].Name);
            Console.WriteLine(terroristTeam[1].Name);
            Console.WriteLine(terroristTeam[2].Name);
            Console.WriteLine(terroristTeam[3].Name);
            Console.WriteLine(terroristTeam[4].Name);


            Console.WriteLine("CT: "+counterTerroristTeam[4].Name);



            //terrorist1.FindBombSite(Player.IsSuccessful(10));
            //terrorist1.PlantBomb();
            
            //terrorist1.KillCounterTerrorist(ctListe[0], Player.IsSuccessful(7));
            
            Console.WriteLine("GAME OVER");
        }
        //stop main.
      






        /*public static void MakeTeams()
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
        }*/



        public static void GameRunning(List<Terrorist> terrorists, List<CounterTerrorist> counterTerrorists)
        {
            int roundCounter = 1;
            while (Program.GameIsRunning)
            {
                Console.WriteLine($"while kjørte {roundCounter} ganger.");
                //T metoder for å kille motstander
                int nextPlayerCT = 0;
                foreach (Terrorist terrorist in terrorists)
                {
                    terrorist.KillCounterTerrorist(counterTerrorists[nextPlayerCT], Player.IsSuccessful(7));
                    Console.WriteLine($"T:'{terrorist.Name}' tries to kill CT:'{counterTerrorists[nextPlayerCT].Name}'. <- this player is dead?: CT:{counterTerrorists[nextPlayerCT].IsDead}");
                    nextPlayerCT++;
                }
                //T prøver å plante bomba.
                foreach (Terrorist terrorist in terrorists)
                {
                    terrorist.FindBombSite(Player.IsSuccessful(10));
                    if (GameIsRunning == false) { return; } //her tenker jeg den er grei å ha.
                }
                /*Ekstra sjekk bare for å være sikker.*/ //if(Player.BombIsPlanted){return;}
                /*Ekstra sjekk bare for å være sikker.*/ if (GameIsRunning == false) { return; }
                //CT metoder for å kille motstander
                int nextPlayerT = 0;
                foreach (CounterTerrorist counterTerrorist in counterTerrorists)
                {

                    counterTerrorist.KillTerrorist(terrorists[nextPlayerT], Player.IsSuccessful(5));
                    Console.WriteLine($"CT:'{counterTerrorist.Name}' tries to kill T:'{terrorists[nextPlayerT].Name}'. <- this player is dead?: T'{terrorists[nextPlayerT].IsDead}'");
                    nextPlayerT++;
                }



                //hvis bomba er planta så skal noen ting endre seg.

                if (Player.BombIsPlanted == true)
                {
                    Player.ChangeSuccessRateCT(3);
                }



                // sjekker om alle t er døde etter bomba er planta.
                if (Player.BombIsPlanted &&
                    terrorists[0].IsDead
                    && terrorists[1].IsDead
                    && terrorists[2].IsDead
                    && terrorists[3].IsDead
                    && terrorists[4].IsDead)
                {
                    //kjøre ct defuse bomb. men kanskje heller legge inn at den gjør dette et annet sted.
                }









                //int killcountCT = 0;
                //foreach (CounterTerrorist counterTerrorist in counterTerrorists)
                //{
                //    bool isDead = counterTerrorist.IsDead;
                //    if(isDead == true) { killcountCT++; }

                //}

                if (counterTerrorists[0].IsDead
                    && counterTerrorists[1].IsDead
                    && counterTerrorists[2].IsDead
                    && counterTerrorists[3].IsDead
                    && counterTerrorists[4].IsDead)
                {
                    Console.WriteLine($"All the CounterTerrorists are dead.");
                    Console.WriteLine($"Terrorists win!");
                    Program.GameIsRunning = false;
                }

                if (terrorists[0].IsDead
                    && terrorists[1].IsDead
                    && terrorists[2].IsDead
                    && terrorists[3].IsDead
                    && terrorists[4].IsDead)
                {
                    Console.WriteLine($"All the Terrorists are dead.");
                    Console.WriteLine($"CounterTerrorists win!");
                    Program.GameIsRunning = false;
                }

                Console.WriteLine($"--------------------------------------------");
                roundCounter++;
            }
        }

    }
}





/*
 Vi skal programmere en konsoll-utgave av CS:GO med terrorists and counterterrorists. 

Et lag består av 5 team-members. Alle spillerene har en property bool IsDead {get; set;} 
Terroristene skal ha en metode bool FindBombSite() som går random mot “A” som bruker metoden IsSuccessful(10) for at de finner A. De har også en metode KillCounterTerrorist(CounterTerrorist ct) som bruker IsSuccessful(7). 
Når A er funnet, skal de kalle på en metode som heter PlantBomb(). Da havner spillet i en tidsmodus som tikker ned inntil bomben er sprengt. (Bruk en For-løkke som teller nedover istedenfor oppover) Det tar 5 tidsenheter å plante bomben og 15 tidsenheter fra den er plantet til den sprenger. 
Når bomben sprenger avsluttes spillet og terroristene vinner kampen. 
Counter-terrorists har en metode som heter DefuseBomb() som bruker 5 tidsenheter på å fullføre. De har også en metode KillTerrorist(Terrorist terrorist) IsSuccessful(5) for å finne en random fra terroristlaget og drepe han. Da settes propertien IsDead =true; 
Print ut til konsollen for hver metode som kalles hva som skjer i spillet.
Når en bombe er plantet øker KillTerrorist() slik at den heller bruker IsSuccessful(3).

-------------- JA

 Alle medlemene må være døde før DefuseBomb() kan kalles. Dersom de rekker å fullføre DefuseBomb() vinner counter-terroristene


Programmet kjører i en While(true) Løkke frem til et av lagene har vunnet, lagene tar tur med å kalle på metodene sine. Terroristene kan alternere mellom FindBombSite og KillCounterTerrorist og CounterTerroristene bruker KillTerrorist().

   public static bool IsSuccessful(int maxValue)

   {

            Random rand = new Random();

            return rand.Next(0, maxValue) == 2;

   }
 */