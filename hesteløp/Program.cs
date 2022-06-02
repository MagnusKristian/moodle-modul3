using System;
using System.Collections.Generic;

namespace hesteløp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var horse1 = new hest("jonas",20);
            var horse2 = new hest("kåre", 15);
            var horse3 = new hest("albert", 30);

            List<hest> stall = new List<hest>();

            stall.Add(horse1);
            stall.Add(horse2);
            stall.Add(horse3);
            Console.WriteLine(stall.Count);

        }

    }
}




/*
 * Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter, feks 20km/h, 30km/h og 35km/h.
 * Du skal kunne mate hesten, stelle med hesten og hesten skal kunne meldes på hesteløp.
 * Under et hesteløp kan man ha en løkke som går frem til en av hestene har vunnet. En hest skal løpe 3 runder rundt travbanen.
 * En runde er 1000km. Om man angir totalt antall km en hest må løpe for å vinne til 3000km,
 * så kan man printe ut hvilken hest som leder for hver runde.
 */