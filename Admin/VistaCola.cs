using System;
using System.Drawing;
using System.Windows.Forms;
using TicketsMDB.Admin;

namespace TicketsMDB
{
    public partial class VistaCola : UserControl
    {
        private TAD_Lista lista;
        private Ticket ticketSeleccionado = null;

        public VistaCola()
        {
            InitializeComponent();
        }

        public VistaCola(TAD_Lista listaCompartida)
        {
            InitializeComponent();
            this.lista = listaCompartida;
            actualizarColaEstatica();
        }

        public void actualizarColaEstatica()
        {
            pnlColaHorizontal.Controls.Clear();
            ticketSeleccionado = null;

            if (this.lista == null) return;

            int total = 0;
            Nodo aux = this.lista.Inicio;

            while (aux != null)
            {
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);
                Ticket datoActual = aux.Dato;

                // Al hacer clic en la tarjeta se selecciona
                tarjeta.Click += (s, e) => SeleccionarTicket(datoActual, tarjeta);

                // Suscribirse al evento del botón "Ver Detalle" interno de la tarjeta
                tarjeta.OnVerDetalleClick += (idTicket) => {
                    AbrirDetalle(idTicket);
                };

                pnlColaHorizontal.Controls.Add(tarjeta);

                if (aux.Siguiente != null)
                {
                    Label flecha = new Label();
                    flecha.Text = "➡";
                    flecha.Font = new Font("Segoe UI", 22, FontStyle.Bold);
                    flecha.ForeColor = Color.FromArgb(148, 163, 184);
                    flecha.AutoSize = true;
                    flecha.Padding = new Padding(0, 70, 0, 0);
                    pnlColaHorizontal.Controls.Add(flecha);
                }

                total++;
                aux = aux.Siguiente;
            }

            label6.Text = total.ToString();
        }

        private void SeleccionarTicket(Ticket ticket, TarjetaTicket tarjeta)
        {
            ticketSeleccionado = ticket;

            foreach (Control ctrl in pnlColaHorizontal.Controls)
            {
                if (ctrl is TarjetaTicket t)
                    t.BackColor = Color.White;
            }
            tarjeta.BackColor = Color.FromArgb(239, 246, 255);
            label1.Text = "➡  SELECCIONADO: #" + ticket.Id;
        }


        private void btnAtenderSiguiente_Click(object sender, EventArgs e)
        {
            if (lista == null || lista.Inicio == null)
            {
                MessageBox.Show("No hay tickets en la cola.", "Cola vacía",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Ticket primero = lista.Inicio.Dato;

            // Abrir automáticamente el detalle enviando la lista para que pueda ser gestionado internamente
            FormDetalleTicket frmDetalle = new FormDetalleTicket(primero.Id, lista);
            frmDetalle.ShowDialog();

            // Refrescar al cerrar la ventana modal
            actualizarColaEstatica();
            label1.Text = "➡  SIGUIENTE EN ATENDER";
        }

        private void AbrirDetalle(string idTicket)
        {
            FormDetalleTicket frmDetalle = new FormDetalleTicket(idTicket, lista);
            frmDetalle.ShowDialog();
            actualizarColaEstatica();
        }
    }
}
