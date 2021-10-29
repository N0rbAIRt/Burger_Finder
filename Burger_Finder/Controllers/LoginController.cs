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
        /// <summary>
        /// This function get the (Email and Password) from the "~/Login/Login"
        /// and forward to the SecurityService which will gvie a true or false value.
        /// </summary>
        /// <param name="acc" type="LoginModel"></param>
        /// <returns>View("SuccessLogin"); or return View("FailedLogin");</returns>
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
