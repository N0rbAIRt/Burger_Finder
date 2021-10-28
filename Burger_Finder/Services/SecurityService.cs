using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Burger_Finder.Models;

namespace Burger_Finder.Services
{
    public class SecurityService
    {
        UsersDbService usersDb = new UsersDbService();

        public SecurityService()
        {
        }

        public bool isValid(LoginModel acc)
        {
            return usersDb.findUser(acc);
        }
    }
}
