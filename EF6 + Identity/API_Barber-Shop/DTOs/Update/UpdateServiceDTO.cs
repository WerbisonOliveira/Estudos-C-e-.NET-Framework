using API_Barber_Shop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.Update
{
    public class UpdateServiceDTO
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        public Double? Preco { get; set; }

        public StatusServices? Status { get; set; }
    }
}