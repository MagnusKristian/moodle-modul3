using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    internal class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public void Play(Player opponentPlayer)
        {
            Points++;
            opponentPlayer.Points--;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Name: {Name}, Points: {Points}.");
        }
    }
}
