using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB.Admin
{
    public partial class FormDetalleTicket : Form
    {
        private string ticketId;
        private Conexion con = new Conexion();
        private TAD_Lista listaCompartida;
        private Ticket ticketActual = null;

        public FormDetalleTicket(string id, TAD_Lista lista)
        {
            InitializeComponent();
            this.ticketId = id;
            this.listaCompartida = lista;
            BuscarTicketEnLista();
            CargarDatos();
            MarcarComoEnProcesoAutomatico();
        }

        private void BuscarTicketEnLista()
        {
            if (listaCompartida == null) return;
            Nodo aux = listaCompartida.Inicio;
            while (aux != null)
            {
                if (aux.Dato.Id == ticketId)
                {
                    ticketActual = aux.Dato;
                    break;
                }
                aux = aux.Siguiente;
            }
        }

        private void CargarDatos()
        {
            DataTable dt = con.ObtenerDetalleCompleto(int.Parse(ticketId));
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblID.Text = "TICKET #" + row["IdTicket"];
                lblUsuario.Text = "Solicitante: " + row["Usuario"];
                lblEstado.Text = "Estado actual: " + row["NombreEstado"];
                txtDescripcion.Text = row["Descripcion"].ToString();
            }
            dgvComentarios.DataSource = con.ObtenerComentarios(int.Parse(ticketId));
        }

        private void MarcarComoEnProcesoAutomatico()
        {
            // Requisito: Si se abre desde 'Atender Siguiente' y está Abierto, pasa a 'En proceso' de inmediato
            if (ticketActual != null && ticketActual.Estado == "Abierto")
            {
                con.CambiarEstadoTicket(int.Parse(ticketId), 2);

                ticketActual.Estado = "En proceso";
                CargarDatos();
            }
        }

        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoComentario.Text)) return;

            if (con.AgregarComentario(int.Parse(ticketId), 1, txtNuevoComentario.Text))
            {
                txtNuevoComentario.Clear();
                CargarDatos();
            }
        }

      
      



        private void EliminarDeLista(string id)
        {
            if (listaCompartida == null || listaCompartida.Inicio == null) return;

            if (listaCompartida.Inicio.Dato.Id == id)
            {
                listaCompartida.Inicio = listaCompartida.Inicio.Siguiente;
                return;
            }

            Nodo prev = listaCompartida.Inicio;
            Nodo actual = listaCompartida.Inicio.Siguiente;

            while (actual != null)
            {
                if (actual.Dato.Id == id)
                {
                    prev.Siguiente = actual.Siguiente;
                    return;
                }
                prev = actual;
                actual = actual.Siguiente;
            }
        }

        private void btnPriorizar_Click(object sender, EventArgs e)
        {
            if (ticketActual == null) return;

            if (listaCompartida.Inicio != null && listaCompartida.Inicio.Dato.Id == ticketActual.Id)
            {
                MessageBox.Show("Este ticket ya está al inicio de la cola.", "Priorizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nodo prev = null;
            Nodo actual = listaCompartida.Inicio;

            while (actual != null && actual.Dato.Id != ticketActual.Id)
            {
                prev = actual;
                actual = actual.Siguiente;
            }

            if (actual == null) return;

            if (prev != null)
                prev.Siguiente = actual.Siguiente;

            actual.Siguiente = listaCompartida.Inicio;
            listaCompartida.Inicio = actual;

            MessageBox.Show($"Ticket #{ticketActual.Id} movido al inicio de la cola.", "Priorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void btnTomarTicket_Click(object sender, EventArgs e)
        {
            if (ticketActual == null) return;

            if (ticketActual.Estado == "Cerrado")
            {
                MessageBox.Show("Este ticket ya está cerrado.", "Ticket cerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"¿Tomar el ticket #{ticketActual.Id}?\nQuedarás como responsable.", "Tomar ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (con.AsignarResponsable(int.Parse(ticketActual.Id), ticketActual.Responsable))
            {
                MessageBox.Show($"Ticket #{ticketActual.Id} asignado correctamente.", "Ticket tomado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            if (ticketActual == null) return;

            var confirm = MessageBox.Show(
                $"¿Cerrar el ticket #{ticketActual.Id}?\nSe retirará de la cola de trabajo.",
                "Cerrar ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            con.CambiarEstadoTicket(int.Parse(ticketActual.Id), 3);

            EliminarDeLista(ticketActual.Id);

            MessageBox.Show(
                $"Ticket #{ticketActual.Id} cerrado correctamente.",
                "Ticket cerrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}