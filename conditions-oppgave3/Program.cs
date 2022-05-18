using System;

namespace conditions_oppgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Give me a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another");
            int number2 = Convert.ToInt32(Console.ReadLine());
            //returnsTrueIf30ElseFalse(number1,number2);
            Console.WriteLine(returnsTrueIf30ElseFalse(number1,number2));
        }

        private static bool returnsTrueIf30ElseFalse(int num1, int num2)
        {
            int sumOfNum = num1 + num2;
            if (sumOfNum == 30 || num1 == 30 || num2 == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}




/*
 Oppgave 3:

    Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
    skal metoden returnere true. Ellers returnerer metoden false
 */