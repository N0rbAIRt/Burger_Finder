using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Burger_Finder.Models;
using Burger_Finder.Services;
using Microsoft.AspNetCore.Mvc;

namespace Burger_Finder.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult processLogin(LoginModel acc)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.isValid(acc))
            {
                return View("SuccessLogin", acc);
            }
            else
            {
                return View("FailedLogin", acc);
            }
        }
    }
}
