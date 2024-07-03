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
            loadCard();
        }

        private void Color_Picker_Load(object sender, EventArgs e)
        {
        }
        public void loadCard() {
            cardPB.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "wild_color_changer.png"));
            redPB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "red_changer.png"));
            bluePB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "blue_changer.png"));
            yellowPB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "yellow_changer.png"));
            greenPB.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Color_Picker", "green_changer.png"));
        }

        private void cardPictureBox_Click(object sender, EventArgs e)
        {

        }

    

        private void cardPB_Click(object sender, EventArgs e)
        {

        }

  
        private void yellowPB_Click(object sender, EventArgs e)
        {
            selectedColor= Boja.YELLOW;
            this.Close();
        }

        private void bluePB_Click(object sender, EventArgs e)
        {
            selectedColor = Boja.BLUE;
            this.Close();
        }

        private void greenPB_Click(object sender, EventArgs e)
        {
            selectedColor = Boja.GREEN;
            this.Close();
        }

        private void redPB_Click_1(object sender, EventArgs e)
        {
            selectedColor = Boja.RED;
            this.Close();
        }
    }
}
