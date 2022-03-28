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
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        LoginScreen loginScreen = new LoginScreen();

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginScreen.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            loginScreen.Close();
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingScreen settingScreen = new SettingScreen();
            settingScreen.ShowDialog();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();
            this.Hide();
            gameScreen.ShowDialog();
        }

        private void MenuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginScreen.Close();
            Application.Exit();
        }


    }
}
