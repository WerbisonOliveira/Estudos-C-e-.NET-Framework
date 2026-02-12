using API_Barber_Shop.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.Models.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório."), StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        public Double Preco { get; set; }

        public StatusServices Status { get; set; }

    }
}