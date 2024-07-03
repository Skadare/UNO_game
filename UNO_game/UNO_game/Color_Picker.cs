using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNO_game
{
    public partial class Color_Picker : Form
    {
        public Boja selectedColor;
        public Color_Picker()
        {
            InitializeComponent();
            //293; 430
            loadCard();

            

        }

        private void Color_Picker_Load(object sender, EventArgs e)
        {
            //283x396
        }
        public void loadCard() {
            /// za doma kje go sredim
            cardPB.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "wild_color_changer.png"));
        }

        private void cardPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void redPB_Click(object sender, EventArgs e)
        {
            selectedColor = Boja.RED;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
