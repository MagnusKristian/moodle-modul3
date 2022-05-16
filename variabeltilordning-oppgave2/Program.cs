using System;

namespace variabeltilordning_oppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Her skal vi plusse sammen to tall. Gi meg det første tallet, det skal være heltall: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Og så det andre tallet, det skal være desimaltall: (bruk komma, ikke punktum)");
            string secondNumber = Console.ReadLine();

            int a = Convert.ToInt32(firstNumber);
            double b = Convert.ToDouble(secondNumber);
            var sum = a + b;
            Console.WriteLine("Tallene dine summert er: "+sum);
            Console.WriteLine("Svaret på oppgaven er da: 'sum' må være en double eller en mer nøyaktig datatype.");
        }
    }
}

/*
 Oppgave 2:

    Lag en konsoll-applikasjon som lager 3 variabler. De kan hete a, b og sum. 

    a skal være en int
    b skal være en decimal. 
    Verdiene variablene skal ha er:

    a = 5
    b = 3.0 
    sum er a + b.
    Hva slags type variabel må sum være?
 */