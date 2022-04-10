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
        public void LoadFile()
        {
            XmlDocument xDoc = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);

            xmlFile.Close();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"users.xml");
            XElement node = xDoc.Element("Users").Elements("User").FirstOrDefault(x => x.Element("UserName").Value == txt_UserName.Text);


            if(Encrypt(txtb_password.Text) == node.Element("Password").Value)
            {
                if (node != null)
                {
                    node.SetElementValue("Password", Encrypt(txt_password.Text));
                    node.SetElementValue("NameSurname", txt_nameSurname.Text);
                    node.SetElementValue("PhoneNumber", txt_phoneNumber.Text);
                    node.SetElementValue("Address", txt_address.Text);
                    node.SetElementValue("City", txt_city.Text);
                    node.SetElementValue("Country", txt_country.Text);
                    node.SetElementValue("E-Mail", txt_email.Text);
                }

                lbl_Info.Text = "UPDATE SUCCESSFUL !!!";
                txt_password.Text = "";
                xDoc.Save(@"users.xml");
                LoadFile();
            }
            else
            {
                txt_password.Text = "";
                txtb_password.Text = "";
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Entry.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter entry = new StreamWriter(fs);

            LoginScreen loginScreen = new LoginScreen();

            XDocument xDoc = XDocument.Load(@"users.xml");
            XElement node = xDoc.Element("Users").Elements("User").FirstOrDefault(x => x.Element("UserName").Value == txt_UserName.Text);

            if (Encrypt(txtb_password.Text) == node.Element("Password").Value)
            {
                xDoc.Root.Elements().Where(x => x.Element("UserName").Value == txt_UserName.Text).Remove();
                lbl_Info.Text = "DELETION SUCCESSFUL !!!";
                txt_password.Text = "";
                txt_UserName.Text = "";
                xDoc.Save(@"users.xml");
                LoadFile();

                entry.WriteLine("");
                entry.Close();
                this.Close();
                loginScreen.Show();

            }
            else
            {
                txt_password.Text = "";
                txtb_password.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
        }
    }
}
