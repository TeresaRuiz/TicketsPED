using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class Nodo
    {
        public Ticket Dato;   // La información del ticket
        public Nodo Siguiente; // El puntero al siguiente nodo

        public Nodo(Ticket nuevoTicket)
        {
            Dato = nuevoTicket;
            Siguiente = null; // Al crear un nodo, apunta a la nada por defecto
        }
    }
}
