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
    public partial class Form1 : Form
    {
        public Form1()
        {
         InitializeComponent();
            loadMenu();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        private void loadMenu()
        {
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.FlatAppearance.BorderSize = 1;
            startButton.FlatAppearance.BorderColor = Color.Blue;         

            htpButton.FlatStyle = FlatStyle.Flat;
            htpButton.FlatAppearance.BorderSize = 1;
            htpButton.FlatAppearance.BorderColor = Color.Yellow;

            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 1;
            exitButton.FlatAppearance.BorderColor = Color.Green;

            Image img  = Image.FromFile(Path.Combine(Application.StartupPath, "Menu", "pozadina.png"));
            MenuPictureBox.BackgroundImage = img;

            pbStart.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Menu", "plava.png"));
            pbExit.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Menu", "zelena.png"));
            pbHTP.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Menu", "zholta.png"));
            startButton.BringToFront();
            exitButton.BringToFront();
            htpButton.BringToFront();


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game form = new Game();
            form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void htpButton_Click(object sender, EventArgs e)
        {
            HTP form = new HTP();
            form.ShowDialog();
        }
    }
}
