using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            Dictionary<string, int> cardValues = new Dictionary<string, int>()
            {
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 10},
                {"jack", 10},
                {"queen", 10},
                {"king", 10},
                {"ace", 11}
            };

            List<string> suits = new List<string>(){
                "clubs", "spades", "diamonds", "hearts"
            };

            // Loop through suits and for each suit, loop through the cardValues dictionary and create a card with each item from the dictionary, and add those new cards to the deck1 list
            foreach (string suit in suits)
            {
                foreach (KeyValuePair<string, int> kvp in cardValues)
                {
                    Cards.Add(new Card(kvp.Key, suit, kvp.Value));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for(int i = 0; i < 200; i++)
            {
                int randomIndex = random.Next(0, Cards.Count());
                Card randomCard = Cards[randomIndex];
                Cards.Remove(randomCard);
                Cards.Add(randomCard);
            }
        }

        public void DealCards(Player player, int numCards)
        {
            for(int i = 0; i < numCards; i++)
            {
                player.Cards.Add(Cards[0]);
                Cards.Remove(Cards[0]);
            }
        }
    }
}