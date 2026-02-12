using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Barber_Shop.Models.Enums
{
    public enum StatusScheduling
    {
        Agendado = 1,
        Concluido = 2,
        Cancelado = 3,
        EmAtendimento = 4,
        Ausente = 5,
        Remarcado = 6
    }
}