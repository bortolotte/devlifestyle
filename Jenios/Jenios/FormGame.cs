using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Jenios
{
    public partial class FormGame : Form
    {
        private Timer timer;
        private int countdown;
        private String originalButtonText;

        public FormGame()
        {
            InitializeComponent();
            timer = new Timer();
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            originalButtonText = button.Text;

            countdown = trackBarSpeed.Value;
            buttonStart.Text = countdown.ToString();
            timer.Stop();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += buttonTurnOn;
        }

        private void buttonTurnOn(object sender, EventArgs e)
        {
            countdown--;
            if(countdown < 0)
            {
                timer.Stop();
                timer.Tick -= buttonTurnOn;
                buttonStart.Text = originalButtonText;
            }
            else
                buttonStart.Text = countdown == 0 ? "Booom!" : countdown.ToString();
        }
    }
}
