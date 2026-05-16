using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class NodoUsuario
    {
        public GestionUsuario Dato { get; set; }
        public NodoUsuario Siguiente { get; set; }

        public NodoUsuario(GestionUsuario dato)
        {
            this.Dato = dato;
            this.Siguiente = null;
        }
    }
}
