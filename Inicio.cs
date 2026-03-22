using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB
{
    public partial class Inicio : UserControl
    {
        private TAD_Lista lista; // Esta es la variable global del control

        // Constructor vacío para el Diseñador de Visual Studio
        public Inicio()
        {
            InitializeComponent();
        }

        // Constructor que usas en el FormPrincipalAdmin
        public Inicio(TAD_Lista listaCompartida)
        {
            

             InitializeComponent(); // ¡OBLIGATORIO para que se vea el panel!

             // 1. Guardamos la referencia para que 'actualizarPantalla' la vea
             this.lista = listaCompartida;

             // 2. Instanciamos la conexión y llenamos la lista desde SQL
             Conexion con = new Conexion();
             this.lista.VaciarLista();
             con.LlenarListaDesdeSQL(this.lista);

             // 3. Dibujamos
             actualizarPantalla();
        }

        public void actualizarPantalla()
        {
            // 1. Verificación de seguridad
            if (this.lista == null || pnlContenedorTickets == null) return;

            pnlContenedorTickets.Controls.Clear();

            Nodo aux = this.lista.Inicio;

            // 2. Si la lista está vacía, esto ni siquiera entrará al bucle
            while (aux != null)
            {
                // Creamos la tarjeta con el objeto Ticket que viene del NODO
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);

                // La agregamos al panel
                pnlContenedorTickets.Controls.Add(tarjeta);

                // Avanzamos el puntero al siguiente eslabón
                aux = aux.Siguiente;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
