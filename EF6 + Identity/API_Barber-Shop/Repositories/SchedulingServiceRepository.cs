using API_Barber_Shop.Data.Context;
using API_Barber_Shop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace API_Barber_Shop.Repositories
{
    public class SchedulingServiceRepository : IDisposable
    {
        private readonly ApplicationContext db;

        public SchedulingServiceRepository()
        {
            db = new ApplicationContext();
        }

        public async Task<IQueryable<SchedulingService>> GetAllAsync()
        {
            return db.SchedulingServices.AsNoTracking();
        }

        public async Task<SchedulingService> GetAsync(int id)
        {
            SchedulingService schedulingService = await db.SchedulingServices.FindAsync(id);

            if (schedulingService == null)
                return schedulingService;

            return schedulingService;
        }

        public async Task Create(SchedulingService scheduling)
        {
            db.SchedulingServices.Add(scheduling);
            await db.SaveChangesAsync();
        }

        public async Task Update()
        {

        }

        public async Task<SchedulingService> Delete(int id)
        {
            SchedulingService schedulingService = await db.SchedulingServices.FindAsync(id);

            if (schedulingService == null)
                return schedulingService;

            db.SchedulingServices.Remove(schedulingService);
            await db.SaveChangesAsync();

            return schedulingService;
        }





        public void Dispose()
        {
            db.Dispose();
        }
    }
}