using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_game
{

    public class CardFactory
    {
        public static Card createCard(string data)
        {

            string[] parts = data.Split('\\');
            string test = parts[parts.Length-1];
            string[] png = test.Split('.');
            string[] karta = png[0].Split('_');
            string color = karta[0].ToUpper();
            if (karta[0].Contains("red") || karta[0].Contains("blue") || karta[0].Contains("yellow") || karta[0].Contains("green"))
            {
                Boja c = Boja.RED;
                if (color.Equals("BLUE"))
                    c = Boja.BLUE;
                else if (color.Equals("GREEN"))
                    c = Boja.GREEN;
                else if (color.Equals("YELLOW"))
                    c = Boja.YELLOW;

                int number = -1;
                bool skip = false;
                bool picker = false;
                bool reverse = false;
                if (karta[1].Equals("skip"))
                    skip = true;
                else if (karta[1].Equals("reverse"))
                    reverse = true;
                else if (karta[1].Equals("picker"))
                    picker = true;
                else
                    number = int.Parse(karta[1]);

                ColorCard card = new ColorCard(TYPE.NORMAL, c, data, number, picker, skip, reverse);
                return card;             

            }
            else
            {
                bool picker_and_changer = false;
                bool change_color = false;
                if (karta[1].Equals("pick"))
                    picker_and_changer = true;
                else
                    change_color = true;

                BlackCard card = new BlackCard(TYPE.WILDCARD, Boja.BLACK,data ,picker_and_changer, change_color);
                return card;

            }
         
        }
    }
}
