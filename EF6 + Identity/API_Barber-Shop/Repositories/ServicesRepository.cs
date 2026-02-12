using API_Barber_Shop.Data.Context;
using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API_Barber_Shop.Repositories
{
    public class ServicesRepository : IDisposable
    {
        private ApplicationContext db;

        public ServicesRepository()
        {
            db = new ApplicationContext();
        }

        public async Task<IQueryable<Service>> GetAllAsync()
        {
            return db.Services.AsNoTracking();
        }

        public async Task<Service> GetAsync(int id)
        {
            Service service = await db.Services.FindAsync(id);

            return service;
        }

        public async Task CreateAsync(Service service)
        {
            Service newService = new Service() 
            {
                Nome = service.Nome,
                Descricao = service.Descricao,
                Preco = service.Preco,
                Status = StatusServices.Ativo
            };

            db.Services.Add(newService);
            await db.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Service service)
        {
            bool result = db.Services.Count(s => s.Id == service.Id) > 0;

            if (!result)
                return result;

            db.Entry(service).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return result;
        }

        public async Task<Service> PatchAsync(UpdateServiceDTO serviceDTO)
        {
            Service service = await db.Services.FindAsync(serviceDTO.Id);

            if (service == null)
                return service;

            if (serviceDTO.Nome != null && serviceDTO.Nome != "")
                 service.Nome = serviceDTO.Nome;

            if (serviceDTO.Descricao != null && serviceDTO.Descricao != "")
                 service.Descricao = serviceDTO.Descricao;        

            if (serviceDTO.Preco.HasValue)
                 service.Preco = serviceDTO.Preco.Value;          

            if (serviceDTO.Status.HasValue)
                 service.Status = serviceDTO.Status.Value;
            

            await db.SaveChangesAsync();

            return service;
        }

        public async Task<Service> DeleteAsync(int id)
        {
            Service service = await db.Services.FindAsync(id);

            if (service == null)
                return service;

            db.Services.Remove(service);
            await db.SaveChangesAsync();

            return service;
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}