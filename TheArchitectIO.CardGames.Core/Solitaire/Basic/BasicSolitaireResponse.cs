using TheArchitectIO.CardGames.Core.Deck;

namespace TheArchitectIO.CardGames.Core.Solitaire.Basic
{
    public class BasicSolitaireResponse : IBasicSolitaireResponse
    {
        public Card[] Hand { get; set; }
        public Card[] SpadeSlot { get; set; }
        public Card[] ClubSlot { get; set; }
        public Card[] HeartSlot { get; set; }
        public Card[] DiamondSlot { get; set; }
        public Card[] Slot1 { get; set; }
        public Card[] Slot2 { get; set; }
        public Card[] Slot3 { get; set; }
        public Card[] Slot4 { get; set; }
        public Card[] Slot5 { get; set; }
        public Card[] Slot6 { get; set; }
        public Card[] Slot7 { get; set; }
    }
}
