using System;
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
    public partial class FormDashboard : UserControl
    {
        public FormDashboard()
        {
            InitializeComponent();
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            HistorialTicket historial = new HistorialTicket();
            historial.CargarTickets(SesionActual.IdUsuario);

            lblAbiertosNum.Text = historial.ObtenerAbiertos().Count.ToString();
            lblProcesoNum.Text = historial.ObtenerEnProceso().Count.ToString();
            lblCerradosNum.Text = historial.ObtenerCerrados().Count.ToString();

            // Populate ListView
            lvTickets.Items.Clear();
            var ticketsOrdenados = historial.listaTickets.OrderByDescending(t => t.Fecha).ToList();

            foreach (var ticket in ticketsOrdenados)
            {
                ListViewItem item = new ListViewItem(ticket.Id);
                item.SubItems.Add(ticket.Detalle); // Assuming Detalle contains the title
                item.SubItems.Add(ticket.Estado);
                item.SubItems.Add(ticket.PrioridadUsuario);
                item.SubItems.Add(ticket.Fecha.ToString("dd/MM/yyyy HH:mm"));
                lvTickets.Items.Add(item);
            }
        }
    }
}
