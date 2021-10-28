using Burger_Finder.Models;
using Burger_Finder.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burger_Finder.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult saveRestaurant(RestaurantModel rest)
        {
            DatabaseService restDb = new DatabaseService();
            restDb.createRestaurant(rest);
            return View();
        }
    }
}
