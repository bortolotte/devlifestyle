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
            buttonTurnOn((Button)sender, true);
        }
        private void buttonColor_MouseUp(object sender, MouseEventArgs e)
        {
            buttonTurnOn((Button)sender, false);
        }

        private void buttonTurnOn(Button button, bool on)
        {
            if (button.Name == "buttonGreen")
                button.BackColor = on ? Color.LightGreen : Color.DarkGreen;
            else if (button.Name == "buttonRed")
                button.BackColor = on ? Color.LightCoral : Color.DarkRed;
            else if (button.Name == "buttonYellow")
                button.BackColor = on ? Color.LightYellow : Color.DarkGoldenrod;
            else if (button.Name == "buttonBlue")
                button.BackColor = on ? Color.LightBlue : Color.DarkBlue;
        }
    }
}
