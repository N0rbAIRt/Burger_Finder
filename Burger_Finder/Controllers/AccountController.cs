using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Burger_Finder.Models;
using System.Data.SqlClient;
using System.Net.Http;
using Burger_Finder.Models;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using Burger_Finder.Services;

namespace Burger_Finder.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// This function get the Account data (FirstName, LastName, Phone, Email, Password)
        /// from the webpage "~/Account/Register" and forwarding to the database and save there.
        /// After the database insertion done, you get the SuccessReg view and prompted the Login befor continue.
        /// </summary>
        /// <param name="acc" type="AccountModel"></param>
        /// <returns>View("SuccessReg")</returns>
        public IActionResult processReg(AccountModel acc)
        {
            DatabaseService insert = new DatabaseService();
            insert.createAccount(acc);
            return View("SuccessReg", acc);
        }
    }
}
