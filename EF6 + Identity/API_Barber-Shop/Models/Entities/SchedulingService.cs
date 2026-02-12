using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.Models.Entities
{
    public class SchedulingService
    {
        [Key]
        public int Id { get; set; }

        public int SchedulingId { get; set; }
        public Scheduling Scheduling { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}