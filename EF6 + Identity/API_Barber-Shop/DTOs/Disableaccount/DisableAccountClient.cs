using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.DTOs.Disableaccount
{
    public class DisableAccountClient
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo Ativo é obrigatório")]
        public bool Active { get; set; }
    }
}