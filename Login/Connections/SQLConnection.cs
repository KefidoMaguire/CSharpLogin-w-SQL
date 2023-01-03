using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    //What does internal mean: Google: 
    //An internal modifier is used to prevent the use of a public modifier, which allows access to other assemblies wherever necessary.
    //Kann nur innerhalb des Projektes genutzt werden
    internal class SQLConnection
    {
        private SqlConnection connectionStringBuilder()
        {
            try
            {
                SqlConnection conn = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "localhost",
                    InitialCatalog = "Login",
                    IntegratedSecurity = true

                }.ConnectionString
                );
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(),"Could not open SQL Connection");
            }

            return null;
        }

        public string hashPW(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }

        public bool checkUser(string user,string pw,bool register)
        {
            string queryRegister = "INSERT INTO LoginData (LoginName, Password) VALUES ('"+user+"','"+pw+"')";
            string queryLogin = "SELECT COUNT(*) from LoginData where LoginName like '"+user+"' AND Password like '"+pw+"'";
            SqlCommand commandRegister = new SqlCommand(queryRegister, connectionStringBuilder());
            SqlCommand commandLogin = new SqlCommand(queryLogin, connectionStringBuilder());

            if (register == true)
            {
                commandRegister.ExecuteNonQuery();
            }
            else
            {
                int userCount = (int)commandLogin.ExecuteScalar();
                if (userCount > 0) 

                return true;
            }

            return false;
        }

        

    }
}
