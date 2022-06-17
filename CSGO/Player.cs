using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Player
    {
        public bool IsDead { get; set; }
        public int SuccessRate = 5;

        public static bool IsSuccessful(int maxValue)
        {
            Random rand = new Random();
            return rand.Next(0, maxValue) == 2;
        }
    }
}