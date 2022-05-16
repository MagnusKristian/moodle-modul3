using System;

namespace main_metoden_oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] argumenter = args;
            foreach (var VARIABLE in args)
            {
                Console.WriteLine($"Dette logger hvert argument i string array args som man sender inn: {VARIABLE}");
            }
            
        }
    }
}
//HUSK .\ MELLOM NAVNET OG BANEN NÅR DU KJØRER VIA POWERSHELL.

/*
 Oppgave 1: 

    Send inn 5 argumenter til mainmetoden og print de ut til konsollen

    Hint: Console.WriteLine();
 */