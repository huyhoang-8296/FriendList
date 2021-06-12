using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlip
{
    class Coin
    {
        // Property
        public bool isHeads { get; set; }

        // constructor for new coin
        public Coin(bool h)
        {
            this.isHeads = h;
        }

        // Method allows us to flip the coin
        public void flipCoin(Random r)
        {
            // randomly choose heads or tails for our coins 
            if (r.Next(10) > 5)
            {
                this.isHeads = true;
            }
            else
            {
                this.isHeads = false;
            }
        }
    }
}
