using TheArchitectIO.CardGames.Core.Deck;

namespace TheArchitectIO.CardGames.Core.Solitaire.Basic
{
    /// <summary>
    /// Class BasicSolitaireResponse.
    /// Implements the <see cref="TheArchitectIO.CardGames.Core.Solitaire.Basic.IBasicSolitaireResponse" />
    /// </summary>
    /// <seealso cref="TheArchitectIO.CardGames.Core.Solitaire.Basic.IBasicSolitaireResponse" />
    public class BasicSolitaireResponse : IBasicSolitaireResponse
    {
        /// <summary>
        /// Gets or sets the hand.
        /// </summary>
        /// <value>The hand.</value>
        public Card[] Hand { get; set; }

        /// <summary>
        /// Gets or sets the spade slot.
        /// </summary>
        /// <value>The spade slot.</value>
        public Card[] SpadeSlot { get; set; }

        /// <summary>
        /// Gets or sets the club slot.
        /// </summary>
        /// <value>The club slot.</value>
        public Card[] ClubSlot { get; set; }

        /// <summary>
        /// Gets or sets the heart slot.
        /// </summary>
        /// <value>The heart slot.</value>
        public Card[] HeartSlot { get; set; }

        /// <summary>
        /// Gets or sets the diamond slot.
        /// </summary>
        /// <value>The diamond slot.</value>
        public Card[] DiamondSlot { get; set; }

        /// <summary>
        /// Gets or sets the slot1.
        /// </summary>
        /// <value>The slot1.</value>
        public Card[] Slot1 { get; set; }

        /// <summary>
        /// Gets or sets the slot2.
        /// </summary>
        /// <value>The slot2.</value>
        public Card[] Slot2 { get; set; }

        /// <summary>
        /// Gets or sets the slot3.
        /// </summary>
        /// <value>The slot3.</value>
        public Card[] Slot3 { get; set; }

        /// <summary>
        /// Gets or sets the slot4.
        /// </summary>
        /// <value>The slot4.</value>
        public Card[] Slot4 { get; set; }

        /// <summary>
        /// Gets or sets the slot5.
        /// </summary>
        /// <value>The slot5.</value>
        public Card[] Slot5 { get; set; }

        /// <summary>
        /// Gets or sets the slot6.
        /// </summary>
        /// <value>The slot6.</value>
        public Card[] Slot6 { get; set; }

        /// <summary>
        /// Gets or sets the slot7.
        /// </summary>
        /// <value>The slot7.</value>
        public Card[] Slot7 { get; set; }
    }
}
