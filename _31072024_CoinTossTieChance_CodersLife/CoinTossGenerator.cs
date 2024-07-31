using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31072024_CoinTossTieChance_CodersLife
{
    public static class CoinTossGenerator
    {
        public static List<(int _headCount, int _tailCount)> coinTossHistory = new List<(int _headCount, int _tailCount)>();
        public static int HeadCount { get; set; }
        public static int TailCount { get; set; }
        public static int TotalCoinTossCount { get; set; }
        public static void StartGame(int _howMuch)
        {
            for (int i = 0; i < _howMuch; i++)
            {
                Coin coin = new Coin();
                if (coin.isHeads)
                    HeadCount++;
                else
                    TailCount++;
                TotalCoinTossCount++;
            }
            Console.WriteLine("Oyun sonlandı.");
            coinTossHistory.Add((HeadCount, TailCount));
        }
        public static void Restart()
        {
            HeadCount = 0;
            TailCount = 0;
        }
    }
}
