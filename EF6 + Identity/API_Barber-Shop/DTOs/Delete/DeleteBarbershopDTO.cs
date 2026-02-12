using System.ComponentModel.DataAnnotations;

namespace API_Barber_Shop.DTOs.Delete
{
    public class DeleteBarbershopDTO
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string CNPJ { get; set; }
    }
}