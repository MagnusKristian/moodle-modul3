using System;

namespace organTransplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personBernt = new Person("Bernt",30,1);
            Console.WriteLine(personBernt.Name);
            Console.WriteLine(personBernt);

        }
    }
    
}

/*
MiniOppgave: Organ transplant!
    Det har vært en akutt ulykke og Bernt ligger på sykehuset.

    Han trenger en ny Nyre!

        Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!

    Hjelp Bernt med å overleve!

        Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.

    Lag gjerne Consoll.WriteLine() -statements i koden slik at man ser hva som skjer!
*/