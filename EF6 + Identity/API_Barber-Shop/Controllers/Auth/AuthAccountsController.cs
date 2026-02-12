using API_Barber_Shop.Data.Context;
using API_Barber_Shop.DTOs.Login;
using API_Barber_Shop.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace API_Barber_Shop.Controllers.Auth
{
    [RoutePrefix("api/auth")]
    public class AuthAccountsController : ApiController
    {
        private readonly AuthRepository db;
        private readonly ApplicationContext context;
        private readonly UserManager<IdentityUser> userManager;
        public AuthAccountsController()
        {
            db = new AuthRepository();
            context = new ApplicationContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IHttpActionResult> Login(LoginDTO login)
        {
            if (login == null)
                return BadRequest("Preencha os campos login e senha!");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                IdentityUser user = await db.FindUserAsync(login.Login, login.Senha);

                if (user == null)
                    return Content(HttpStatusCode.NotFound, new {message = "Login inválido"});

                var identity = await userManager.CreateIdentityAsync(user, OAuthDefaults.AuthenticationType);

                var roles = await userManager.GetRolesAsync(user.Id);

                identity.AddClaim(new Claim(ClaimTypes.Name, login.Login));

                foreach(var role in roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role));
                }

                var ticket = new AuthenticationTicket(identity, new AuthenticationProperties());

                var token = Startup.OAuthOptions.AccessTokenFormat.Protect(ticket);

                var cookie = new HttpCookie("access_token", token)
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.None,
                    Expires = DateTime.Now.AddDays(1)
                };

                HttpContext.Current.Response.Cookies.Add(cookie);


                return Ok(new {message = "Login realizado com sucesso"});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        [Authorize]
        [Route("logout")]
        public async Task<IHttpActionResult> Logout()
        {
            try
            {
                var cookie = new HttpCookie("access_token")
                {
                    Expires = DateTime.Now.AddDays(-1)
                };

                HttpContext.Current.Response.Cookies.Add(cookie);

                return Ok(new { message = "Logout realizado com sucesso" });
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


        [HttpGet]
        [Authorize]
        [Route("IsAuthenticated")]
        public async Task<IHttpActionResult> IsAuthenticated()
        {
            try
            {
                return Ok(new {auth = true});
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
