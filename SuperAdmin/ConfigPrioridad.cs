using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB.SuperAdmin
{
    public class ConfigPrioridad
    {
        // Las propiedades (columnas de SQL Server)
        public int IdPrioridad { get; set; }
        public string NombrePrioridad { get; set; }

        // El constructor (el encargado de armar la caja en la RAM)
        public ConfigPrioridad(int id, string nombre)
        {
            IdPrioridad = id;
            NombrePrioridad = nombre;
        }
    }
}
