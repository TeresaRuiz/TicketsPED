using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class TAD_Cola
    {
        // Punteros principales del Tipo de Dato Abstracto Cola
        public Nodo Frente { get; set; }
        public Nodo Final { get; set; }

        public TAD_Cola()
        {
            Frente = null;
            Final = null;
        }

        public void Enqueue(Ticket nuevoTicket)
        {
            Nodo nuevoNodo = new Nodo(nuevoTicket);

            if (Frente == null)
            {
                Frente = nuevoNodo;
                Final = nuevoNodo;
            }
            else
            {
                Final.Siguiente = nuevoNodo;
                Final = nuevoNodo;         
            }
        }

        public Ticket Dequeue()
        {
            if (Frente == null) return null;

            Ticket datoExtraido = Frente.Dato;
            Frente = Frente.Siguiente;

            if (Frente == null)
            {
                Final = null; 
            }

            return datoExtraido;
        }

        public void VaciarCola()
        {
            Frente = null;
            Final = null;
        }
    }
}
