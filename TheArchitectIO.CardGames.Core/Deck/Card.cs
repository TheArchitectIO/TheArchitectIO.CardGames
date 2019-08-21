namespace TheArchitectIO.CardGames.Core.Deck
{
    /// <summary>
    /// Card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Gets the suit.
        /// </summary>
        /// <value>The suit.</value>
        public Suit Suit { get; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public CardValue Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TheArchitectIO.CardGames.Core.Deck.Card"/> class.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TheArchitectIO.CardGames.Core.Deck.Card"/> class.
        /// </summary>
        /// <param name="suit">Suit.</param>
        /// <param name="value">Value.</param>
        public Card(Suit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
