using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.DTOs.BarbersDTO
{
    public class BarberDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
    }
}