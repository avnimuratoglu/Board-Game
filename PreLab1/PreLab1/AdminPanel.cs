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
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Password"].Visible = false;

            xmlFile.Close();

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            //girilen kullanici adina gore guncelleme.,,,
            XDocument xDoc = XDocument.Load(@"users.xml");
            XElement node = xDoc.Element("Users").Elements("User").FirstOrDefault(x => x.Element("UserName").Value == txt_UserName.Text);

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

            txt_UserName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";

        }

        private void btn_AddUser_Click_1(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();

            XDocument xDoc = XDocument.Load(@"users.xml");
            xDoc.Element("Users").Add(
                new XElement("User",
                  new XElement("UserName", txt_UserName.Text),
                  new XElement("Password", Encrypt(txt_password.Text)),
                  new XElement("NameSurname", txt_nameSurname.Text),
                  new XElement("PhoneNumber", txt_phoneNumber.Text),
                  new XElement("Address", txt_address.Text),
                  new XElement("City", txt_city.Text),
                  new XElement("Country", txt_country.Text),
                  new XElement("E-Mail", txt_email.Text)));

            xDoc.Save(@"users.xml");
            LoadFile();

            txt_UserName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {

            //girilen kullanici adina gore silme
            XDocument xDoc = XDocument.Load(@"users.xml");
            xDoc.Root.Elements().Where(x => x.Element("UserName").Value == txt_UserName.Text).Remove();
            xDoc.Save(@"users.xml");
            LoadFile();

            txt_UserName.Text = "";
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_UserName.Text = row.Cells[0].Value.ToString();
                //txt_password.Text = row.Cells[1].Value.ToString();
                txt_nameSurname.Text = row.Cells[2].Value.ToString();
                txt_phoneNumber.Text = row.Cells[3].Value.ToString();
                txt_address.Text = row.Cells[4].Value.ToString();
                txt_city.Text = row.Cells[5].Value.ToString();
                txt_country.Text = row.Cells[6].Value.ToString();
                txt_email.Text = row.Cells[7].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
