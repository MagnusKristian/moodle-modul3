using System;

namespace WebShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");
                
                string userInput = Console.ReadLine();
                HandleCommand(userInput);
            }

        }

        private static void HandleCommand(string _userInput)
        {

            if (_userInput != "1" && _userInput != "2" && _userInput != "3")
            {
                Console.WriteLine("Error, enter: 1 / 2 / 3 ");
            }
            else
            {
                return;
            }

        }
    }
}
