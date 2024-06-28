using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public enum TYPE
    {
        NORMAL,
        WILDCARD
    };
    public enum Boja
    {
        RED, GREEN, BLUE, YELLOW, BLACK
    };

    public abstract class Card
    {
        public TYPE type {  get; set; }
        public Boja color { get; set; }
        public String path { get; set; }

        public Card(TYPE type, Boja color, String path)
        {
            this.type = type;
            this.path = path;
            this.color = color;
        }
     
    }
}
