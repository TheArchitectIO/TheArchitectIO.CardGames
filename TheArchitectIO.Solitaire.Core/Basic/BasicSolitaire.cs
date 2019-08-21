﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheArchitectIO.Solitaire.Core.Deck;

namespace TheArchitectIO.Solitaire.Core.Basic
{
    public class BasicSolitaire : ISolitaire<IBasicSolitaireResponse>
    {
        private int HandSize = 3;

        /// <summary>
        /// Gets or sets the deck.
        /// </summary>
        /// <value>The deck.</value>
        private Queue<Card> Deck { get; set; }

        /// <summary>
        /// Gets or sets the hand.
        /// </summary>
        /// <value>The hand.</value>
        private Queue<Card> Hand { get; set; } = new Queue<Card>();

        /// <summary>
        /// Gets or sets the spade slot.
        /// </summary>
        /// <value>The spade slot.</value>
        private List<Card> SpadeSlot { get; set; } = new List<Card>();

        /// <summary>
        /// Gets or sets the club slot.
        /// </summary>
        /// <value>The club slot.</value>
        private List<Card> ClubSlot { get; set; } = new List<Card>();

        /// <summary>
        /// Gets or sets the heart slot.
        /// </summary>
        /// <value>The heart slot.</value>
        private List<Card> HeartSlot { get; set; } = new List<Card>();

        /// <summary>
        /// Gets or sets the diamond slot.
        /// </summary>
        /// <value>The diamond slot.</value>
        private List<Card> DiamondSlot { get; set; } = new List<Card>();

        private Queue<Card>[] InvisibleSlots { get; set; } = new Queue<Card>[7];

        private List<Card>[] VisibleSlots { get; set; } = new List<Card>[7];

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TheArchitectIO.Solitaire.Core.Basic.BasicSolitaire"/> class.
        /// </summary>
        /// <param name="handSize">Hand size.</param>
        public BasicSolitaire(int handSize = 3)
        {
            HandSize = handSize;
            var deck = DeckExtensions.GetBasicDeck();

            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();

            Deck = new Queue<Card>(deck);

            for(int x = 0; x < 7; x++)
            {
                //init the arrays with empty iEnumerables
                InvisibleSlots[x] = new Queue<Card>();
                VisibleSlots[x] = new List<Card>();
            }

            for (int visibleSlot = VisibleSlots.Count() - 1; visibleSlot > 0; --visibleSlot)
            {
                for (int invisibleSlot = 0; invisibleSlot < visibleSlot - 1; invisibleSlot++)
                {
                    //add one card to the invisible slot
                    InvisibleSlots[invisibleSlot].Enqueue(Deck.Dequeue());
                }

                //add one card to the visible slot
                VisibleSlots[visibleSlot].Add(Deck.Dequeue());
            }

            GetNewHand();
        }

        /// <summary>
        /// Play this game instance.
        /// </summary>
        public void Play()
        {
            List<Card> cardsWithBadMoves = new List<Card>();

            // do we have any visible Aces?
            CheckAces();
        }

        /// <summary>
        /// Play the game async.
        /// </summary>
        /// <returns>The async.</returns>
        public Task PlayAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Status this instance.
        /// </summary>
        /// <returns>The status.</returns>
        public IBasicSolitaireResponse Status()
        {
            IBasicSolitaireResponse output = new BasicSolitaireResponse();

            output.Hand = Hand.ToArray();

            output.ClubSlot = ClubSlot.ToArray();
            output.DiamondSlot = DiamondSlot.ToArray();
            output.HeartSlot = HeartSlot.ToArray();
            output.SpadeSlot = SpadeSlot.ToArray();

            output.Slot1 = VisibleSlots[0].ToArray();
            output.Slot2 = VisibleSlots[1].ToArray();
            output.Slot3 = VisibleSlots[2].ToArray();
            output.Slot4 = VisibleSlots[3].ToArray();
            output.Slot5 = VisibleSlots[4].ToArray();
            output.Slot6 = VisibleSlots[5].ToArray();
            output.Slot7 = VisibleSlots[6].ToArray();

            return output;
        }

        /// <summary>
        /// Statuses the async.
        /// </summary>
        /// <returns>The async.</returns>
        public Task<IBasicSolitaireResponse> StatusAsync()
        {
            IBasicSolitaireResponse output = new BasicSolitaireResponse();

            output.Hand = Hand.ToArray();

            output.ClubSlot = ClubSlot.ToArray();
            output.DiamondSlot = DiamondSlot.ToArray();
            output.HeartSlot = HeartSlot.ToArray();
            output.SpadeSlot = SpadeSlot.ToArray();

            output.Slot1 = VisibleSlots[0].ToArray();
            output.Slot2 = VisibleSlots[1].ToArray();
            output.Slot3 = VisibleSlots[2].ToArray();
            output.Slot4 = VisibleSlots[3].ToArray();
            output.Slot5 = VisibleSlots[4].ToArray();
            output.Slot6 = VisibleSlots[5].ToArray();
            output.Slot7 = VisibleSlots[6].ToArray();


            return Task.FromResult(output);
        }

        /// <summary>
        /// Checks the aces.
        /// </summary>
        private void CheckAces()
        {
            if (Hand.Any() && Hand.Peek().Value == CardValue.Ace)
            {
                //take from hand move to its slot
                MoveCardToEndSlot(Hand.Dequeue());
            }

            foreach(List<Card> visibleSlot in VisibleSlots)
            {
                if (visibleSlot.Any() && visibleSlot.First().Value == CardValue.Ace)
                {
                    //move the cards
                    MoveCardsToEndSlot(visibleSlot.ToArray());

                    //clear out the visible slot
                    visibleSlot.Clear();
                }
            }
        }

        /// <summary>
        /// Moves a card to end slot with no validation
        /// </summary>
        /// <param name="card">Card.</param>
        private void MoveCardToEndSlot(Card card)
        {
            switch (card.Suit)
            {
                case Suit.Club:
                    ClubSlot.Add(card);
                    break;
                case Suit.Diamond:
                    DiamondSlot.Add(card);
                    break;
                case Suit.Heart:
                    HeartSlot.Add(card);
                    break;
                case Suit.Spade:
                    SpadeSlot.Add(card);
                    break;
            }
        }

        /// <summary>
        /// Moves a card to end slot with no validation
        /// </summary>
        /// <param name="cards">Cards.</param>
        private void MoveCardsToEndSlot(Card[] cards)
        {
            switch (cards.First().Suit)
            {
                case Suit.Club:
                    ClubSlot.AddRange(cards);
                    break;
                case Suit.Diamond:
                    DiamondSlot.AddRange(cards);
                    break;
                case Suit.Heart:
                    HeartSlot.AddRange(cards);
                    break;
                case Suit.Spade:
                    SpadeSlot.AddRange(cards);
                    break;
            }
        }

        /// <summary>
        /// Gets a new hand.
        /// </summary>
        private void GetNewHand()
        {
            // take whats in my hand and put it back in the deck
            while (Hand.Count > 0)
            {
                Deck.Enqueue(Hand.Dequeue());
            }

            //get new card(s)
            for (int x = 0; x < HandSize; x++)
            {
                Hand.Enqueue(Deck.Dequeue());
            }
        }

    }
}
