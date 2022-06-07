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
using System.Data.SqlClient;
using PreLab1.SqlVariables;


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
            //    XmlDocument xDoc = new XmlDocument();
            //    DataSet ds = new DataSet();
            //    XmlReader xmlFile;
            //    xmlFile = XmlReader.Create(@"users.xml", new XmlReaderSettings());
            //    ds.ReadXml(xmlFile);

            //    xmlFile.Close();

            SQL.connectionUsers.Close();

            SqlCommand commandList = new SqlCommand("Select Username, NameSurname, PhoneNumber, Address, City, Country, eMail, Score from Users_Table", SQL.connectionUsers);
            SQL.CheckConnection(SQL.connectionUsers); // kontrol
        }
        
        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            SQL.connectionUsers.Close();

            txt_UserName.Text = LoginScreen.UserName;
            SQL.CheckConnection(SQL.connectionUsers);
            SqlCommand commandShow = new SqlCommand("Select * from Users_Table where UserName like '" + txt_UserName.Text + "'", SQL.connectionUsers);

            SqlDataReader read = commandShow.ExecuteReader();

            while(read.Read())
            {
                txt_password.Text = read["Password"].ToString();
                txt_nameSurname.Text = read["NameSurname"].ToString();
                txt_phoneNumber.Text = read["PhoneNumber"].ToString();
                txt_address.Text = read["Address"].ToString();
                txt_city.Text = read["City"].ToString();
                txt_country.Text = read["Country"].ToString();
                txt_email.Text = read["eMail"].ToString();
            }

            SQL.connectionUsers.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQL.CheckConnection(SQL.connectionUsers);
            SqlCommand commandUpdate = new SqlCommand("UPDATE Users_Table SET Password=@Password, NameSurname=@NameSurname, PhoneNumber=@PhoneNumber, Address=@Address, City=@City, Country=@Country, eMail=@eMail where UserName=@Username", SQL.connectionUsers);

            if (Encrypt(txtb_password.Text) == Encrypt(LoginScreen.Password))
            {

                commandUpdate.Parameters.AddWithValue("@UserName", txt_UserName.Text);
                commandUpdate.Parameters.AddWithValue("@Password", Encrypt(txt_password.Text));
                commandUpdate.Parameters.AddWithValue("@NameSurname", txt_nameSurname.Text);
                commandUpdate.Parameters.AddWithValue("@PhoneNumber", txt_phoneNumber.Text);
                commandUpdate.Parameters.AddWithValue("@Address", txt_address.Text);
                commandUpdate.Parameters.AddWithValue("@City", txt_city.Text);
                commandUpdate.Parameters.AddWithValue("@Country", txt_country.Text);
                commandUpdate.Parameters.AddWithValue("@eMail", txt_email.Text);

                commandUpdate.ExecuteNonQuery();

            }
            else
                MessageBox.Show("You entered wrong password!", "ERROR", MessageBoxButtons.OK);


            txt_UserName.Text = "";
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
            SQL.connectionUsers.Close();

            var selectedUSerName = txt_UserName.Text;
            SqlCommand commandDelete = new SqlCommand("Delete from Users_Table where UserName = @vUserName", SQL.connectionUsers);
            SQL.CheckConnection(SQL.connectionUsers);
            commandDelete.Parameters.AddWithValue("@vUserName", selectedUSerName);

            commandDelete.ExecuteNonQuery();

            txt_UserName.Text = "";
            txt_password.Text = "";
            txt_nameSurname.Text = "";
            txt_phoneNumber.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_country.Text = "";
            txt_email.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Show();
        }
    }
}
