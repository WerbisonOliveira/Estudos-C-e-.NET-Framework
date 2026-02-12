using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using API_Barber_Shop.Models.Entities;

namespace API_Barber_Shop.Data.Context
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationContext() : base("name=Conexao")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        public DbSet<Barbershop> Barbershops { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<SchedulingService> SchedulingServices { get; set; }
       
    }
}