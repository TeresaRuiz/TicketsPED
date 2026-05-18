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
        private TAD_Lista lista;

        public Inicio(TAD_Lista listaCompartida)
        {
            

             InitializeComponent(); 
            this.lista = listaCompartida;

             Conexion con = new Conexion();
             this.lista.VaciarLista();
             con.LlenarListaDesdeSQL(this.lista);

             actualizarPantalla();
        }

        public void actualizarPantalla()
        {
            if (this.lista == null || pnlContenedorTickets == null) return;
            pnlContenedorTickets.Controls.Clear();

            int total = 0, abiertos = 0, proceso = 0, resueltos = 0, alta = 0;
            Nodo aux = this.lista.Inicio;
            Nodo ultimo = null;

            while (aux != null)
            {
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);
                pnlContenedorTickets.Controls.Add(tarjeta);
                total++;
                if (aux.Dato.Estado == "Abierto") abiertos++;
                if (aux.Dato.Estado == "En proceso") proceso++;
                if (aux.Dato.Estado == "Cerrado") resueltos++;
                if (aux.Dato.PrioridadUsuario == "Alta") alta++;
                ultimo = aux;
                aux = aux.Siguiente;
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
