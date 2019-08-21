using System;
using System.Linq;

namespace TheArchitectIO.CardGames.Core.Deck
{
    public static class DeckExtensions
    {
        public static Random random = new Random();
        public static Suit[] SuitsSupported = new[] { Suit.Club, Suit.Heart, Suit.Diamond, Suit.Spade };
        public static CardValue[] CardValuesSupported = new[] { CardValue.Two, CardValue.Three, CardValue.Four, CardValue.Five, CardValue.Six,  CardValue.Seven, CardValue.Eight, CardValue.Nine, CardValue.Ten, CardValue.Jack, CardValue.Queen, CardValue.King, CardValue.Ace, };

        public static Card[] GetBasicDeck()
        {
            return SuitsSupported.SelectMany(
                    suit => CardValuesSupported,
                    (suit, rank) => new Card(suit, rank))
                .ToArray();
        }

        public static void Shuffle(this Card[] deck)
        {
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = random.Next(n + 1);
                Card temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }
    }
}
