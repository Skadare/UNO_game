using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
        }
        public void addCard(Card card)
        {
            cards.Add(card);
        }
        public void removeCard(Card card) { 
        
            cards.Remove(card);
        }

    }
}
