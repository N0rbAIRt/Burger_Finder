using Burger_Finder.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Burger_Finder.Services
{
    public class DatabaseService
    {
        string ConnectionString = @"Server = tcp:burger-v1.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = Kismazsy; Password=Alabama801; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        /// <summary>
        /// Searching the LoginModel in the Database where the email and the password is matching.
        /// If there is a record with these creditentials then give back a true value.
        /// If the request has come back with zero rows then give a false value.
        /// </summary>
        /// <param name="acc" type="LoginModel"></param>
        /// <returns>bool value</returns>
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
                connect.Close();
            }
            return success;
        }

        /// <summary>
        /// The given parameters from the AccountModel this function insert all the information to the database.
        /// </summary>
        /// <param name="acc"></param>
        public void createAccount(AccountModel acc)
        {
            string sqlQuery = "INSERT INTO dbo.Users (FirstName, LastName, Phone, Email, Password) VALUES (@fName, @lName, @phone, @email, @password)";

            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add("@fName", System.Data.SqlDbType.VarChar, 40).Value = acc.fName;
                command.Parameters.Add("@lName", System.Data.SqlDbType.VarChar, 40).Value = acc.lName;
                command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar, 40).Value = acc.phone;
                command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 40).Value = acc.email;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = acc.password;
                try
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// The given parameters from the RestaurantModel this function insert all the information to the database.
        /// </summary>
        /// <param name="rest"></param>
        public void createRestaurant(RestaurantModel rest)
        {
            string sqlQuery = "INSERT INTO dbo.Restaurant (Name, Location, Star, Picture, Comment) VALUES (@Name, @Location, @Star, @Picture, @Comment)";

            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 40).Value = rest.Name;
                command.Parameters.Add("@Location", System.Data.SqlDbType.VarChar, 40).Value = rest.Location;
                command.Parameters.Add("@Star", System.Data.SqlDbType.VarChar, 40).Value = rest.Star;
                command.Parameters.Add("@Picture", System.Data.SqlDbType.VarChar, 40).Value = rest.Picture;
                command.Parameters.Add("@Comment", System.Data.SqlDbType.VarChar, 40).Value = rest.Comment;
                try
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
