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
    public partial class DetalleTicket : Form
    {
        private int ticketId;
        private int adminIdActual = 1; // Ajustar según ID del administrador logueado
        private Conexion con = new Conexion();
        private TAD_Pila pilaHistorialLocal = new TAD_Pila();
        public DetalleTicket(int idTicket)
        {
            InitializeComponent();
            this.ticketId = idTicket;

            CargarDatosTicket();
            CargarLineaTiempo();
        }

        private void CargarDatosTicket()
        {
            DataTable dt = con.ObtenerDetalleCompleto(ticketId);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Badges Superiores
                lblBadgeId.Text = $"#TK-{row["IdTicket"]:D4}";
                lblBadgeEstado.Text = row["NombreEstado"].ToString().ToUpper();
                lblBadgePrioridad.Text = (row["NombrePrioridadReal"] != DBNull.Value ? row["NombrePrioridadReal"].ToString() : row["NombrePrioridadUsuario"].ToString()).ToUpper();

                // Panel de Información
                lblUsuarioVal.Text = row["Usuario"].ToString();
                lblFechaVal.Text = Convert.ToDateTime(row["FechaCreacion"]).ToString("dd/MM/yyyy HH:mm");
                lblEstadoVal.Text = row["NombreEstado"].ToString();
                lblPriorUsuarioVal.Text = row["NombrePrioridadUsuario"].ToString();
                lblPriorRealVal.Text = row["NombrePrioridadReal"] != DBNull.Value ? row["NombrePrioridadReal"].ToString() : "No asignada";
                lblAsignadoVal.Text = "Soporte Técnico";

                // Descripción Grande
                txtDescripcion.Text = row["Descripcion"].ToString();

                // Sincronizar ComboBoxes con los estados actuales
                cmbEstado.SelectedItem = row["NombreEstado"].ToString();
                cmbPrioridad.SelectedItem = row["NombrePrioridadReal"] != DBNull.Value ? row["NombrePrioridadReal"].ToString() : "Media";
            }
        }

        private void CargarLineaTiempo()
        {
            pnlTimeline.Controls.Clear();
            pnlTimeline.Controls.Add(pnlDivHistorial);
            pnlTimeline.Controls.Add(lblHistorialTitulo);

            // Obtener el historial inverso desde SQL para sincronizar la Pila LIFO en la RAM
            pilaHistorialLocal.VaciarPila();
            DataTable dtHistorial = con.ObtenerHistorialCambios(ticketId);

            if (dtHistorial != null)
            {
                // Iterar al revés para que al hacer Push el tope sea realmente el último cambio realizado
                for (int i = dtHistorial.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = dtHistorial.Rows[i];
                    Ticket cambio = new Ticket
                    {
                        Id = row["IdHistorial"].ToString(), // ID del registro del historial para el POP
                        Titulo = row["CampoModificado"].ToString(),
                        Estado = row["ValorNuevo"].ToString(), // Valor nuevo
                        Responsable = row["ValorAnterior"].ToString(), // Valor anterior guardado temporalmente
                        Detalle = Convert.ToDateTime(row["FechaCambio"]).ToString("HH:mm") + " - " + row["CampoModificado"].ToString()
                    };
                    pilaHistorialLocal.Push(cambio);
                }
            }

            // Dibujar los controles visuales leyendo la Pila sin destruirla
            Nodo aux = pilaHistorialLocal.Tope;
            int ubicacionY = 50;

            while (aux != null)
            {
                Panel pnlItem = new Panel
                {
                    Size = new Size(pnlTimeline.Width - 30, 65),
                    Location = new Point(10, ubicacionY),
                    BackColor = (aux == pilaHistorialLocal.Tope) ? Color.FromArgb(255, 247, 237) : Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblCambio = new Label
                {
                    Text = $"⚙️ {aux.Dato.Titulo}: {aux.Dato.Responsable} ➡️ {aux.Dato.Estado}",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblMeta = new Label
                {
                    Text = $"Modificado el: {aux.Dato.Detalle}",
                    Font = new Font("Segoe UI", 7.5F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                pnlItem.Controls.Add(lblCambio);
                pnlItem.Controls.Add(lblMeta);
                pnlTimeline.Controls.Add(pnlItem);

                ubicacionY += 75;
                aux = aux.Siguiente;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            // Operación POP en la RAM
            Ticket ultimoCambio = pilaHistorialLocal.Pop();

            if (ultimoCambio == null)
            {
                MessageBox.Show("No existen más acciones registradas en el historial de trazabilidad de este ticket.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"¿Desea revertir la modificación en el campo '{ultimoCambio.Titulo}' de '{ultimoCambio.Estado}' regresando a '{ultimoCambio.Responsable}'?",
                "Deshacer Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // Ejecutar la restauración física en SQL e invertir los estados
            bool revertido = false;
            if (ultimoCambio.Titulo == "IdEstado")
            {
                string valorAnterior = ultimoCambio.Responsable;
                int idEstadoViejo = valorAnterior == "Abierto" ? 1 : valorAnterior == "En proceso" ? 2 : 3;
                revertido = con.CambiarEstadoTicket(ticketId, idEstadoViejo);
            }
            else if (ultimoCambio.Titulo == "IdPrioridadReal")
            {
                string valorAnterior = ultimoCambio.Responsable;
                int idPrioridadVieja = valorAnterior == "Baja" ? 1 : valorAnterior == "Media" ? 2 : 3;
                revertido = con.CambiarPrioridadReal(ticketId, idPrioridadVieja);
            }

            if (revertido)
            {
                // Remover el registro de historial de la BD para limpiar la traza
                con.EliminarRegistroHistorial(int.Parse(ultimoCambio.Id));

                MessageBox.Show("La última operación ha sido revertida de forma exitosa.", "Deshecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosTicket();
                CargarLineaTiempo();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoEstado = cmbEstado.SelectedItem.ToString();
            string nuevaPrioridad = cmbPrioridad.SelectedItem.ToString();

            int idEstadoNum = nuevoEstado == "Abierto" ? 1 : nuevoEstado == "En proceso" ? 2 : 3;
            int idPrioridadNum = nuevaPrioridad == "Baja" ? 1 : nuevaPrioridad == "Media" ? 2 : 3;

            // 1. Validar e insertar comentarios si los hay
            if (!string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                con.AgregarComentario(ticketId, adminIdActual, txtComentario.Text);
                txtComentario.Clear();
            }

            // 2. Registrar Trazabilidad de cambios de Estado en la BD e Historial
            if (nuevoEstado != lblEstadoVal.Text)
            {
                con.RegistrarCambioHistorial(ticketId, adminIdActual, "IdEstado", lblEstadoVal.Text, nuevoEstado);
                con.CambiarEstadoTicket(ticketId, idEstadoNum);
            }

            // 3. Registrar Trazabilidad de cambios de Prioridad en la BD e Historial
            if (nuevaPrioridad != lblPriorRealVal.Text)
            {
                con.RegistrarCambioHistorial(ticketId, adminIdActual, "IdPrioridadReal", lblPriorRealVal.Text, nuevaPrioridad);
                con.CambiarPrioridadReal(ticketId, idPrioridadNum);
            }

            MessageBox.Show("Cambios aplicados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatosTicket();
            CargarLineaTiempo();
        }
    }
}
