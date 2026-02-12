using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.Update
{
    public class UpdateBarberDTO
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; }

        [StringLength(150)]
        public string Especialidade { get; set; }

        public StatusBarber? Status { get; set; }

        public DateTime? Admissão { get; set; }

    }
}