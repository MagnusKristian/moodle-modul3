using System;

namespace objektorientering_tippekupong
{
    public class Match
    {
        private int _homeGoals { get; set; }
        private int _awayGoals { get; set; }
        public string _bet { get; private set; }
        public bool MatchRunning { get; set; }

        public Match(string bet)
        {   

        }

        public bool IsCommandX(string Command)
        {
            if (Command == "X"){return true;}
            return false;
            /* matchIsRunning = command != "X"; */
        }
        public bool IsMatchRunning(bool TrueOrNot, bool isX)
        {
            bool commandToStop = isX;
            MatchRunning = TrueOrNot;
            return MatchRunning;
        }
        public void AddGoal(string command)
        {
            if (command == "H") _homeGoals++;
            else if (command == "B") _awayGoals++;
        }

        public bool IsBetCorrect()
        {
            return false;
        }

        public void Stop()
        {
        }

        public string GetScore()
        {
            return $"Stillingen er {_homeGoals}-{_awayGoals}.";
        }
        public void result(string bet)
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}