﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = shuffle(deck);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public static Deck shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
