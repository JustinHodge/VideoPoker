using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPoker
{
    internal class Card
    {
        private int value;
        private string suit;
        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString()
        {
            return this.value.ToString() + " of " + this.suit + "s";
        }
    }
}
