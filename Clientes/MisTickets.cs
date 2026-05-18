using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            // Cargamos los ítems del catálogo de prioridades
            cmbNuevaPrioridad.Items.Add("Baja");
            cmbNuevaPrioridad.Items.Add("Media");
            cmbNuevaPrioridad.Items.Add("Alta");
            CargarTickets();
        }

        private void ConfigurarListView()
        {
            lvTickets.View = View.Details;
            lvTickets.FullRowSelect = true;
            lvTickets.GridLines = true;
            lvTickets.LabelEdit = false; 
        }

        private void CargarTickets()
        {
            ticket.CargarTickets(SesionActual.IdUsuario);

            MostrarTickets(
                ticket.ObtenerTodos());
        }

        private void MostrarTickets(TAD_Lista lista) 
        {
            lvTickets.Items.Clear();
            if (lista == null) return;

            Nodo aux = lista.Inicio;

            while (aux != null)
            {
                Ticket t = aux.Dato;

                ListViewItem item = new ListViewItem(t.Id);
                item.SubItems.Add(t.Titulo);
                item.SubItems.Add(t.Estado);
                item.SubItems.Add(t.PrioridadUsuario);
                item.SubItems.Add(t.PrioridadReal);
                item.SubItems.Add(t.Fecha.ToString("dd/MM/yyyy"));

                item.SubItems.Add("🔍 Ver   |   📝 Editar");

                lvTickets.Items.Add(item);
                aux = aux.Siguiente;
            }
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


       
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (panelActualizar.Tag == null) return;

            if (string.IsNullOrWhiteSpace(txtNuevoTitulo.Text) || string.IsNullOrWhiteSpace(txtNuevaDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete el título y la descripción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idTicket = panelActualizar.Tag.ToString();
            string nuevoTitulo = txtNuevoTitulo.Text.Trim();
            string nuevaDesc = txtNuevaDescripcion.Text.Trim();
            string nuevaPrio = cmbNuevaPrioridad.Text;

           int idPrioridad = nuevaPrio == "Baja" ? 1 : nuevaPrio == "Media" ? 2 : 3;


             Conexion con = new Conexion();
            bool actualizado = con.ActualizarTicketCompletoCliente(int.Parse(idTicket), nuevoTitulo, nuevaDesc, idPrioridad);

            if (actualizado)
            {
                MessageBox.Show("Solicitud de ticket modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelActualizar.Visible = false;
                panelActualizar.Tag = null;
                CargarTickets(); 
            }
            else
            {
                MessageBox.Show("No se pudieron guardar los cambios en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvTickets_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = lvTickets.HitTest(e.Location);

            if (hit.Item != null && hit.SubItem != null)
            {
                int indiceColumnaAccion = lvTickets.Columns.Count - 1; 

               if (hit.Item.SubItems[indiceColumnaAccion] == hit.SubItem)
                {
                    Rectangle limitesSubItem = hit.SubItem.Bounds;
                    int puntoXRelativo = e.X - limitesSubItem.Left;
                    int anchoMitad = limitesSubItem.Width / 2;

                    string idTicket = hit.Item.Text;
                    if (puntoXRelativo < anchoMitad)
                    {
                        EjecutarAccionDetalle(idTicket);
                    }
                    else
                    {
                        EjecutarAccionActualizar(hit.Item);
                    }
                }
            }
        }
        private void EjecutarAccionDetalle(string idTicket)
        {
            Ticket t = null;
            Nodo aux = ticket.listaTickets.Inicio;

            while (aux != null)
            {
                if (aux.Dato.Id == idTicket)
                {
                    t = aux.Dato;
                    break;
                }
                aux = aux.Siguiente;
            }

            if (t != null)
            {
                string detalle =
                    "ID: " + t.Id + "\n\n" +
                    "Usuario: " + t.Usuario + "\n\n" +
                    "Detalle: " + t.Detalle + "\n\n" +
                    "Estado: " + t.Estado + "\n\n" +
                    "Prioridad Usuario: " + t.PrioridadUsuario + "\n\n" +
                    "Prioridad Real: " + t.PrioridadReal + "\n\n" +
                    "Fecha: " + t.Fecha.ToString("dd/MM/yyyy HH:mm");

                MessageBox.Show(detalle, "Detalle del Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EjecutarAccionActualizar(ListViewItem item)
        {
            string idTicket = item.Text;
            string estado = item.SubItems[2].Text;

            if (estado == "Cerrado")
            {
                MessageBox.Show("Este ticket ya fue cerrado y no puede ser modificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Ticket ticketEncontrado = null;
            Nodo aux = ticket.listaTickets.Inicio;

            while (aux != null)
            {
                if (aux.Dato.Id == idTicket)
                {
                    ticketEncontrado = aux.Dato;
                    break;
                }
                aux = aux.Siguiente;
            }

            if (ticketEncontrado != null)
            {
                panelActualizar.Visible = true;
                panelActualizar.BringToFront();

                 txtNuevoTitulo.Text = ticketEncontrado.Titulo;
                txtNuevaDescripcion.Text = ticketEncontrado.Detalle;
                cmbNuevaPrioridad.Text = ticketEncontrado.PrioridadUsuario;

                panelActualizar.Tag = idTicket; 
            }
        }
    }
    
}
