using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public List<Card> Cards { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Cards = new List<Card>();
            Score = 1;
        }

        public void PrintCards()
        {
            foreach(Card card in Cards)
            {
                Console.WriteLine($"{card.Name} of {card.Suit}");
            }

            List<int> cardValues = Cards.Select(card => card.Value).ToList();
            int score = cardValues.Sum();
            
            Console.WriteLine($"Score: {score}");
        }
    }
}