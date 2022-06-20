using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    internal class BoardView
    {
        public static void Show()
        {
            var brettmodell = new BoardModel();

            RunLoop(brettmodell);
        }

        private static void RunLoop(BoardModel brettmodell)
        {
            while (true)
            {
                ShowBoard(brettmodell);

                string userinput = Console.ReadLine().ToLower();
                ValidUserinput(userinput, brettmodell);
                UpdateBoard(userinput, brettmodell);
                Thread.Sleep(2000);
                BoardModel.SetRandomCircle(brettmodell);
            }
        }

        private static void ValidUserinput(string userinput, BoardModel brettmodell)
        {
            if (userinput != "a1" && userinput != "a2" && userinput != "a3" && userinput != "b1" && userinput != "b2" &&
                userinput != "b3" && userinput != "c1" && userinput != "c2" && userinput != "c3")
            {
                Console.WriteLine("Error, enter a valid input: ");
                Thread.Sleep(2000);
                RunLoop(brettmodell);
            } //lag noe if userinput==noe annet enn det som skal være.
        }


        //ShowBoard(brettmodell);

        //string userinput = Console.ReadLine();
        //UpdateBoard(userinput, brettmodell);

        //Console.WriteLine("X's Turn, Enter something: ");
        //string xInput = Console.ReadLine();
        //Console.WriteLine("O's Turn, Enter something: ");
        //string oInput = Console.ReadLine();

        private static void UpdateBoard(string userinput, BoardModel brettmodell)
        {
            switch (userinput)
            {
                case "a1":
                    Console.WriteLine("YOU CHOSE A1");
                    Thread.Sleep(2000);
                    brettmodell.a1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "a2":
                    Console.WriteLine("YOU CHOSE A2");
                    Thread.Sleep(2000);
                    brettmodell.a2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "a3":
                    Console.WriteLine("YOU CHOSE A3");
                    Thread.Sleep(2000);
                    brettmodell.a3 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b1":
                    Console.WriteLine("YOU CHOSE B1");
                    Thread.Sleep(2000);
                    brettmodell.b1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b2":
                    Console.WriteLine("YOU CHOSE B2");
                    Thread.Sleep(2000);
                    brettmodell.b2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b3":
                    Console.WriteLine("YOU CHOSE B3");
                    Thread.Sleep(2000);
                    brettmodell.b3 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c1":
                    Console.WriteLine("YOU CHOSE C1");
                    Thread.Sleep(2000);
                    brettmodell.c1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c2":
                    Console.WriteLine("YOU CHOSE C2");
                    Thread.Sleep(2000);
                    brettmodell.c2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c3":
                    Console.WriteLine("YOU CHOSE C3");
                    Thread.Sleep(2000);
                    brettmodell.c3 = "X";
                    ShowBoard(brettmodell);
                    break;
                default:
                    break;
            }
        }

        public static void ShowBoard(BoardModel brettmodell)
        {
            Console.Clear();
            Console.WriteLine("SKRIV INN HVOR DU VIL SETTE KRYSS, FEKS \"a1\"");
            Console.WriteLine($"  a b c");
            Console.WriteLine($" ┌─────┐");
            Console.WriteLine($"1│{brettmodell.a1} {brettmodell.b1} {brettmodell.c1}│");
            Console.WriteLine($"2│{brettmodell.a2} {brettmodell.b2} {brettmodell.c2}│");
            Console.WriteLine($"3│{brettmodell.a3} {brettmodell.b3} {brettmodell.c3}│");
            Console.WriteLine($" └─────┘");
        }

    }
}
