using API_Barber_Shop.Data.Context;
using API_Barber_Shop.DTOs.Login;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace API_Barber_Shop.Repositories
{
    public class AuthRepository : IDisposable
    {
        private readonly ApplicationContext db;
        private readonly UserManager<IdentityUser> userManager;

        public AuthRepository()
        {
            db = new ApplicationContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(db));
        }

        public async Task<IdentityUser> FindUserAsync(string Username, string password)
        {
            IdentityUser user = await userManager.FindAsync(Username, password);

            return user;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}