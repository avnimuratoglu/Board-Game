﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;


namespace PreLab1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        static string Encrypt(string value) // string to SHA256
        {
            StringBuilder builder = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding encoding = Encoding.UTF8;
                byte[] result = hash.ComputeHash(encoding.GetBytes(value));

                foreach (Byte b in result)
                    builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.TextLength == 0)
                BtnLogin.Enabled = false;
            else
                BtnLogin.Enabled = true;
        }

        public static bool 
            flag = false; //user or admin
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"users.xml");

            FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.Write);
            StreamWriter entry = new StreamWriter(fs);
            entry.WriteLine(txtUserName.Text);
            entry.Close();
            
            foreach (XmlNode node in xDoc.SelectNodes("//User"))
            {
                string userName = node.SelectSingleNode("UserName").InnerText;
                string password = node.SelectSingleNode("Password").InnerText;

                if(userName == txtUserName.Text && password == Encrypt(txtPassword.Text))
                {
                    this.Hide();
                    if(userName == "admin")
                    {
                        AdminScreen adminScreen = new AdminScreen();
                        adminScreen.Show();
                    }
                    else
                    {
                        MenuScreen menuScreen = new MenuScreen();
                        menuScreen.Show();
                    }
                }
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

            SignupScreen signinScreen = new SignupScreen();
            signinScreen.ShowDialog();
        }

        private void chBox_password_CheckedChanged(object sender, EventArgs e)
        {
            //show password
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
            //press enter key
            if (e.KeyChar == (char)Keys.Enter)
                BtnLogin_Click(sender, e);
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
