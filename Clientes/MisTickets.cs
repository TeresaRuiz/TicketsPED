using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB.Clientes
{
    public partial class MisTickets : UserControl
    {
        HistorialTicket ticket = new HistorialTicket();
        public MisTickets()
        {
            InitializeComponent();
            ConfigurarListView();
            panelActualizar.Visible = false;

            cmbNuevoEstado.Items.Add("Abierto");
            cmbNuevoEstado.Items.Add("En proceso");
            cmbNuevoEstado.Items.Add("Cerrado");
            CargarTickets();
        }

        private void ConfigurarListView()
        {
            lvTickets.View = View.Details;

            lvTickets.FullRowSelect = true;

            lvTickets.GridLines = true;

            // PERMITE EDITAR EL TEXTO
            lvTickets.LabelEdit = true;

            lvTickets.Columns.Add("#", 50);
            lvTickets.Columns.Add("Título", 200);
            lvTickets.Columns.Add("Estado", 120);
            lvTickets.Columns.Add("Prioridad usuario", 150);
            lvTickets.Columns.Add("Prioridad real", 150);
            lvTickets.Columns.Add("Fecha", 150);
        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarTickets()
        {
            ticket.CargarTickets(SesionActual.IdUsuario);

            MostrarTickets(
                ticket.ObtenerTodos());
        }

        private void MostrarTickets(List<Ticket> lista)
        {
            lvTickets.Items.Clear();

            foreach (Ticket t in lista)
            {
                ListViewItem item =
                    new ListViewItem(t.Id);

                item.SubItems.Add(t.Detalle);

                item.SubItems.Add(t.Estado);

                item.SubItems.Add(
                    t.PrioridadUsuario);

                item.SubItems.Add(
                    t.PrioridadReal);

                item.SubItems.Add(
                    t.Fecha.ToString("dd/MM/yyyy"));

                lvTickets.Items.Add(item);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un ticket");

                return;
            }

            string idTicket =
                lvTickets.SelectedItems[0].Text;

            Ticket t =
                ticket.listaTickets.Find(
                    x => x.Id == idTicket);

            if (t != null)
            {
                string detalle =
                    "ID: " + t.Id + "\n\n" +
                    "Usuario: " + t.Usuario + "\n\n" +
                    "Detalle: " + t.Detalle + "\n\n" +
                    "Estado: " + t.Estado + "\n\n" +
                    "Prioridad Usuario: "
                        + t.PrioridadUsuario + "\n\n" +
                    "Prioridad Real: "
                        + t.PrioridadReal + "\n\n" +
                    "Fecha: "
                        + t.Fecha.ToString(
                            "dd/MM/yyyy HH:mm");

                MessageBox.Show(
                    detalle,
                    "Detalle Ticket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
        }

        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un ticket");

                return;
            }

            ListViewItem item =
                lvTickets.SelectedItems[0];

            string estado =
                item.SubItems[2].Text;

            // SI YA ESTÁ CERRADO
            if (estado == "Cerrado")
            {
                MessageBox.Show(
                    "Este ticket ya fue cerrado");

                return;
            }

            // MOSTRAR PANEL
            panelActualizar.Visible = true;

            // CARGAR DATOS ACTUALES
            txtNuevoTitulo.Text =
                item.SubItems[1].Text;

            cmbNuevoEstado.Text =
                item.SubItems[2].Text;
        }

        private void btnFiltroTodos_Click(object sender, EventArgs e)
        {
            MostrarTickets(
           ticket.ObtenerTodos());
        }

        private void btnFiltroAbierto_Click(object sender, EventArgs e)
        {
            MostrarTickets(
           ticket.ObtenerAbiertos());
        }

        private void btnFiltroProceso_Click(object sender, EventArgs e)
        {
            MostrarTickets(
            ticket.ObtenerEnProceso());
        }

        private void btnFiltroCerrado_Click(object sender, EventArgs e)
        {
            MostrarTickets(
        ticket.ObtenerCerrados());
        
        }

        private void lvTickets_DoubleClick(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count > 0)
            {
                lvTickets.SelectedItems[0].BeginEdit();
            }
        }

        private void lvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
                return;

            ListViewItem item =
                lvTickets.SelectedItems[0];

            string estado =
                item.SubItems[2].Text;

            switch (estado)
            {
                case "Abierto":
                    item.SubItems[2].Text =
                        "En proceso";
                    break;

                case "En proceso":
                    item.SubItems[2].Text =
                        "Cerrado";
                    break;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
                return;

            string idTicket =
                lvTickets.SelectedItems[0].Text;

            string nuevoTitulo =
                txtNuevoTitulo.Text;

            string nuevoEstado =
                cmbNuevoEstado.Text;

            int idEstado = 1;

            switch (nuevoEstado)
            {
                case "Abierto":
                    idEstado = 1;
                    break;

                case "En proceso":
                    idEstado = 2;
                    break;

                case "Cerrado":
                    idEstado = 3;
                    break;
            }

            bool actualizado =
                ticket.ActualizarTicket(
                    idTicket,
                    nuevoTitulo,
                    idEstado);

            if (actualizado)
            {
                MessageBox.Show(
                    "Ticket actualizado");

                panelActualizar.Visible = false;

                CargarTickets();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo actualizar");
            }
        }
    }
    
}
