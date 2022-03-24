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

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Hide();
            loginScreen.ShowDialog();
            this.Close();


        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingScreen settingScreen = new SettingScreen();
            settingScreen.ShowDialog();
            this.Close(); // giris ekranini saklamak icin

        }

        //private void MenuScreen_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if(MessageBox.Show("Application will be closed!","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
    }
}
