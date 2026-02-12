using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.Models.Entities
{
    public class Scheduling
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClientId { get; set; }
        public Client Client { get; set; }

        public int? BarberId { get; set; }
        public Barber Barber { get; set; }

        [Required(ErrorMessage = "O campo Serviços é obrigatório")]
        public ICollection<int> ServicesId { get; set; } = new List<int>();

        public ICollection<SchedulingService> SchedulingServices { get; set; } = new List<SchedulingService>();

        [Required(ErrorMessage = "O campo Data e hora são obrigatórios")]
        public DateTime DataeHora { get; set; }

        [StringLength(400)]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "O campo Valor Total é obrigatório")]
        public double ValorTotal { get; set; }

        public StatusScheduling Status { get; set; }
    }
}