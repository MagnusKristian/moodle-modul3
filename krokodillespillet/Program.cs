using System;

namespace krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            
            string userInput = "_";
            string bigger = ">";
            string smaller = "<";
            string equal = "==";
            int score = 0;
            int whileRuns = 0;
            string stopWord = "exit";

            
            Console.WriteLine("Krokodillespillet!");
            while(whileRuns <100)
            {
                int rndNum1 = rnd.Next(1, 12);
                int rndNum2 = rnd.Next(1, 12);
                
                Console.WriteLine(
                    "Is the number on the right bigger than, smaller than or equal to the number on the left? ");
                Console.WriteLine($" {rndNum1} {userInput} {rndNum2}");
                userInput = Console.ReadLine();
                Console.Clear();
                if(userInput.ToLower() == stopWord){return;}
                //Console.WriteLine($" {rndNum1} {userInput} {rndNum2}");
                if (userInput == bigger && rndNum1 > rndNum2)
                {
                    score++;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {rndNum1} '{userInput}' {rndNum2}                                        ");
                    Console.WriteLine($"Correct! {rndNum1} is bigger than {rndNum2}. Your score is: {score}   ");
                    userInput = "_";
                }
                else if (userInput == smaller && rndNum1 < rndNum2)
                {
                    score++;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {rndNum1} '{userInput}' {rndNum2}                                        ");
                    Console.WriteLine($"Correct! {rndNum1} is smaller than {rndNum2}. Your score is: {score}  ");
                    userInput = "_";
                }
                else if (userInput == equal && rndNum1 == rndNum2)
                {
                    score++;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {rndNum1} '{userInput}' {rndNum2}                                      ");
                    Console.WriteLine($"Correct! {rndNum1} is equal to {rndNum2}. Your score is: {score}  ");
                    userInput = "_";
                }
                else
                {
                    if(score > 0){ score--; }
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" {rndNum1} '{userInput}' {rndNum2}                                        ");
                    Console.WriteLine($"Wrong answer, try again! Your score is: {score}       ");
                    userInput = "_";
                }
                Console.WriteLine("------------------------------------------------");
                Console.ResetColor();
                whileRuns++;
            }


        }
    }
}



/*
 Oppgave: Krokodillespillet
    Du skal bruke det du har lært til å programmere “krokodille spillet”

    For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5

    Brukeren kan skrive inn <, > eller =

    i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

    Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
    Det må verifiseres om brukeren har valgt riktig alternativ.
    Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
    Poengsummen printes til skjermen for hvert svar brukeren har gitt.
    Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
 */