using System;

namespace returverdi_oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tall1 = 25;
            int tall2 = 5;
            var resultat = returnerSummen(tall1, tall2);
            Console.WriteLine($"Dette er resultatet av metoden: {resultat}");

        }

        public static int returnerSummen(int en, int to)
        {
            int sum = en + to;
            return sum;
        }
    }
}

/*
 Oppgave 1:

    Lag en metode som tar inn og returnerer summen av to tall


 */