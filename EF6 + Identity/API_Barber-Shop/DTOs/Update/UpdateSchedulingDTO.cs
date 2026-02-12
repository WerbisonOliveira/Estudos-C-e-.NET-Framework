using API_Barber_Shop.DTOs.SchedulingsDTO;
using API_Barber_Shop.Models.Entities;
using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.DTOs.Update
{
    public class UpdateSchedulingDTO
    {
        [Required]
        public int Id { get; set; }

        public int? BarberId { get; set; }
        public Barber Barber { get; set; }

        public ICollection<int> ServicesId { get; set; }

        public DateTime? DataeHora { get; set; }

        [StringLength(400)]
        public string Observacoes { get; set; }

        public double? ValorTotal { get; set; }

        public StatusScheduling? Status { get; set; }
    }
}