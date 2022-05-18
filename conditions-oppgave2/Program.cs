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
            //int returnedNumber = ReturnNumberAddedOrMultiplied(input1, input2);
            int returned = ReturnNumberAddedOrMultiplied(input1,input2);
            Console.WriteLine($"And this is the number thats being returned from the method: {returned}");
            

        }



        private static int ReturnNumberAddedOrMultiplied(int number1, int number2)
        {
            if (number1 != number2)
            {
                int summedNumber = number1 + number2;
                Console.WriteLine($"The numbers are NOT the same, the numbers will be summed and they equal: {summedNumber}");
                return summedNumber;

            }
            else 
            {
                int multipliedNumber = number1 * number2;
                Console.WriteLine($"The numbers are the same, the numbers will be multiplied and they equal: {multipliedNumber}");
                return multipliedNumber;
            }
        }
    }
}


/*
 Oppgave 2: 

    Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 

    og returnerer tallene multiplisert med hverandre dersom de er like
 */