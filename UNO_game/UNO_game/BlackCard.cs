using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{
    public class BlackCard : Card
    {
        public bool picker_and_change {  get; set; }
        public bool change_color {  get; set; }
       
        public BlackCard(TYPE type, Boja color, string path, bool picker_and_change, bool change_color) : base(type, color, path)
        {
            this.picker_and_change = picker_and_change;
            this.change_color = change_color;
        }
    }
}
