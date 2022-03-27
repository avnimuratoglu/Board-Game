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
    public partial class GameScreen : Form
    {
        LoginScreen loginScreen = new LoginScreen();
        MenuScreen menuScreen = new MenuScreen();
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuScreen.Close();
            loginScreen.Close();
            Application.Exit();
        }
    }
}
