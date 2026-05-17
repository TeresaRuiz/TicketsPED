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

            
            lblAbiertosNum.Text = ContarNodos(historial.ObtenerAbiertos()).ToString();
            lblProcesoNum.Text = ContarNodos(historial.ObtenerEnProceso()).ToString();
            lblCerradosNum.Text = ContarNodos(historial.ObtenerCerrados()).ToString();

            
            historial.listaTickets.OrdenarPorFechaDescendente();

            
            lvTickets.Items.Clear();
            Nodo aux = historial.listaTickets.Inicio;

            while (aux != null)
            {
                Ticket ticket = aux.Dato;

                ListViewItem item = new ListViewItem(ticket.Id);
                item.SubItems.Add(ticket.Detalle);
                item.SubItems.Add(ticket.Estado);
                item.SubItems.Add(ticket.PrioridadUsuario);
                item.SubItems.Add(ticket.Fecha.ToString("dd/MM/yyyy HH:mm"));

                lvTickets.Items.Add(item);

                aux = aux.Siguiente; 
            }
        }

       private int ContarNodos(TAD_Lista listaEvaluada)
        {
            if (listaEvaluada == null || listaEvaluada.Inicio == null) return 0;

            int contador = 0;
            Nodo aux = listaEvaluada.Inicio;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }
    }
}
