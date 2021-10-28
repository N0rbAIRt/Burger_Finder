using Burger_Finder.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Burger_Finder.Services
{
    public class UsersDbService
    {
        string ConnectionString = @"Server = tcp:burger-v1.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = Kismazsy; Password=Alabama801; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        public bool findUser(LoginModel acc)
        {
            bool success = false;


            string sqlQuery = "Select * FROM dbo.Users WHERE Email = @Email AND Password = @Password";

            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar, 40).Value = acc.email;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 40).Value = acc.password;
                try
                {
                    connect.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return success;
        }
    }
}
