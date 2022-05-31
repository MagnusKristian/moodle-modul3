using System;

namespace parprog_tomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowHeight = 70;
            var random = new Random();
            var players = new[] { new Player("Per", 10,random), new Player("Pål", 10, random), new Player("Espen", 10, random) };
            //players[0].ShowNameAndPoints();
            //players[1].ShowNameAndPoints();
            //players[2].ShowNameAndPoints();
            // Console.WriteLine("TEST");
            // int tall = 0;
            // while (true)
            // {
            //     
            //     Console.WriteLine(tall);
            //     tall+=20;
            // }
            for (var round = 1; round <= 10; round++)
            {
                Console.WriteLine($"Round {round} ---------------");

                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
                foreach (var player in players)
                {
                    player.ShowNameAndPoints();
                }
                
                //player2.Play(player1);
            }

            //foreach (var player in players)
            //{
            //    player.ShowNameAndPoints();
            //}
            Console.Read();
        }
    }
}
