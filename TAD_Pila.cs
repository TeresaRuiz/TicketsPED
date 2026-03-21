using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class TAD_Pila
    {
        // El Tope es el puntero al último ticket que entró (el más reciente)
        public Nodo Tope { get; set; }

        public TAD_Pila()
        {
            Tope = null;
        }

        // Operación PUSH = Meter un cambio a la pila
        public void Push(Ticket nuevoTicket)
        {
            Nodo nuevoNodo = new Nodo(nuevoTicket);

            if (Tope == null)
            {
                Tope = nuevoNodo;
            }
            else
            {
                // El nuevo nodo apunta al que antes era el tope
                nuevoNodo.Siguiente = Tope;
                // Ahora el nuevo nodo es el nuevo tope
                Tope = nuevoNodo;
            }
        }

        // Operación POP = Quitar el de arriba (para el botón Deshacer)
        public Ticket Pop()
        {
            if (Tope == null) return null;

            Ticket datoExtraido = Tope.Dato;
            Tope = Tope.Siguiente; // El de abajo ahora es el nuevo tope
            return datoExtraido;
        }

        public void VaciarPila()
        {
            Tope = null;
        }
    }
}
