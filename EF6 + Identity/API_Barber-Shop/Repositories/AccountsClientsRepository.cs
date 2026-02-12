using API_Barber_Shop.Data.Context;
using API_Barber_Shop.Data.Identity;
using API_Barber_Shop.DTOs.Register;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;

namespace API_Barber_Shop.Repositories
{
    public class AccountsClientsRepository : IDisposable
    {
        private readonly ApplicationContext contextDb;
        private readonly UserManager<ApplicationUser> user;
        public AccountsClientsRepository() 
        {
            contextDb = new ApplicationContext();
            user = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(contextDb));
        }

        public async Task<IdentityResult> RegisterAsync(ClientDTO client)
        {
            ApplicationUser newClient = new ApplicationUser()
            {
                UserName = client.Email,
                Email = client.Email,
                Active = true,
                CreatedAt = DateTime.UtcNow
            };

            IdentityResult Result = await user.CreateAsync(newClient, client.Senha);

            await user.AddToRoleAsync(newClient.Id, "Client");
          
            return Result;
        }

        public async Task<ApplicationUser> FindUserAsync(string email, string senha)
        {
            ApplicationUser client = await user.FindAsync(email, senha);

            return client;
        }

        public async Task<ApplicationUser> UpdateUserAsync(string id, string email)
        {
            ApplicationUser client = await user.FindByIdAsync(id);

            if (client == null)
                return client;

            client.UserName = email;
            client.Email = email;

            await user.UpdateAsync(client);
            return client;
        }

        public async Task<ApplicationUser> UpdateUserAsync(string id, bool ativo)
        {
            ApplicationUser client = await user.FindByIdAsync(id);

            if (client == null)
                return client;

            client.Active = ativo;

            await user.UpdateAsync(client);
            return client;
        }

        public async Task<ApplicationUser> UpdatePassWordAsync(string id, string senhaAtual, string senhaNova)
        {
            ApplicationUser client = await user.FindByIdAsync(id);

            if (client == null)
                return client;

            await user.ChangePasswordAsync(id, senhaAtual, senhaNova);

            return client;
        }

        public async Task<ApplicationUser> DeleteUserAsync(string email)
        {
            ApplicationUser client = await user.FindByNameAsync(email);

            if (client == null)
                return client;            

            await user.DeleteAsync(client);

            return client;
        }

        public void Dispose()
        {
            contextDb.Dispose();
            user.Dispose();
        }
    }
}