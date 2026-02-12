using API_Barber_Shop.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Barber_Shop.Models.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório."), StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string IdentityUserId { get; set; }

        [ForeignKey("IdentityUserId")]
        public ApplicationUser User { get; set; }
    }
}