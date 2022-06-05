using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //sql icin kutuphane
using System.Data; // connectionUsers state icin kutuphane


namespace PreLab1.SqlVariables
{
    public class SQL
    {
        //baglanti dizisi
        public static SqlConnection connectionUsers = new SqlConnection("Data Source=DESKTOP-7CH6A9V;Initial Catalog=Users;Integrated Security=True");
        public static SqlConnection connectionLastUser = new SqlConnection("Data Source=DESKTOP-7CH6A9V;Initial Catalog=LastUser;Integrated Security=True");
        public static void deneme()
        {
            connectionUsers.Open();
            //
            //
            //islemler
            //
            //
            connectionUsers.Close();
        }

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
                tempConnection.Open();
        }
    }

   
}
