using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace parprog_renee
{
    public class BoardModel
    {
        private static readonly Random _random = new Random();

         public string a1 = " ";
         public string a2 = " ";
         public string a3 = " ";
         public string b1 = " ";
         public string b2 = " ";
         public string b3 = " ";
         public string c1 = " ";
         public string c2 = " ";
         public string c3 = " ";

        internal static void SetRandomCircle(BoardModel brettmodell)
        {
            int randomNumber =_random.Next(1,10);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);

                    if (brettmodell.a1 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.a1 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;

                case 2:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.a2 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.a2 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 3:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.a3 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.a3 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 4:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.b1 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.b1 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 5:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.b2 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.b2 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 6:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.b3 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.b3 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 7:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.c1 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.c1 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 8:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.c2 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.c2 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;
                case 9:
                    Console.WriteLine($"COMPUTER CHOSE: {randomNumber}");
                    Thread.Sleep(1000);
                    if (brettmodell.c3 != " ")
                    {
                        //Console.WriteLine("DENNE RUTEN ER OPPTATT, VELG EN ANNEN!"); //Trengs kun for bruker.
                        SetRandomCircle(brettmodell);
                        return;
                    }
                    brettmodell.c3 = "O";
                    BoardView.ShowBoard(brettmodell);
                    break;

                default:
                    break;
            }

                

        }
    }
}







/*
 



6. Gjør ferdig det som mangler. Man skal bare kunne sette kryss i en tom rute. Programmet skal kjenne igjen om noen har vunnet,
og det skal være mulig å starte på nytt. Bruk løsningsforslaget fra Javascript aktivt - alle problemene er løst der, men det må skrives på en annen måte i C#. 
 */