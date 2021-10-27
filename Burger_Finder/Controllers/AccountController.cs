using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Burger_Finder.Models;
using System.Data.SqlClient;

namespace Burger_Finder.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand query = new SqlCommand();
        SqlDataReader reader;

        //  Get: Account
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //Azure database connection
        void connectionStr()
        {
            connect.ConnectionString = "Server = tcp:burger-v1.database.windows.net,1433;Initial Catalog = Users; Persist Security Info=False;User ID = Kismazsy; Password=Alabama801; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        }
        

        public ActionResult Verify(Account acc)
        {
            connectionStr();
            connect.Open();
            query.Connection = connect;
            query.CommandText = @"";
            reader = query.ExecuteReader();
            if (reader.Read())
            {
                connect.Close();
                return View();
            }
            else
            {
                connect.Close();
                return View();
            }
            connect.Close();
        }
    }
}
