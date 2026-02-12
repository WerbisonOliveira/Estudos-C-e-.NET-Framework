using API_Barber_Shop.DTOs.ServicesDTO;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.SchedulingsDTO
{
    public class SchedulingDTO
    {
        public int Id { get; set; }

        public string IdentityUserId { get; set; }

        public int? BarberId { get; set; }

        public string BarberNome { get; set; }

        public ICollection<ServiceDTO> SchedulingServices { get; set; } = new List<ServiceDTO>();

        public DateTime DataeHora { get; set; }

        [StringLength(400)]
        public string Observacoes { get; set; }

        public double ValorTotal { get; set; }

        public StatusScheduling Status { get; set; }
    }
}