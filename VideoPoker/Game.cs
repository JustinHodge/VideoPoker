using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPoker
{
    internal class Game
    {
        private Player player;
        private Deck deck;

        public Game()
        {
            player = new Player();
            deck = new Deck();
            Console.ReadLine();
        }

        public Card drawFromDeck()
        {
            // function Not Implemented
            return null;
        }
    }
}
