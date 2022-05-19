using System;

namespace løkker_oppgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var runWhile = 0;
            while (runWhile < 10)
            {
                runWhile++;
                Console.WriteLine("Runde nr"+runWhile);
            }
            
        }
    }
}


/*
 Oppgave 3:

    Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10

    Eks:

    Runde nr 1

    Runde nr 2

    Runde nr 3
 */