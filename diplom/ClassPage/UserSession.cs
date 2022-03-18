using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace diplom.ClassPage
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static int UserExp { get; set; }
        public static string UserName { get; set; } 
        public static string UserLogin { get; set; }
        public static string UserSurname { get; set; }
        public static string ProfilePicture { get; set; }

        public static bool IsUserEnter = false;

        public static void GetUserInfo(TextBox login)
        {
            IsUserEnter = true;
            UserLogin = login.Text;
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=localhost;Initial Catalog=hit;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, Name, Surname, Login, Exp FROM Profile WHERE Login = '"+UserLogin+"'", sqlConnection);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    UserId = rdr.GetInt32(0);
                    UserName = rdr.GetString(1);
                    UserSurname = rdr.GetString(2);
                    UserExp = rdr.GetInt32(4);

                }
            }
            sqlConnection.Close();
        }

    }
}
