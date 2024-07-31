using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31072024_CoinTossTieChance_CodersLife
{
    public class Coin
    {
        public bool isHeads { get; set; }
        static Random random = new Random();
        public Coin()
        {            
            isHeads = random.Next(2) == 0;
        }
    }
}
