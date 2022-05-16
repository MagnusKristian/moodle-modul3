using System;

namespace main_metoden_oppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var VARIABLE in args)
            {
                Console.WriteLine($"Dette er alle argumentene: {VARIABLE}");
            }
            Console.WriteLine($"Dette er hvor mange argumenter det er: {args.Length}");
        }
    }
}


/*
Oppgave 2: 

Send inn et hvilket som helst antall argumenter til mainmetoden,

og print ut et tall som sier noe om hvor mange argumenter du har sendt inn.

Dersom du sender inn "hei på deg" skal tallet 3 printes til konsollen

Koden skal fungere med et ulikt antall argumenter!
 */