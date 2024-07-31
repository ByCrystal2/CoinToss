using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31072024_CoinTossTieChance_CodersLife
{
    internal class Program
    {
        public const int ITERATION_NUMBER = 1000;
        static void Main(string[] args)
        {
            for (int i = 0; i < ITERATION_NUMBER; i++)
            {
                CoinTossGenerator.StartGame(1000);
                Console.WriteLine($"Yazı sayısı {CoinTossGenerator.HeadCount}\nTura sayısı {CoinTossGenerator.TailCount}");
                CoinTossGenerator.Restart();
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine($"Atılan yazı tura sayısı:{CoinTossGenerator.TotalCoinTossCount}");
            int length = CoinTossGenerator.coinTossHistory.Count;
            for (int i = 0; i < length; i++)
            {
                var history = CoinTossGenerator.coinTossHistory[i];
                Console.WriteLine($"history{i+1} Sonuç => Yazı Sayısı:{history._headCount} --- Tura Sayısı:{history._tailCount}");
                System.Threading.Thread.Sleep(10);
            }
            Console.ReadKey();
        }
    }
}