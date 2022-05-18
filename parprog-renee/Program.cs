using System;

namespace parprog_renee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BoardView.Show();
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