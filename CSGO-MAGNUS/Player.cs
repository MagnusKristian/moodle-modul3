using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_MAGNUS
{
    internal class Player
    {
        public string Name { get; set; } = "Unknown player";
        public bool IsDead { get; set; }
        public static int SuccessRateCT = 5;
        public static int SuccessRateT = 5;
        public static bool BombIsPlanted = false;
        public Guid Id { get; set; }

        public Player()
        {
            Id = Guid.NewGuid();
        }

        public static void ChangeSuccessRateCT(int successRate)
        {
            SuccessRateCT = successRate;

        }

        public static void ChangeSuccessRateT(int successRate)
        {
            SuccessRateT = successRate;
        }

        public static bool IsSuccessful(int maxValue)
        {
            Random rand = new Random();
            return rand.Next(0, maxValue) == 2;
        }
    }



//namespace TodoFullStack.Model
//{
//    public class TodoItem
//    {
//        public Guid Id { get; set; }
//        public string Text { get; set; }
//        public DateTime? Done { get; set; }

//        public TodoItem()
//        {
//            Id = Guid.NewGuid();
//        }
//    }
//}
}
