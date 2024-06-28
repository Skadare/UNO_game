using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public class Player
    {
        public List<Card> playerCards {  get; set; }
        public Player() { 
        this.playerCards = new List<Card>();
        }
        public void addCard(Card card)
        {
            playerCards.Add(card);
        }
    }
}
