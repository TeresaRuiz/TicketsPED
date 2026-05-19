using System;
using System.Drawing;
using System.Windows.Forms;
using TicketsMDB.Admin;

namespace TicketsMDB
{
    public partial class VistaCola : UserControl
    {
        private TAD_Cola colaDeTrabajo;
        private Ticket ticketSeleccionado = null;

        public VistaCola()
        {
            InitializeComponent();
        }

        public VistaCola(TAD_Cola colaCompartida)
        {
            InitializeComponent();
            this.colaDeTrabajo = colaCompartida;
            actualizarColaEstatica();
        }

        public void actualizarColaEstatica()
        {
            pnlColaHorizontal.Controls.Clear();
            ticketSeleccionado = null;

            if (this.colaDeTrabajo == null) return;

            int total = 0;
            // RECORRIDO MANUAL: Iniciamos desde la cima o Frente de la cola
            Nodo aux = this.colaDeTrabajo.Frente;

            while (aux != null)
            {
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);
                Ticket datoActual = aux.Dato;

                tarjeta.Click += (s, e) => SeleccionarTicket(datoActual, tarjeta);

                tarjeta.OnVerDetalleClick += (idTicket) => {
                    AbrirDetalle(idTicket);
                };

                pnlColaHorizontal.Controls.Add(tarjeta);

                // Dibujamos la flecha si hay eslabones enlazados detrás
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
                aux = aux.Siguiente; // Avance secuencial manual
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
            if (colaDeTrabajo == null || colaDeTrabajo.Frente == null)
            {
                MessageBox.Show("No hay tickets pendientes en la cola de atención.", "Cola vacía",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // OPERACIÓN DE COLA PURA: Atendemos al primero y lo sacamos con Dequeue()
            Ticket primero = colaDeTrabajo.Dequeue();

            // Abrimos el formulario de detalle modal pasándole la cola para gestiones internas
            FormDetalleTicket frmDetalle = new FormDetalleTicket(primero.Id, colaDeTrabajo);
            frmDetalle.ShowDialog();

            actualizarColaEstatica();
            label1.Text = "➡  SIGUIENTE EN ATENDER";
        }

        private void AbrirDetalle(string idTicket)
        {
            FormDetalleTicket frmDetalle = new FormDetalleTicket(idTicket, colaDeTrabajo);
            frmDetalle.ShowDialog();
            actualizarColaEstatica();
        }
    }
}
