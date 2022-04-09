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
using System.IO;
using System.Security.Cryptography;


namespace PreLab1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        static string Encrypt (string value) // SHA256
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

        void LoadFile()
        {
            XmlDocument xDoc = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView_adminP.DataSource = ds.Tables[0];
            dataGridView_adminP.Columns["Password"].Visible = false;

            xmlFile.Close();

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

      
         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"users.xml");
            xDoc.Element("Users").Add(
                new XElement("User",
                  new XElement("UserName", txt_userName.Text),
                  new XElement("Password", Encrypt(txt_password.Text)),
                  new XElement("NameSurname", txt_nameSurname.Text),
                  new XElement("PhoneNumber", txt_phoneNumber.Text),
                  new XElement("Address", txt_address.Text),
                  new XElement("City", txt_city.Text),
                  new XElement("Country", txt_country.Text),
                  new XElement("E-Mail", txt_email.Text)));

            xDoc.Save(@"users.xml");
            LoadFile();

            txt_userName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //girilen kullanici adina gore guncelleme.,,,
            XDocument xDoc = XDocument.Load(@"users.xml");
            XElement node = xDoc.Element("Users").Elements("User").FirstOrDefault(x => x.Element("UserName").Value == txt_userName.Text);

            if (node != null)
            {
                node.SetElementValue("Password", Encrypt(txt_password.Text));
                node.SetElementValue("NameSurname", txt_nameSurname.Text);
                node.SetElementValue("PhoneNumber", txt_phoneNumber.Text);
                node.SetElementValue("Address", txt_address.Text);
                node.SetElementValue("City", txt_city.Text);
                node.SetElementValue("Country", txt_country.Text);
                node.SetElementValue("E-Mail", txt_email.Text);

                xDoc.Save(@"users.xml");
                LoadFile();
            }

            txt_userName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //girilen kullanici adina gore silme
            XDocument xDoc = XDocument.Load(@"users.xml");
            xDoc.Root.Elements().Where(x => x.Element("UserName").Value == txt_userName.Text).Remove();
            xDoc.Save(@"users.xml");
            LoadFile();

            txt_userName.Text = "";
        }
        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }
        
    }
}
