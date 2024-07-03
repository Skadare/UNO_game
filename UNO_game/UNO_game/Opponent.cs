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
        public Boja getBestColor()
        {
            int red = 0, green = 0, blue = 0, yellow = 0;
            foreach (Card card in oppCards) {
                if (card.color == Boja.RED) red++;
                if (card.color == Boja.YELLOW) yellow++;
                if (card.color == Boja.BLUE) blue++;
                if (card.color == Boja.GREEN) green++;
            }
            if(red>yellow && red>blue && red>green) return Boja.RED;
            if(green>yellow && green>blue && green>red) return Boja.GREEN;
            if(blue>yellow && blue>green && blue>red) return Boja.BLUE;
            if(yellow>green && yellow>red && yellow>blue) return Boja.YELLOW;   

            return Boja.RED;
        }
    }
}
