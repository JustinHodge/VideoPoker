using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPoker
{
    internal class Deck
    {
        private List<Card> listOfCards;
        private List<string> possibleSuits;
        private List<int> possibleValues;
        public Deck()
        {
            possibleSuits = new List<string>
                { "Club", "Diamond", "Spade", "Heart"};
            possibleValues = new List<int>
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            listOfCards = getInitialListOfCards();
            Console.ReadLine();
        }

        private List<Card> getInitialListOfCards()
        {
            listOfCards = new List<Card>();

            for (int i = 0; i < possibleSuits.Count; i++)
            {
                for (int j = 0; j < possibleValues.Count; j++)
                {
                    listOfCards.Add(new Card(possibleSuits[i], possibleValues[j]));
                }
            }

            return listOfCards;
        }
    }
}
