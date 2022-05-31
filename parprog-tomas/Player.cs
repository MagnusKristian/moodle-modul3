using System;

namespace parprog_tomas
{
    public class Player
    {
        //properties
        private readonly string _name;

        private int _points;
        private readonly Random _random;

        //constructor
            public Player(string name,int points, Random random)
            {
            _name = name;
            _points = points;
            _random = random;
            }
        //medtheds
            public void Play(Player player2)
        { //skal inneholde en måte å velge en tilfeldig vinner og taper av de som blir trukket. 
            var winner = _random.Next(2) == 0 ? this : player2;
            var loser = winner == this ? player2 : this;
            winner._points += 1;
            loser._points -= 1;
            Console.WriteLine($"PLAYER '{winner._name}' FOUGHT WITH PLAYER '{loser._name}'");
            Console.WriteLine($"PLAYER '{winner._name}' WON.");
        }

        public void ShowNameAndPoints()
            {
            Console.WriteLine(_name.PadRight(12) + _points.ToString().PadLeft(3));
            }
    }
}