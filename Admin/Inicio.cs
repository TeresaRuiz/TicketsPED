using System;
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
        private TAD_Cola cola;

        public Inicio(TAD_Cola colaCompartida) // CAMBIADO: El constructor ahora acepta TAD_Cola
        {
            InitializeComponent();
            this.cola = colaCompartida;

            Conexion con = new Conexion();
            this.cola.VaciarCola();

            // Sincronización de Base de Datos: Poblamos la estructura dinámica desde SQL Server
            // Nota: Asegúrate de que el método en tu clase Conexion se llame así o adáptalo para recibir la cola
            con.LlenarListaDesdeSQL(this.cola);

            actualizarPantalla();
        }

        public void actualizarPantalla()
        {
            if (this.cola == null || pnlContenedorTickets == null) return;
            pnlContenedorTickets.Controls.Clear();

            int total = 0, abiertos = 0, proceso = 0, resueltos = 0, alta = 0;

            Nodo aux = this.cola.Frente;
            Nodo ultimo = null;

            while (aux != null)
            {
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);

               tarjeta.OnVerDetalleClick += (idTicket) =>
                {
                    TicketsMDB.Admin.FormDetalleTicket frmDetalle =
                        new TicketsMDB.Admin.FormDetalleTicket(idTicket, cola); // Pasamos la cola compartida

                    frmDetalle.ShowDialog();
                    actualizarPantalla(); 
                };

                pnlContenedorTickets.Controls.Add(tarjeta);
                total++;

                if (aux.Dato.Estado == "Abierto") abiertos++;
                if (aux.Dato.Estado == "En proceso") proceso++;
                if (aux.Dato.Estado == "Cerrado") resueltos++;
                if (aux.Dato.PrioridadUsuario == "Alta") alta++;

                ultimo = aux; // Guardamos el rastro para conocer cuál es el último de la fila
                aux = aux.Siguiente; // Desplazamiento manual de enlaces
            }

            label2.Text = "Total: " + total.ToString();
            label4.Text = "Abiertos: " + abiertos.ToString();
            label3.Text = "En proceso: " + proceso.ToString();
            label5.Text = "Resueltos: " + resueltos.ToString();
            lblAltaLbl.Text = "Alta prioridad: " + alta.ToString();

             if (ultimo != null)
            {
                lblUltimoId.Text = "#" + ultimo.Dato.Id;
                lblUltimoUsuario.Text = "Usuario: " + ultimo.Dato.Usuario;
                lblUltimoEstado.Text = "Estado: " + ultimo.Dato.Estado;
            }
        }

        private void pnlResumen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
