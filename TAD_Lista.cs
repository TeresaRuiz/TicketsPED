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
        public void OrdenarPorFechaDescendente()
        {
            if (Inicio == null || Inicio.Siguiente == null) return;

            bool intercambiado;
            do
            {
                intercambiado = false;
                Nodo actual = Inicio;

                while (actual.Siguiente != null)
                {
                    // Si la fecha del actual es MENOR que la del siguiente, los intercambiamos
                    // (así los más recientes/mayores quedan al principio -> Descendente)
                    if (actual.Dato.Fecha < actual.Siguiente.Dato.Fecha)
                    {
                        // Intercambio de la información del Ticket dentro de los nodos
                        Ticket temporal = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temporal;

                        intercambiado = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (intercambiado);
        }
    }
}
