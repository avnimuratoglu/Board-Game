using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string[] userEntry = new string[2];
            userEntry[0] = txtUserName.Text;
            userEntry[1] = txtPassword.Text;
            try
            {
                FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.ReadWrite);
                StreamWriter entry = new StreamWriter(fs);
                entry.WriteLine(txtUserName.Text);
                entry.Close();
            }
            catch (Exception ex)
            {
                lbl_error2.Text = "No Records Found!";
            }
            if (userEntry[0] == nameUser && userEntry[1] == passUser )
            {

                //flag = false; //user
                this.Hide();
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
                
            }
            if (userEntry[0] == nameAdmin && userEntry[1] == passAdmin)
            {

                this.Hide();
                //flag = true;//admin
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
                
            }
            else
            {
                txtPassword.Text = "";
                lbl_error.Text = "Warning!";
                lbl_error2.Text = "You entered wrong name or password!";
            }
        }


        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                BtnLogin_Click(sender, e);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader entry = new StreamReader(fs);
            txtUserName.Text = entry.ReadLine();
            entry.Close();
        }

        private void btnSıgnIn_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignInScreen signinScreen = new SignInScreen();
            signinScreen.ShowDialog();
        }

        private void chBox_password_CheckedChanged(object sender, EventArgs e)
        {

            if (chBox_password.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
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
