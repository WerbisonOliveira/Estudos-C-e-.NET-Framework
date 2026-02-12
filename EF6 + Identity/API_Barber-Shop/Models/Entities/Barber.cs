using API_Barber_Shop.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.Models.Entities
{
    public class Barber
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório."), StringLength(100)]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório."), StringLength(11)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Especialidade é obrigatório."), StringLength(150)]
        public string Especialidade { get; set; }

        public StatusBarber Status { get; set; }

        public DateTime Admissão { get; set; }
    }
}