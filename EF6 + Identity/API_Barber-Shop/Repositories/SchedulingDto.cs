using API_Barber_Shop.DTOs.ServicesDTO;
using System.Collections.Generic;

namespace API_Barber_Shop.Repositories
{
    internal class SchedulingDto
    {
        public int Id { get; set; }
        public object DateTime { get; set; }
        public List<ServiceDTO> Services { get; set; }
    }
}