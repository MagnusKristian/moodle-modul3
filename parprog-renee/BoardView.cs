using System;
using System.Threading;

namespace parprog_renee
{
    public class BoardView
    {
        public static void Show()
        {
            var brettmodell = new BoardModel();

            GameRunning(brettmodell);
        }



        private static void GameRunning(BoardModel brettmodell)
        {
            while (true)
            {
                ShowBoard(brettmodell);

                string userinput = Console.ReadLine();
                UpdateBoard(userinput, brettmodell);
                Thread.Sleep(2000);
                BoardModel.SetRandomCircle(brettmodell);
            }
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
                    brettmodell.a1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "a2":
                    Console.WriteLine("YOU CHOSE A2");
                    brettmodell.a2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "a3":
                    Console.WriteLine("YOU CHOSE A3");
                    brettmodell.a3 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b1":
                    Console.WriteLine("YOU CHOSE B1");
                    brettmodell.b1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b2":
                    Console.WriteLine("YOU CHOSE B2");
                    brettmodell.b2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "b3":
                    Console.WriteLine("YOU CHOSE B3");
                    brettmodell.b3 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c1":
                    Console.WriteLine("YOU CHOSE C1");
                    brettmodell.c1 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c2":
                    Console.WriteLine("YOU CHOSE C2");
                    brettmodell.c2 = "X";
                    ShowBoard(brettmodell);
                    break;
                case "c3":
                    Console.WriteLine("YOU CHOSE C3");
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









/*
 1. Lag en klasse BoardView med en static metode Show(), som viser det hardkodede brettet under. (Kopier gjerne tegnene direkte fra eksempelet under.) Kall så denne fra Main() i Program.
  a b c
 ┌─────┐
1│o    │
2│    o│
3│× ×  │
 └─────┘
2. Lag så en klasse BoardModel slik at et objekt av denne kan inneholde informasjon om hvilke ruter som er tomme, hvilke som har kryss og sirkel i seg. 

3. Endre så metoden Show i BoardView, slik at den tar et objekt av BoardModel som parameter og viser frem innholdet dynamisk. Altså samme brett som før,
men kryss der modell-objekter sier det er kryss - og tilsvarende for sirkler. Lag et test-objekt av BoardModel som inneholder både noen sirkler og noen kryss. 

4. Endre koden i Main til dette og få det til å virke, slik at man kan sette kryss der man vil ved å skrive en bokstav for kolonne og et siffer for rad.
var boardModel = new BoardModel();
while (true)
{
    BoardView.Show(boardModel);
    Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
    var position = Console.ReadLine();
    boardModel.SetCross(position);
}


5. Legg til koden under i slutten av while-løkken og lag metoden SetRandomCircle i BoardModel slik at den setter en sirkel en tilfeldig valgt rute.
Thread.Sleep(2000);
boardModel.SetRandomCircle();

For å få til det lager du en objektvariabel private readonly Random _random = new Random(); i klassen BoardModel.
Med den kan du få et tilfeldig tall som er min. f.eks. 5 og maks. 15 slik: var randomNumber = _random.Next(5, 15);

6. Gjør ferdig det som mangler. Man skal bare kunne sette kryss i en tom rute. Programmet skal kjenne igjen om noen har vunnet,
og det skal være mulig å starte på nytt. Bruk løsningsforslaget fra Javascript aktivt - alle problemene er løst der, men det må skrives på en annen måte i C#. 
 */