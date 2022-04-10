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
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;



namespace PreLab1
{
    public partial class SignupScreen : Form
    {
        public SignupScreen()
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

        private void btn_saveUser_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();

            XDocument xDoc = XDocument.Load(@"users.xml");

            XElement rootElement = xDoc.Root;
            XElement element = new XElement("User",
                  new XElement("UserName", txt_userName.Text),
                  new XElement("Password", Encrypt(txt_password.Text)),
                  new XElement("NameSurname", txt_nameSurname.Text),
                  new XElement("PhoneNumber", txt_phoneNumber.Text),
                  new XElement("Address", txt_address.Text),
                  new XElement("City", txt_city.Text),
                  new XElement("Country", txt_country.Text),
                  new XElement("E-Mail", txt_email.Text));

            rootElement.Add(element);
            xDoc.Save(@"users.xml");

            txt_userName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";

            this.Hide();
            loginScreen.Show();
        }

      
        private void AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
