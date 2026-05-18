using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB.SuperAdmin
{
    public class ConfigEstado
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }

        public ConfigEstado(int id, string nombre)
        {
            IdEstado = id;
            NombreEstado = nombre;
        }
    }
}
