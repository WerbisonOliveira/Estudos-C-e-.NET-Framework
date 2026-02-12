using API_Barber_Shop.Data.Context;
using API_Barber_Shop.Data.Identity;
using API_Barber_Shop.DTOs.Register;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;

namespace API_Barber_Shop.Repositories
{
    public class AccountsBarbershopsRepository : IDisposable
    {
        private readonly ApplicationContext contextDb;
        private readonly UserManager<ApplicationUser> user;
        public AccountsBarbershopsRepository()
        {
            contextDb = new ApplicationContext();
            user = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(contextDb));
        }

        public async Task<IdentityResult> RegisterAsync(BarbershopDTO Barbershop)
        {
            ApplicationUser newBarbershop = new ApplicationUser()
            {
                UserName = Barbershop.CNPJ,
                CNPJ = Barbershop.CNPJ,
                Active = true,
                CreatedAt = DateTime.UtcNow
            };

            IdentityResult Result = await user.CreateAsync(newBarbershop, Barbershop.Senha);

            await user.AddToRoleAsync(newBarbershop.Id, "Admin");

            return Result;
        }

        public async Task<ApplicationUser> FindBarbershopAsync(string cnpj, string senha)
        {
            ApplicationUser Barbershop = await user.FindAsync(cnpj, senha);

            return Barbershop;
        }

        public async Task<ApplicationUser> UpdateBarbershopAsync(string id, string cnpj)
        {
            ApplicationUser Barbershop = await user.FindByIdAsync(id);

            if (Barbershop == null)
                return Barbershop;

            Barbershop.UserName = cnpj;
            Barbershop.CNPJ = cnpj;

            await user.UpdateAsync(Barbershop);
            return Barbershop;
        }

        public async Task<ApplicationUser> UpdateBarbershopAsync(string id, bool ativo)
        {
            ApplicationUser Barbershop = await user.FindByIdAsync(id);

            if (Barbershop == null)
                return Barbershop;

            Barbershop.Active = ativo;

            await user.UpdateAsync(Barbershop);
            return Barbershop;
        }

        public async Task<ApplicationUser> UpdatePassWordAsync(string id, string senhaAtual, string senhaNova)
        {
            ApplicationUser Barbershop = await user.FindByIdAsync(id);

            if (Barbershop == null)
                return Barbershop;

            await user.ChangePasswordAsync(id, senhaAtual, senhaNova);

            return Barbershop;
        }

        public async Task<ApplicationUser> DeleteBarbershopAsync(string cnpj)
        {
            ApplicationUser Barbershop = await user.FindByNameAsync(cnpj);

            if (Barbershop == null)
                return Barbershop;

            await user.DeleteAsync(Barbershop);

            return Barbershop;
        }

        public void Dispose()
        {
            contextDb.Dispose();
            user.Dispose();
        }
    }
}