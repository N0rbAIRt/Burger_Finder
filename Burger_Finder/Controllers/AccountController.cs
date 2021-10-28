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

        public IActionResult processReg(AccountModel acc)
        {
            DatabaseService insert = new DatabaseService();
            insert.createAccount(acc);
            return View("SuccessReg", acc);
        }
    }
}
