using System;

namespace conditions_oppgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if these numbers are the same: ");
            Console.WriteLine("Input the first number.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool returnTrueOrFalse = ReturnTrueIfEqual(input1,input2);
            if (returnTrueOrFalse == true)
            {
                Console.WriteLine($"The numbers are the same, method returs 'true'");
            }

            if (returnTrueOrFalse == false)
            {
                Console.WriteLine($"The numbers are NOT the same, method returs 'false'");
            }

        }

        private static bool ReturnTrueIfEqual(int number1, int number2)
        {
            if(number1 == number2){
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
    Oppgave 1: 

    Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 
 */