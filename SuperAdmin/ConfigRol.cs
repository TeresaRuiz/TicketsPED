using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB.SuperAdmin
{
    public class ConfigRol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; } 
        public ConfigRol(int id, string nombre, string descripcion)
        {
            IdRol = id;
            NombreRol = nombre;
            Descripcion = descripcion;
        }
    }
}
