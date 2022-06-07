using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab1
{
    public partial class ControlScreen : Form
    {
        public ControlScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            MultiplayerScreen multiplayerScreen = new MultiplayerScreen(false, textBox1.Text);
            Visible = false;

            if (!multiplayerScreen.IsDisposed)
                multiplayerScreen.ShowDialog();

            Visible = true;
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            MultiplayerScreen multiplayerScreen = new MultiplayerScreen(true);
            Visible = false;

            if (!multiplayerScreen.IsDisposed)
                multiplayerScreen.ShowDialog();

            Visible = true;
        }

        private void ControlScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
        }

    }
}
