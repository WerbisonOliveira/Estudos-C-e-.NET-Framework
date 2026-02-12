using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_Barber_Shop.Data.Identity;
using API_Barber_Shop.Models.Enums;

namespace API_Barber_Shop.Models.Entities
{
    public class Barbershop
    {
        [Key]
        public int Id { get; set; }       

        [Required(ErrorMessage = "O campo Nome é obrigatório."), StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string IdentityUserId { get; set; }

        [ForeignKey("IdentityUserId")]
        public ApplicationUser User { get; set; }

        [StringLength(11)]
        public string Contato { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(150)]
        public string Endereco { get; set; }

        public DiasDaSemana DiasDaSemana { get; set; }

        public TimeSpan Abertura { get; set; }

        public TimeSpan Fechamento { get; set; }
        
    }
}