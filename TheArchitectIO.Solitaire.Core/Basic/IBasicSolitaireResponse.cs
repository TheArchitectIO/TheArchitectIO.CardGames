using System;
using TheArchitectIO.Solitaire.Core.Deck;

namespace TheArchitectIO.Solitaire.Core.Basic
{
    public interface IBasicSolitaireResponse
    {
        /// <summary>
        /// Gets or sets the hand.
        /// </summary>
        /// <value>The hand.</value>
        Card[] Hand { get; set; }

        /// <summary>
        /// Gets or sets the spade slot.
        /// </summary>
        /// <value>The spade slot.</value>
        Card[] SpadeSlot { get; set; }

        /// <summary>
        /// Gets or sets the club slot.
        /// </summary>
        /// <value>The club slot.</value>
        Card[] ClubSlot { get; set; }

        /// <summary>
        /// Gets or sets the heart slot.
        /// </summary>
        /// <value>The heart slot.</value>
        Card[] HeartSlot { get; set; }

        /// <summary>
        /// Gets or sets the diamond slot.
        /// </summary>
        /// <value>The diamond slot.</value>
        Card[] DiamondSlot { get; set; }

        /// <summary>
        /// Gets or sets the slot1.
        /// </summary>
        /// <value>The slot1.</value>
        Card[] Slot1 { get; set; }

        /// <summary>
        /// Gets or sets the slot2.
        /// </summary>
        /// <value>The slot2.</value>
        Card[] Slot2 { get; set; }

        /// <summary>
        /// Gets or sets the slot3.
        /// </summary>
        /// <value>The slot3.</value>
        Card[] Slot3 { get; set; }

        /// <summary>
        /// Gets or sets the slot4.
        /// </summary>
        /// <value>The slot4.</value>
        Card[] Slot4 { get; set; }

        /// <summary>
        /// Gets or sets the slot5.
        /// </summary>
        /// <value>The slot5.</value>
        Card[] Slot5 { get; set; }

        /// <summary>
        /// Gets or sets the slot6.
        /// </summary>
        /// <value>The slot6.</value>
        Card[] Slot6 { get; set; }

        /// <summary>
        /// Gets or sets the slot7.
        /// </summary>
        /// <value>The slot7.</value>
        Card[] Slot7 { get; set; }
    }
}
