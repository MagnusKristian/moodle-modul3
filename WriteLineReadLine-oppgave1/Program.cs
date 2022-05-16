using System;

namespace WriteLineReadLine_oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei! Hva heter du?");
            var navn = Console.ReadLine();
            Console.WriteLine("Velkommen "+navn);
        }
    }
}
/*
 Oppgave 1:

    Lag en konsoll-app som skriver til konsollen "Hei, hva heter du?",

    deretter leser inn input fra bruker og til slutt printer ut "Velkommen + det brukeren skrev"

    ex.

    Hei, hva heter du?

    Joakim

    Velkommen Joakim!
 */