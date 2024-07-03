using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public class ColorCard : Card
    {
        public int number;
        public bool picker;
        public bool skip;
        public bool reverse;

        public ColorCard(TYPE type, Boja color, string path, int number, bool picker, bool skip, bool reverse) : base(type, color, path)
        {
            this.number = number;
            this.picker = picker;
            this.skip = skip;
            this.reverse = reverse; 
        }
    }
}
