using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public class Opponent
    {
        public List<Card> oppCards {  get; set; }
        public Opponent()
        {
            oppCards = new List<Card>();
        }
        public void addCard(Card card)
        {
            oppCards.Add(card);
        }
    }
}
