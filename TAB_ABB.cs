using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class TAD_ABB
    {
        public NodoABB Raiz { get; set; }

        public TAD_ABB()
        {
            Raiz = null;
        }

        public void VaciarArbol()
        {
            Raiz = null;
        }

        // Método público para insertar un ticket ordenado por su ID numérico
        public void Insertar(Ticket nuevoTicket)
        {
            Raiz = InsertarRecursivo(Raiz, nuevoTicket);
        }

        private NodoABB InsertarRecursivo(NodoABB actual, Ticket nuevoTicket)
        {
            if (actual == null)
            {
                return new NodoABB(nuevoTicket);
            }

            int idActual = int.Parse(actual.Dato.Id);
            int idNuevo = int.Parse(nuevoTicket.Id);

            // Si es menor, se va a la izquierda. Si es mayor o igual, a la derecha.
            if (idNuevo < idActual)
            {
                actual.Izquierdo = InsertarRecursivo(actual.Izquierdo, nuevoTicket);
            }
            else if (idNuevo > idActual)
            {
                actual.Derecho = InsertarRecursivo(actual.Derecho, nuevoTicket);
            }

            return actual;
        }

        // Método público de búsqueda O(log n) hecha manualmente
        public Ticket Buscar(int idBuscado)
        {
            return BuscarRecursivo(Raiz, idBuscado);
        }

        private Ticket BuscarRecursivo(NodoABB actual, int idBuscado)
        {
            if (actual == null) return null;

            int idActual = int.Parse(actual.Dato.Id);

            if (idBuscado == idActual)
            {
                return actual.Dato; // ¡Encontrado!
            }

            // Decisión jerárquica del ABB
            if (idBuscado < idActual)
            {
                return BuscarRecursivo(actual.Izquierdo, idBuscado);
            }
            else
            {
                return BuscarRecursivo(actual.Derecho, idBuscado);
            }
        }
    }
}
