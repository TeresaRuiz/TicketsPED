using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class TAD_Lista
    {
        // El puntero inicial de la lista
        public Nodo Inicio = null;

        // Método para insertar al final 
        public void Insertar(Ticket nuevoTicket)
        {
            Nodo nuevoNodo = new Nodo(nuevoTicket);

            if (Inicio == null)
            {
                Inicio = nuevoNodo;
            }
            else
            {
                Nodo aux = Inicio;
                // Recorremos hasta llegar al último nodo
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                // Conectamos el último nodo con el nuevo
                aux.Siguiente = nuevoNodo;
            }
        }

        // Método para vaciar la lista 
        public void VaciarLista()
        {
            Inicio = null;
        }
    }
}
