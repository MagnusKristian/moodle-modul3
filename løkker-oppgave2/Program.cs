using System;

namespace løkker_oppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Setning";
            foreach (char chr in str)
            {
                Console.WriteLine(chr);
            }
            Console.WriteLine("Hello World!");
        }
    }
}


/*
 Oppgave 2:

    Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen

    Hint: en string kan brukes på samme måte som et array!
 */