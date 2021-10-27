using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Device.Location;

namespace Burger_Finder.Controllers
{
    
    public class GeoLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
