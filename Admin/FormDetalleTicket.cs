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
        private TAD_Cola colaCompartida;
        private Ticket ticketActual = null;

        public FormDetalleTicket(string id, TAD_Cola cola) 
        {
            InitializeComponent();
            this.ticketId = id;
            this.colaCompartida = cola;
            BuscarTicketEnCola();
            CargarDatos();
            MarcarComoEnProcesoAutomatico();
        }


        private void BuscarTicketEnCola()
        {
            if (colaCompartida == null) return;
             Nodo aux = colaCompartida.Frente;
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

        private void EliminarDeCola(string id)
        {
            if (colaCompartida == null || colaCompartida.Frente == null) return;

            
            if (colaCompartida.Frente.Dato.Id == id)
            {
                colaCompartida.Dequeue();
                return;
            }

            Nodo prev = colaCompartida.Frente;
            Nodo actual = colaCompartida.Frente.Siguiente;

            while (actual != null)
            {
                if (actual.Dato.Id == id)
                {
                    prev.Siguiente = actual.Siguiente; 

                   if (actual == colaCompartida.Final)
                    {
                        colaCompartida.Final = prev;
                    }
                    return;
                }
                prev = actual;
                actual = actual.Siguiente;
            }
        }

        private void btnPriorizar_Click(object sender, EventArgs e)
        {
            if (ticketActual == null || colaCompartida == null || colaCompartida.Frente == null) return;

            if (colaCompartida.Frente.Dato.Id == ticketActual.Id)
            {
                MessageBox.Show("Este ticket ya está al inicio de la cola de atención.", "Priorizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nodo prev = null;
            Nodo actual = colaCompartida.Frente;
            while (actual != null && actual.Dato.Id != ticketActual.Id)
            {
                prev = actual;
                actual = actual.Siguiente;
            }

            if (actual == null) return;

            if (prev != null)
                prev.Siguiente = actual.Siguiente;

            if (actual == colaCompartida.Final)
            {
                colaCompartida.Final = prev;
            }
            actual.Siguiente = colaCompartida.Frente;
            colaCompartida.Frente = actual;

            MessageBox.Show($"Ticket #{ticketActual.Id} movido al frente de la cola de atención.", "Priorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Remoción dynamic manual aplicada sobre la Cola en memoria RAM
            EliminarDeCola(ticketActual.Id);

            MessageBox.Show($"Ticket #{ticketActual.Id} cerrado correctamente.", "Ticket cerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}