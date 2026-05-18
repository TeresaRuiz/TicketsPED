using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB.SuperAdmin
{
    public class ConfigPrioridad
    {
        public int IdPrioridad { get; set; }
        public string NombrePrioridad { get; set; }
        public ConfigPrioridad(int id, string nombre)
        {
            IdPrioridad = id;
            NombrePrioridad = nombre;
        }
    }
}
