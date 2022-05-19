using System;
using System.Linq;

namespace passordgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ifNoArgs(args);
            ifTwoArgs(args);
            //KOMMET TIL OPPGAVE 3...........
        }





        private static void ifTwoArgs(string[] args)
        {
            if (args.Length == 2)
            {
                foreach (var c in args[0])
                {
                    var isDigit = char.IsDigit(c);
                    if (!isDigit)
                    {
                        printError();
                    }
                }
            }
        }


        private static void ifNoArgs(string[] args)
        {
            if (args.Length == 0)
            {
                printError();
            }
        }

        private static void printError()
        {
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