using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jenios
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonColor_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "buttonGreen")
                button.BackColor = Color.LightGreen;
            else if (((Button)sender).Name == "buttonRed")
                button.BackColor = Color.LightCoral;
            else if (((Button)sender).Name == "buttonYellow")
                button.BackColor = Color.LightYellow;
            else if (((Button)sender).Name == "buttonBlue")
                button.BackColor = Color.LightBlue;
        }
        private void buttonColor_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "buttonGreen")
                button.BackColor = Color.DarkGreen;
            else if (((Button)sender).Name == "buttonRed")
                button.BackColor = Color.DarkRed;
            else if (((Button)sender).Name == "buttonYellow")
                button.BackColor = Color.DarkGoldenrod;
            else if (((Button)sender).Name == "buttonBlue")
                button.BackColor = Color.DarkBlue;
        }
    }
}
