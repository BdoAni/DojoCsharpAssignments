using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public Player(string name) 
        {
            this.Name = name;
               
        }
                public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        
// [x] Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.

        public Card Draw(Deck deck)
        {
            Card dealtCard = deck.Deal();

            if (dealtCard != null)
            {
                Hand.Add(dealtCard);
            }
            return dealtCard;
        }
    }
}