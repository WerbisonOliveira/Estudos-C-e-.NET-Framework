using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.Register
{
    public class BarbershopDTO
    {
        [Required(ErrorMessage = "O campo CNPJ é obrigatório."), StringLength(14)]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório."), StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(20, MinimumLength = 6)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Confirmar Senha é obrigatório.")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmarSenha { get; set; }

    }
}