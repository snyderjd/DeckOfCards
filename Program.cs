using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();

            // Print out all the cards
            // foreach(Card card in deck1.Cards)
            // {
            //     Console.WriteLine($"{card.Name} of {card.Suit} has a value of {card.Value}");
            // }

            // Make a new player
            Player player1 = new Player();

            Console.WriteLine("===== Deal 2 Cards to player1 =====");

            // Deal 2 cards to player1
            player1.PrintCards();

            Console.WriteLine($"Remaining Cards {deck1.Cards.Count}");

            deck1.DealCards(player1, 2);
            player1.PrintCards();

            Console.WriteLine($"Remaining Cards {deck1.Cards.Count}");

        }
    }
}
