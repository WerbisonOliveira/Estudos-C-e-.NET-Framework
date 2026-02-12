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
    public class BarbersRepository : IDisposable
    {
        private readonly ApplicationContext db;

        public BarbersRepository()
        {
            db = new ApplicationContext();
        }

        public async Task<IQueryable<Barber>> GetAllAsync()
        {
            return db.Barbers.AsNoTracking();
        }


        public async Task<Barber> GetAsync(int id)
        {
            Barber barber = await db.Barbers.FindAsync(id);

            return barber;
        }


        public async Task CreateAsync(Barber barber)
        {
            Barber newBarber = new Barber()
            {
                Nome = barber.Nome,
                Email = barber.Email,
                Telefone = barber.Telefone,
                Especialidade = barber.Especialidade,
                Status = StatusBarber.Ativo,
                Admissão = DateTime.Now
            };

            db.Barbers.Add(newBarber);
            await db.SaveChangesAsync();
        }


        public async Task<bool> UpdateAsync(Barber barber)
        {
            bool result = db.Barbers.Count(b => b.Id == barber.Id) > 0;

            if (!result)
                return result;

            db.Entry(barber).State = EntityState.Modified;

            await db.SaveChangesAsync();

            return result;
        }


        public async Task<Barber> PatchAsync(UpdateBarberDTO barberDTO)
        {
            Barber barber = await db.Barbers.FindAsync(barberDTO.Id);

            if (barber == null)
                return barber;

            if (barberDTO.Nome != null && barberDTO.Nome != "")
            {
                barber.Nome = barberDTO.Nome;
            }

            if (barberDTO.Email != null && barberDTO.Email != "")
            {
                barber.Email = barberDTO.Email;
            }

            if (barberDTO.Telefone != null && barberDTO.Telefone != "")
            {
                barber.Telefone = barberDTO.Telefone;
            }

            if (barberDTO.Especialidade != null && barberDTO.Especialidade != "")
            {
                barber.Especialidade = barberDTO.Especialidade;              
            }

            if (barberDTO.Status.HasValue)
            {
                barber.Status = barberDTO.Status.Value;
            }

            if (barberDTO.Admissão.HasValue)
            {
                barber.Admissão = barberDTO.Admissão.Value;
            }


            await db.SaveChangesAsync();

            return barber;
        }


        public async Task<Barber> DeleteAsync(int id)
        {
            Barber barber = await db.Barbers.FindAsync(id);

            if (barber == null)
                return barber;

            db.Barbers.Remove(barber);
            await db.SaveChangesAsync();

            return barber;
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}