using API_Barber_Shop.Data.Context;
using API_Barber_Shop.DTOs.BarbersDTO;
using API_Barber_Shop.DTOs.SchedulingsDTO;
using API_Barber_Shop.DTOs.ServicesDTO;
using API_Barber_Shop.DTOs.Update;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API_Barber_Shop.Repositories
{
    public class SchedulingRepository : IDisposable
    {

        private readonly ApplicationContext db;

        public SchedulingRepository()
        {
            db = new ApplicationContext();
        }

        public async  Task<List<SchedulingDTO>> GetAllAsync()
        {
            return await db.Schedulings.AsNoTracking().Select(s => new SchedulingDTO
            {
                Id = s.Id,
                BarberId = s.Barber.Id,
                BarberNome = s.Barber.Nome,
                DataeHora = s.DataeHora,
                Observacoes = s.Observacoes,
                ValorTotal = s.ValorTotal,
                Status = s.Status,
                SchedulingServices = s.SchedulingServices.Select(ss => new ServiceDTO
                {
                    Id = ss.Service.Id,
                    Nome = ss.Service.Nome,
                    Preco = ss.Service.Preco
                }).ToList()

            }).ToListAsync();
        }


        public async Task<List<SchedulingDTO>> GetSchedulingClient(string IdentityUserId)
        {
            return await db.Schedulings.AsNoTracking().Where(s => s.ClientId == IdentityUserId).Select(s => new SchedulingDTO
            {
                Id = s.Id,
                BarberId = s.Barber.Id,
                BarberNome = s.Barber.Nome,
                DataeHora = s.DataeHora,
                Observacoes = s.Observacoes,
                ValorTotal = s.ValorTotal,
                Status = s.Status,
                SchedulingServices = s.SchedulingServices.Select(ss => new ServiceDTO
                {
                    Id = ss.Service.Id,
                    Nome = ss.Service.Nome,
                    Preco = ss.Service.Preco
                }).ToList()

            }).ToListAsync();
        }

        
        public async Task<SchedulingDTO> GetAsync(int id)
        {
            SchedulingDTO scheduling = db.Schedulings.AsNoTracking().Select(s => new SchedulingDTO
            {
                Id = s.Id,
                BarberId = s.Barber.Id,
                BarberNome = s.Barber.Nome,
                DataeHora = s.DataeHora,
                Observacoes = s.Observacoes,
                ValorTotal = s.ValorTotal,
                Status = s.Status,
                SchedulingServices = s.SchedulingServices.Select(ss => new ServiceDTO
                {
                    Id = ss.Service.Id,
                    Nome = ss.Service.Nome,
                    Preco = ss.Service.Preco
                }).ToList()
            }).FirstOrDefault(s => s.Id == id);


            if (scheduling == null)
                return scheduling;

            return scheduling;
        }


        public async Task<Scheduling> CreateAsync(Scheduling scheduling)
        {
            Scheduling newScheduling = new Scheduling()
            {
                ClientId = scheduling.ClientId,
                BarberId = scheduling.BarberId,
                DataeHora = scheduling.DataeHora,
                Observacoes = scheduling.Observacoes,
                ValorTotal = scheduling.ValorTotal,
                Status = StatusScheduling.Agendado
            };

            var result = db.Schedulings.Add(newScheduling);
            await db.SaveChangesAsync();

            return result;

        }


        public async Task<bool> UpdateAsync(Scheduling scheduling)
        {
            bool result = db.Schedulings.Count(s => s.Id == scheduling.Id) > 0;

            if (!result)
                return result;

            db.Entry(scheduling).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return result;
        }


        public async Task<Scheduling> PatchAsync(UpdateSchedulingDTO schedulingDTO)
        {
            Scheduling scheduling = await db.Schedulings.FindAsync(schedulingDTO.Id);

            var schedulingServices = await db.SchedulingServices.Where(ss => ss.SchedulingId == schedulingDTO.Id).ToListAsync();

            var existingServices = schedulingServices.Select(ss => ss.ServiceId);

            if (scheduling == null)
                return scheduling;

            var newsServices = schedulingDTO.ServicesId.Except(existingServices).Select(id => new SchedulingService
            {
                SchedulingId = schedulingDTO.Id,
                ServiceId = id,
            });


            var removeServices = schedulingServices.Where(ss => !schedulingDTO.ServicesId.Contains(ss.ServiceId));


            scheduling.DataeHora = schedulingDTO.DataeHora.Value;

            scheduling.ValorTotal = schedulingDTO.ValorTotal.Value;

            if (schedulingDTO.BarberId.HasValue)
                scheduling.BarberId = schedulingDTO.BarberId.Value;

            if (schedulingDTO.Observacoes != null && schedulingDTO.Observacoes != "")
                scheduling.Observacoes = schedulingDTO.Observacoes;

            if (schedulingDTO.Status.HasValue)
                scheduling.Status = schedulingDTO.Status.Value;

            db.SchedulingServices.AddRange(newsServices);

            db.SchedulingServices.RemoveRange(removeServices);

            await db.SaveChangesAsync();

            return scheduling;
        }


        public async Task<Scheduling> DeleteAsync(int id)
        {
            Scheduling scheduling = await db.Schedulings.FindAsync(id);
            
            if (scheduling == null) 
                return scheduling;

            db.Schedulings.Remove(scheduling);
            await db.SaveChangesAsync();

            return scheduling;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}