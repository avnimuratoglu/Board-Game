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

        public string nameAdmin = "admin", nameUser = "user";
        public string passAdmin = "admin", passUser = "user";
        public static bool flag; //user or admin
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //    if(!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, "^[a-z]"))
            //    {
            //        txtUserName.Text.Remove(txtUserName.Text.Length - 1);
            //    }
            
            if (txtUserName.TextLength == 0)
                BtnLogin.Enabled = false;
            else
                BtnLogin.Enabled = true;

        }

    
         void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == nameUser && txtPassword.Text == passUser )
            {
                this.Hide();
                flag = false; //user
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();

                SettingsUser.Default.entry = false;

            }
            if (txtUserName.Text == nameAdmin && txtPassword.Text == passAdmin)
            {
                this.Hide();
                flag = true;//admin
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();

                SettingsUser.Default.entry = true;
                // SettingsUser.Default.entry = nameAdmin;
            }
            else
            {
                lbl_error.Text = "Warning!";
                lbl_error2.Text = "You entered wrong name or password!";
            }

           
        }


        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

            if (e.KeyChar == (char)Keys.Enter)
                BtnLogin_Click(sender, e);
        }

        private void chk_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Password.Checked)
            {
                txtPassword.PasswordChar = '\0';
                chk_Password.Text = "Gizle";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                chk_Password.Text = "Göster";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            if (SettingsUser.Default.entry == true)
                txtUserName.Text = "admin";
            if (SettingsUser.Default.entry == false)
                txtUserName.Text = "user";

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
