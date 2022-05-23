using System;
using System.Linq;

namespace passordgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PARAMETER: 14, lLssdd

            int convertedArgument1 = Convert.ToInt32(args[0]);

            //pattern på kommandolinjeparameter.
            string pattern = args[1];
            pattern = pattern.PadRight(convertedArgument1, 'l');
            Console.WriteLine(pattern);


            string password = "";

            foreach (var character in args[1])
            {
                
                switch (character)
                {
                    case 'l':
                        Console.WriteLine("liten 'l'");
                        password += "XXX"+MetodeForl();
                        break;
                    case 'L':
                        Console.WriteLine("Stor 'L'");
                        password += "'L'";
                        break;
                    case 's':
                        Console.WriteLine("'s'");
                        password += "'s'";
                        break;
                    case 'd':
                        Console.WriteLine("'d'");
                        password += "'d'";
                        break;
                }
            }
            Console.WriteLine("Før padding: "+password);
            password = password.PadRight(convertedArgument1+20, 'l');
            Console.WriteLine("Etter padding: "+password);
            //--------------------------------------------------------------

            //HER STARTER KODEN: 
            // 
            //promptForUser(); //Denne printer ut til konsollen "InfoTeksten".

            //isValid(args); // Denne returnerer true/false etter den har sjekka alle metodene som også er enten true eller false.

            //if (isValid(args) == false) // Her sjekker den isValid om den er true eller false og enten printer error og stopper hvis false, hvis true så kjører den KANSKJE resten av koden.
            //{
            //    printError();
            //    Console.WriteLine("Fail...");
            //    return;
            //}

            //KANSKJE BARE KJØRE RESTEN AV KODEN HER??


            //else
            //{
            //    Console.WriteLine("suksess");
            //}

            //Console.WriteLine("slutten av main");
        }
        //---------------------------------------------------------- 


        private static char MetodeForl()
        {
            //if og alt sånt der, vi må finne ut av kode som genererer dette med en random og litt sånt og en string med hele alfabetet og velge random posisjon ut derfra.
            string alphabet = "A B C D E F G H I K L M N O P Q R S T V X Y Z";
            var rand = new Random();
            char randomChar = Convert.ToString(alphabet[rand])
            return 'l';
        }


        private static void promptForUser()
        {
            // HER PRINTES DET INFO TIL BRUKER.
            Console.WriteLine("PasswordGenerator ");
            Console.WriteLine("Options: ");
            Console.WriteLine("-l = lower case letter");
            Console.WriteLine("- L = upper case letter");
            Console.WriteLine("- d = digit");
            Console.WriteLine("- s = special character(!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("Min. 1 lower case");
            Console.WriteLine("Min. 1 upper case");
            Console.WriteLine("Min. 2 special characters");
            Console.WriteLine("Min. 2 digits");
        }

        private static bool isValid(string[] args)
        {
            // Denne metoden sjekker om div metoder er true eller false, og returnerer true hvis alle er true, og false hvis ikke.
            ifNoArgs(args);
            ifTwoArgs(args);
            isArgsCriteriaFulfilled(args);
            if (ifNoArgs(args) == true && ifTwoArgs(args) == true && isArgsCriteriaFulfilled(args) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isArgsCriteriaFulfilled(string[] args)
        {
            //Denne sjekke om kriteriene er fylt eller ikke, dvs om det andre argumentet(args[1]) inneholder disse bokstavene eller ikke.
            //Den returnerer true om alt stemmer, ellers er det false og den kjører print error.
            //(det som er sendt inn med kommandolinjeparameter)
            if (!args[1].Contains("l") || !args[1].Contains("L") || !args[1].Contains("d") || !args[1].Contains("s"))
            {
                printError();
                return false; 
            }
            else
            {
                return true;
            }
        }


        private static bool ifTwoArgs(string[] args)
        {
            //Denne sjekker om det KUN er to argumenter som er sendt med som kommandolinjeparameter. 
            //Hvis det faktisk bare er 2, så går den gjennom hver av "characters" i det første argumentet og ser om det er tall eller ikke, 
            //Hvis det er noe annet enn tall, så kjører den printError metoden og returnerer true eller false avhengig av om det bare er tall eller ikke.
            //Denne sender tilbake true eller false til "isValid" metoden som ser om alle kriteriene er oppfylt. Dette er da ett av flere kriterier.
            if (args.Length == 2)
            {
                foreach (var c in args[0])
                {
                    bool isDigit = char.IsDigit(c);
                    if (!isDigit)
                    {
                        printError();
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }


        private static bool ifNoArgs(string[] args)
        {
            //Denne sjekker om det ikke er noen arugmenter som er sendt med. Hvis ikke det er noen argumenter så kjører den printError og returnerer false,
            //som stopper koden i den andre metoden som mottar verdien fra denne metoden.
            if (args.Length == 0)
            {
                printError();
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void printError()
        {
            //Denne printer errormeldingen.
            Console.Clear();
            Console.WriteLine("PasswordGenerator ");
            Console.WriteLine("Options: ");
            Console.WriteLine("-l = lower case letter");
            Console.WriteLine("- L = upper case letter");
            Console.WriteLine("- d = digit");
            Console.WriteLine("- s = special character(!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("Min. 1 lower case");
            Console.WriteLine("Min. 1 upper case");
            Console.WriteLine("Min. 2 special characters");
            Console.WriteLine("Min. 2 digits");
        }
    }
}





//string input = "hello123world";
//bool isDigitPresent = args[0].Any(c => char.IsDigit(c));
//if (isDigitPresent)
//{

//    //legg koden som skal kjøre her elns
//}
//else
//{
//    ifNoArgs(args);
//}