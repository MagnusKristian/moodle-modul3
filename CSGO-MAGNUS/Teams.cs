using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_MAGNUS
{
    internal class Teams
    {


        public static List<Terrorist> TeamTerrorists = new List<Terrorist>();

        public static void MakeTerroristTeam()
        {
            Terrorist T1 = new Terrorist();
            Terrorist T2 = new Terrorist("Kåre");
            Terrorist T3 = new Terrorist("Roger");
            Terrorist T4 = new Terrorist("Arne");
            Terrorist T5 = new Terrorist("Jørgen");


            TeamTerrorists.Add(T1);
            TeamTerrorists.Add(T2);
            TeamTerrorists.Add(T3);
            TeamTerrorists.Add(T4);
            TeamTerrorists.Add(T5);

        }


        public static List<CounterTerrorist> TeamCounterTerrorists = new();

        public static void MakeCounterTerroristTeam()
        {
            CounterTerrorist CT1 = new CounterTerrorist();
            CounterTerrorist CT2 = new CounterTerrorist();
            CounterTerrorist CT3 = new CounterTerrorist();
            CounterTerrorist CT4 = new CounterTerrorist();
            CounterTerrorist CT5 = new CounterTerrorist();

            TeamCounterTerrorists.Add(CT1);
            TeamCounterTerrorists.Add(CT2);
            TeamCounterTerrorists.Add(CT3);
            TeamCounterTerrorists.Add(CT4);
            TeamCounterTerrorists.Add(CT5);

        }



        /*
        //T
        var Teams.terrorist1 = new Terrorist();
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
            */
    }
}