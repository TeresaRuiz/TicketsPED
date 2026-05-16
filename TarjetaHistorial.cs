using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketsMDB
{
    public partial class TarjetaHistorial : UserControl
    {
        // Guardamos el ID del ticket de forma interna en la tarjeta
        private int idTicketAsociado;

        // Delegado y Evento personalizado para capturar el doble clic desde afuera
        public delegate void AbrirDetalleHandler(int idTicket);
        public event AbrirDetalleHandler OnTarjetaDoubleClic;

        public TarjetaHistorial(Ticket datos)
        {
            InitializeComponent();

            if (datos != null)
            {
                // El campo 'datos.Id' contiene el ID del ticket modificado
                this.idTicketAsociado = int.Parse(datos.Id);
                AsignarValoresTrazabilidad(datos);

                // Conectar eventos de doble clic de la tarjeta y sus paneles internos
                this.DoubleClick += new EventHandler(Tarjeta_DoubleClick);
                this.pnlCard.DoubleClick += new EventHandler(Tarjeta_DoubleClick);
                this.lblFecha.DoubleClick += new EventHandler(Tarjeta_DoubleClick);
                this.lblEstado.DoubleClick += new EventHandler(Tarjeta_DoubleClick);
                this.lblResponsable.DoubleClick += new EventHandler(Tarjeta_DoubleClick);
            }
        }

        private void Tarjeta_DoubleClick(object sender, EventArgs e)
        {
            // Disparamos el evento hacia la vista padre enviando el ID del ticket
            OnTarjetaDoubleClic?.Invoke(idTicketAsociado);
        }

        private void AsignarValoresTrazabilidad(Ticket datos)
        {
            if (datos.Titulo == "IdEstado")
            {
                lblFecha.Text = "🔄 CAMBIO DE ESTADO";
                lblEstado.Text = $"{datos.Responsable} ➡️ {datos.Estado}";
                if (datos.Estado == "Abierto") lblEstado.ForeColor = Color.FromArgb(220, 38, 38);
                else if (datos.Estado == "En proceso") lblEstado.ForeColor = Color.FromArgb(180, 83, 9);
                else lblEstado.ForeColor = Color.FromArgb(5, 122, 85);
                pnlDot.BackColor = Color.FromArgb(37, 99, 235);
            }
            else if (datos.Titulo == "IdPrioridadReal")
            {
                lblFecha.Text = "⚡ MODIFICACIÓN DE PRIORIDAD";
                lblEstado.Text = $"{datos.Responsable} ➡️ {datos.Estado}";
                if (datos.Estado == "Alta") lblEstado.ForeColor = Color.FromArgb(185, 28, 28);
                else if (datos.Estado == "Media") lblEstado.ForeColor = Color.FromArgb(217, 119, 6);
                else lblEstado.ForeColor = Color.FromArgb(71, 85, 105);
                pnlDot.BackColor = Color.FromArgb(245, 158, 11);
            }

            lblResponsable.Text = $"#TK-{idTicketAsociado:D4}";
        }
    }
}