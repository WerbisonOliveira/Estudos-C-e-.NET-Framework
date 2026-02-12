using API_Barber_Shop.Data.Context;
using API_Barber_Shop.Models.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API_Barber_Shop.Repositories
{
    public class BarbershopRepository : IDisposable
    {
        private readonly ApplicationContext contextDb;

        public BarbershopRepository()
        {
            contextDb = new ApplicationContext();
        }

        public async Task<IQueryable> GetAllAsync()
        {
            return contextDb.Barbershops.AsNoTracking();
        }

        public async Task<Barbershop> GetByIdAsync(int id)
        {
            Barbershop barbershop = await contextDb.Barbershops.FindAsync(id);

            return barbershop;
        }

        public async Task CreateAsync(Barbershop Barbershop)
        {
            contextDb.Barbershops.Add(Barbershop);
            await contextDb.SaveChangesAsync();

        }

        public async Task<bool> UpdateAsync(Barbershop Barbershop)
        {
            bool result = contextDb.Barbershops.Count(c => c.Id == Barbershop.Id) > 0;

            if (!result)
                return result;

            contextDb.Entry(Barbershop).State = EntityState.Modified;
            await contextDb.SaveChangesAsync();

            return result;
        }

        public void Dispose()
        {
            contextDb.Dispose();
        }
    }
}