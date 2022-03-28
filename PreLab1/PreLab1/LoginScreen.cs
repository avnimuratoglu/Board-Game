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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

            if (txtUserName.TextLength == 0)
                BtnLogin.Enabled = false;
            else
                BtnLogin.Enabled = true;
        }

        public string nameAdmin = "admin", nameUser = "user";
        public string passAdmin = "admin", passUser = "user";
        public static bool flag = false; //user or admin
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == nameUser && txtPassword.Text == passUser )
            {
                this.Hide();
                flag = false; //user
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
                
            }
            if (txtUserName.Text == nameAdmin && txtPassword.Text == passAdmin)
            {
                this.Hide();
                flag = true;//admin
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
                
            }
            else
            {
                lbl_error.Text = "Warning!";
                lbl_error2.Text = "You entered wrong name or password!";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                BtnLogin_Click(sender, e);
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
