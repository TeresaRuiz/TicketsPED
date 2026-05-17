using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class NodoABB
    {
        public Ticket Dato;
        public NodoABB Izquierdo;
        public NodoABB Derecho;

        public NodoABB(Ticket nuevoTicket)
        {
            Dato = nuevoTicket;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
