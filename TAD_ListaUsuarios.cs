using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class TAD_ListaUsuarios
    {
        public NodoUsuario Primero;

        public void Insertar(GestionUsuario nuevoUsuario)
        {
            NodoUsuario nuevoNodo = new NodoUsuario(nuevoUsuario);

            if (Primero == null)
            {
                Primero = nuevoNodo;
            }
            else
            {
                NodoUsuario aux = Primero;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevoNodo;
            }
        }

        public void VaciarLista()
        {
            Primero = null;
        }
    }
}
