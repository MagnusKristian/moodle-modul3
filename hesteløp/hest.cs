using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesteløp
{
    internal class hest
    {
        public string name { get; set; }
        public int speed { get; set; }


        public hest(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public void FeedHorse()
        {
            Console.WriteLine($"The horse '{name}' has been fed.");
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