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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string nameAdmin =  "admin", nameUser ="user";
            string passAdmin = "admin", passUser = "user";

            if (txtUserName.Text == nameUser && txtPassword.Text == passUser )
            {
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
                this.Close();
            }
            if (txtUserName.Text == nameAdmin && txtPassword.Text == passAdmin)
            {
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
                this.Close();
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
    }
}
