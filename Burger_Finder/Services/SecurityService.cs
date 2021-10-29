using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Burger_Finder.Models;

namespace Burger_Finder.Services
{
    public class SecurityService
    {
        DatabaseService usersDb = new DatabaseService();

        public SecurityService()
        {
        }

        /// <summary>
        /// Forwarding the LoginModel to the DatabaseService and waiting for the bool value
        /// and then send back the value to the reference. 
        /// </summary>
        /// <param name="acc" type="LoginModel"></param>
        /// <returns>bool value</returns>
        public bool isValid(LoginModel acc)
        {
            return usersDb.findUser(acc);
        }
    }
}
