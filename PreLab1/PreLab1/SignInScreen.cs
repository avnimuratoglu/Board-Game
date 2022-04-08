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


namespace PreLab1
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();

            //StringWriter writer = new StringWriter();
            //XmlTextWriter file = new XmlTextWriter(writer);
            //file.Formatting = Formatting.Indented;
            //file.WriteStartDocument();

            //file.WriteStartElement("Users");
            //file.WriteStartElement("User", "ID", "0");
            //file.WriteEndElement();
            //file.WriteEndElement();
            //file.Close();
        }

       

        private void btn_saveUser_Click(object sender, EventArgs e)
        {
            int id = new int();
            id = 0;
            
            XDocument xDoc = XDocument.Load(@"users.xml");

            XElement rootElement = xDoc.Root;
            XElement element = new XElement("User",
                  new XElement("UserName", txt_userName.Text),
                  new XElement("Password", txt_password.Text),
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
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            //XmlTextWriter xmlTextWriter = new XmlTextWriter(@"users.xml", Encoding.UTF8);
            //xmlTextWriter.Formatting = Formatting.Indented;
            //xmlTextWriter.WriteStartDocument();
            //xmlTextWriter.WriteStartElement("Users");
            //xmlTextWriter.WriteEndElement();
            //xmlTextWriter.Close();
        }
        private void AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
