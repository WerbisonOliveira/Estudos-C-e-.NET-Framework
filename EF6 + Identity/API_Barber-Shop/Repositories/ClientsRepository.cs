using API_Barber_Shop.Data.Context;
using API_Barber_Shop.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace API_Barber_Shop.Repositories
{
    public class ClientsRepository : IDisposable
    {
        private readonly ApplicationContext contextDb;
       
        public ClientsRepository() 
        {
            contextDb = new ApplicationContext();
        }

        public async Task<IQueryable> GetAllAsync()
        {
            return contextDb.Clients.AsNoTracking();
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            Client client = await contextDb.Clients.FindAsync(id);

            return client;
        } 

        public async Task CreateAsync(Client client)
        {
            contextDb.Clients.Add(client);
            await contextDb.SaveChangesAsync();
            
        }

        public async Task<bool> UpdateAsync(Client client)
        {
            bool result = contextDb.Clients.Count(c => c.Id == client.Id) > 0;

            if (!result)
                return result;

            contextDb.Entry(client).State = EntityState.Modified;
            await contextDb.SaveChangesAsync();

            return result;
        }

        public void Dispose()
        {
            contextDb.Dispose();
        }
    }
}