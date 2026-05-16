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
    public partial class TarjetaTicket : UserControl
    {
        private Ticket ticket;
        public delegate void VerDetalleHandler(string idTicket);
        public event VerDetalleHandler OnVerDetalleClick;

        public TarjetaTicket()
        {
            InitializeComponent();
        }

        public TarjetaTicket(Ticket t)
        {
            InitializeComponent();
            this.ticket = t;
            AsignarValores();
        }

        private void AsignarValores()
        {
            if (ticket == null) return;
            lblID.Text = "#" + ticket.Id;
            lblUsuario.Text = ticket.Usuario;
            lblDetalle.Text = ticket.Detalle;
            lblEstado.Text = ticket.Estado;
            lblPrioridad.Text = ticket.PrioridadReal ?? "Media";
        }

        private void btnVerDetalleInterno_Click(object sender, EventArgs e)
        {
            // Disparar evento hacia el contenedor padre con el ID del ticket
            OnVerDetalleClick?.Invoke(ticket.Id);
        }
    }
}