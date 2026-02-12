using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.Update
{
    public class UpdateClientDTO
    {
        [Required]
        public string Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string SenhaNova { get; set; }

    }
}