using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsMDB.Admin;

namespace TicketsMDB
{
    public partial class VistaCola : UserControl
    {
        private TAD_Lista lista; // Para guardar la referencia
        private Ticket ticketSeleccionado = null; // ticket sobre el que actúan los botones

        //  Este es el constructor 
        public VistaCola()
        {
            InitializeComponent();
        }

        
        public VistaCola(TAD_Lista listaCompartida)
        {
            InitializeComponent();

            // Guardamos la lista que viene del FormPrincipal
            this.lista = listaCompartida;

            // Llamamos a un método para dibujar las tarjetas en horizontal
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

                
                tarjeta.Click += (s, e) => SeleccionarTicket(datoActual, tarjeta);

                pnlColaHorizontal.Controls.Add(tarjeta);

                if (aux.Siguiente != null)
                {
                    Label flecha = new Label();
                    flecha.Text = "➡";
                    flecha.Font = new Font("Segoe UI", 22, FontStyle.Bold);
                    flecha.ForeColor = Color.FromArgb(148, 163, 184);
                    flecha.AutoSize = true;
                    flecha.Padding = new Padding(0, 70, 0, 0); // Ajustar según altura de tarjeta
                    pnlColaHorizontal.Controls.Add(flecha);
                }

                total++;
                aux = aux.Siguiente;
            }

            // 5. Actualizar contador visual
            label6.Text = total.ToString();
        }
        private void SeleccionarTicket(Ticket ticket, TarjetaTicket tarjeta)
        {
            ticketSeleccionado = ticket;

            // Resaltar tarjeta seleccionada
            foreach (Control ctrl in pnlColaHorizontal.Controls)
            {
                if (ctrl is TarjetaTicket t)
                    t.BackColor = Color.White;
            }
            tarjeta.BackColor = Color.FromArgb(239, 246, 255);

            // Mostrar ID en label1 como confirmación visual
            label1.Text = "➡  SELECCIONADO: #" + ticket.Id;
        }

        private void VistaCola_Load(object sender, EventArgs e)
        {

        }

        private void pnlColaHorizontal_Paint(object sender, PaintEventArgs e)
        {

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

            var confirm = MessageBox.Show(
                $"¿Atender el ticket #{primero.Id} de {primero.Usuario}?\n\nSe cambiará el estado a 'En proceso'.",
                "Atender siguiente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // Cambiar estado en BD
            Conexion con = new Conexion();
            con.CambiarEstadoTicket(int.Parse(primero.Id), 2);
            bool ok = true;

            if (ok)
            {
                primero.Estado = "En proceso";
                ticketSeleccionado = primero;
                label1.Text = "➡  EN ATENCIÓN: #" + primero.Id;

                MessageBox.Show(
                    $"Ticket #{primero.Id} ahora está 'En proceso'.",
                    "Atendiendo ticket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refrescar visual sin sacar de la cola — el ticket sigue visible
                actualizarColaEstatica();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el estado en la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPriorizar_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
            {
                MessageBox.Show("Selecciona un ticket primero haciendo clic sobre él.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lista.Inicio != null && lista.Inicio.Dato.Id == ticketSeleccionado.Id)
            {
                MessageBox.Show("Este ticket ya está al inicio de la cola.",
                    "Priorizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar y mover al inicio
            Nodo prev = null;
            Nodo actual = lista.Inicio;

            while (actual != null && actual.Dato.Id != ticketSeleccionado.Id)
            {
                prev = actual;
                actual = actual.Siguiente;
            }

            if (actual == null) return;

            // Desconectar del lugar actual
            if (prev != null)
                prev.Siguiente = actual.Siguiente;

            // Colocar al inicio
            actual.Siguiente = lista.Inicio;
            lista.Inicio = actual;

            MessageBox.Show($"Ticket #{ticketSeleccionado.Id} movido al inicio de la cola.",
                "Priorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            actualizarColaEstatica();
        }

        private void btnTomarTicket_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
            {
                MessageBox.Show("Selecciona un ticket primero haciendo clic sobre él.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ticketSeleccionado.Estado == "Cerrado")
            {
                MessageBox.Show("Este ticket ya está cerrado.", "Ticket cerrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Tomar el ticket #{ticketSeleccionado.Id}?\nQuedarás como responsable.",
                "Tomar ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // Aquí pasas el IdAdmin desde sesión — ajusta según tu sistema de login
            // Ejemplo: int idAdmin = SesionActual.IdUsuario;
            Conexion con = new Conexion();
            bool ok = con.AsignarResponsable(int.Parse(ticketSeleccionado.Id), ticketSeleccionado.Responsable);
            if (ok)
            {
                MessageBox.Show($"Ticket #{ticketSeleccionado.Id} asignado a ti correctamente.",
                    "Ticket tomado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarColaEstatica();
            }
            else
            {
                MessageBox.Show("No se pudo asignar el ticket.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
            {
                MessageBox.Show("Selecciona un ticket primero haciendo clic sobre él.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Cerrar el ticket #{ticketSeleccionado.Id}?\nEsta acción marcará el problema como resuelto.",
                "Cerrar ticket",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            Conexion con = new Conexion();
            con.CambiarEstadoTicket(int.Parse(ticketSeleccionado.Id), 3);
            bool ok = true;

            if (ok)
            {
                // Sacar de la lista enlazada
                EliminarDeLista(ticketSeleccionado.Id);

                MessageBox.Show($"Ticket #{ticketSeleccionado.Id} cerrado y retirado de la cola.",
                    "Ticket cerrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ticketSeleccionado = null;
                label1.Text = "➡  SIGUIENTE EN ATENDER";
                actualizarColaEstatica();
            }
            else
            {
                MessageBox.Show("No se pudo cerrar el ticket.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarUrgente_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
            {
                MessageBox.Show("Selecciona un ticket primero haciendo clic sobre él.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Marcar el ticket #{ticketSeleccionado.Id} como URGENTE?\nSe cambiará su prioridad a Alta y pasará al inicio de la cola.",
                "Marcar urgente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            Conexion con = new Conexion();
            bool ok = con.CambiarPrioridadReal(int.Parse(ticketSeleccionado.Id), 3);

            if (ok)
            {
                ticketSeleccionado.PrioridadReal = "Alta";

                // Mover al inicio automáticamente
                Nodo prev = null;
                Nodo actual = lista.Inicio;

                while (actual != null && actual.Dato.Id != ticketSeleccionado.Id)
                {
                    prev = actual;
                    actual = actual.Siguiente;
                }

                if (actual != null && prev != null)
                {
                    prev.Siguiente = actual.Siguiente;
                    actual.Siguiente = lista.Inicio;
                    lista.Inicio = actual;
                }

                MessageBox.Show($"Ticket #{ticketSeleccionado.Id} marcado como URGENTE y movido al inicio.",
                    "Urgente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarColaEstatica();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar la prioridad.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void EliminarDeLista(string id)
        {
            if (lista == null || lista.Inicio == null) return;

            // Es el primero
            if (lista.Inicio.Dato.Id == id)
            {
                lista.Inicio = lista.Inicio.Siguiente;
                return;
            }

            Nodo prev = lista.Inicio;
            Nodo actual = lista.Inicio.Siguiente;

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

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado != null)
            {
                // Abrimos el formulario que diseñamos antes pasando el ID
                FormDetalleTicket frmDetalle = new FormDetalleTicket(ticketSeleccionado.Id);
                frmDetalle.ShowDialog();

                // Al volver, refrescamos por si se agregaron comentarios
                actualizarColaEstatica();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ticket de la cola primero.");
            }
        }
    }
}
