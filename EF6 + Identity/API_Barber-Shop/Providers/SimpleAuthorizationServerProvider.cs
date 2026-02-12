using API_Barber_Shop.Data.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace API_Barber_Shop.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            ApplicationUser client;

            if (context.UserName.Contains("@"))
                client = await userManager.FindByEmailAsync(context.UserName);
            else
                client = await userManager.Users.FirstOrDefaultAsync(C => C.CNPJ == context.UserName);

            if (client == null || !await userManager.CheckPasswordAsync(client, context.Password)) 
            { 
                context.SetError("invalid_grant", "Usuário ou senha inválidos"); return; 
            }

            var roles = await userManager.GetRolesAsync(client.Id);

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, client.Id));
            identity.AddClaim(new Claim(ClaimTypes.Name, client.UserName));

            foreach (var role in roles)
                identity.AddClaim(new Claim(ClaimTypes.Role, role));

            context.Validated(identity);
        }
    }
}