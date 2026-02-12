using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace API_Barber_Shop.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string CNPJ { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}