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
    public partial class HTP : Form
    {
        public HTP()
        {
            InitializeComponent();
            pb1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "HTP", "How_to_play1.png"));
            pbBack.Image = Image.FromFile(Path.Combine(Application.StartupPath, "HTP", "back3.png"));
            pbBack.BringToFront();
        }

        private void HTP_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
