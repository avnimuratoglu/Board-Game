using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.IO;


namespace PreLab1
{
    public partial class ProfileScreen : Form
    {
        public ProfileScreen()
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
        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"users.xml");

            FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader entry = new StreamReader(fs);
            string UserName = entry.ReadLine();
            entry.Close();

            foreach (XmlNode node in xDoc.SelectNodes("//User"))
            {
                if( node["UserName"].InnerText == UserName )
                {
                    txt_UserName.Text = node["UserName"].InnerText;
                    txt_password.Text = "";
                    txt_nameSurname.Text = node["NameSurname"].InnerText;
                    txt_phoneNumber.Text = node["PhoneNumber"].InnerText;
                    txt_address.Text = node["Address"].InnerText;
                    txt_city.Text = node["City"].InnerText;
                    txt_country.Text = node["Country"].InnerText;
                    txt_email.Text = node["E-Mail"].InnerText;
                }
            }
        }
    }
}
