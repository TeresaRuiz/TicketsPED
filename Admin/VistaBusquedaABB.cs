using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketsMDB
{
    public partial class VistaBusquedaABB : UserControl
    {
        private int idTicketSeleccionado = 0;
        private string estadoActual = "";
        private DataView vistaFiltroMemoria;
        public VistaBusquedaABB()
        {
            InitializeComponent();

            cmbEstado.SelectedIndex = 0;

            CargarDatosAlGrid();
        }

        private void CargarDatosAlGrid()
        {
            try
            {
                Conexion con = new Conexion();
                DataTable datos = con.ObtenerTicketsParaGrid();

                if (datos != null)
                {
                    // Inicializamos el DataView con la tabla recuperada de la BD
                    vistaFiltroMemoria = new DataView(datos);
                    dgvTickets.DataSource = vistaFiltroMemoria;

                    // Asignación de Alias limpios para las columnas del DataGrid
                    dgvTickets.Columns["IdTicket"].HeaderText = "N° Ticket";
                    dgvTickets.Columns["Titulo"].HeaderText = "Asunto";
                    dgvTickets.Columns["Nombre"].HeaderText = "Cliente";
                    dgvTickets.Columns["Descripcion"].HeaderText = "Detalle";
                    dgvTickets.Columns["NombreEstado"].HeaderText = "Estado";

                    // Formatear columnas secundarias para priorizar legibilidad en 460px de ancho
                    if (dgvTickets.Columns["Descripcion"] != null) dgvTickets.Columns["Descripcion"].Visible = false;

                    dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    LimpiarPanelDetalles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la auditoría de registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public VistaBusquedaABB(TAD_Lista listaCompartida)
        {

        }
        private void VistaBusquedaABB_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //QUITAR PARA LA FASE 2, se usó con el fin de mostrar los datos en el prototipo
        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTickets.Rows[e.RowIndex];

                // Extraemos valores de la fila seleccionada
                lblID.Text = "#" + fila.Cells["IdTicket"].Value.ToString();
                lblUsuario.Text = fila.Cells["Nombre"].Value.ToString();
                lblDetalle.Text = fila.Cells["Descripcion"].Value.ToString();

                string estado = fila.Cells["NombreEstado"].Value.ToString();
                lblEstado.Text = estado.ToUpper();

                // Estilización dinámica del color según el estado del ticket auditado
                if (estado == "Abierto") lblEstado.ForeColor = Color.FromArgb(220, 38, 38);       // Rojo
                else if (estado == "En proceso") lblEstado.ForeColor = Color.FromArgb(180, 83, 9); // Ámbar
                else lblEstado.ForeColor = Color.FromArgb(5, 122, 85);                             // Verde Esmeralda

                // Habilitamos cambio lógico del ciclo
                idTicketSeleccionado = Convert.ToInt32(fila.Cells["IdTicket"].Value);
                estadoActual = estado;

                lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                lblDetalle.ForeColor = Color.FromArgb(15, 23, 42);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null) return;
            string opcion = cmbEstado.SelectedItem.ToString();

            // Si es la opción por defecto restauramos la procedencia completa
            if (opcion == "MOSTRAR TODOS")
            {
                CargarDatosAlGrid();
                return;
            }

            // Ejecuta el ordenamiento directo desde la base de datos según tu lógica existente
            Conexion conexion = new Conexion();
            DataTable datos = conexion.ObtenerTicketsOrdenados(opcion);

            if (datos != null)
            {
                vistaFiltroMemoria = new DataView(datos);
                dgvTickets.DataSource = vistaFiltroMemoria;
                if (dgvTickets.Columns["Descripcion"] != null) dgvTickets.Columns["Descripcion"].Visible = false;
            }
            LimpiarPanelDetalles();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (vistaFiltroMemoria == null) return;

            string filtroText = textBox1.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtroText))
            {
                // Si el buscador está vacío limpiamos el filtro del DataView
                vistaFiltroMemoria.RowFilter = "";
            }
            else
            {
                // Lógica de consulta en memoria: Busca coincidencia exacta en ID, o parcial en Nombre de cliente o Título
                int idBuscado;
                if (int.TryParse(filtroText, out idBuscado))
                {
                    vistaFiltroMemoria.RowFilter = $"Convert(IdTicket, 'System.String') LIKE '{idBuscado}%'";
                }
                else
                {
                    vistaFiltroMemoria.RowFilter = $"Nombre LIKE '%{filtroText}%' OR Titulo LIKE '%{filtroText}%'";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idTicketSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione primero un ticket del listado izquierdo para proceder.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nuevoEstado = 0;
            if (estadoActual == "Abierto") nuevoEstado = 2;       // Pasa a En Proceso
            else if (estadoActual == "En proceso") nuevoEstado = 3; // Pasa a Cerrado
            else
            {
                MessageBox.Show("Este ticket ya se encuentra archivado y resuelto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Conexion conexion = new Conexion();
            conexion.CambiarEstadoTicket(idTicketSeleccionado, nuevoEstado);
            {
                MessageBox.Show("Registro de auditoría actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosAlGrid();
            }
        }

        private void LimpiarPanelDetalles()
        {
            lblID.Text = "—";
            lblUsuario.Text = "—";
            lblEstado.Text = "—";
            lblEstado.ForeColor = Color.FromArgb(15, 23, 42);
            lblDetalle.Text = "Seleccione un registro de la lista para auditar sus detalles completos de procedencia.";
            lblDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDetalle.ForeColor = Color.FromArgb(148, 163, 184);

            idTicketSeleccionado = 0;
            estadoActual = "";
        }
    }
    
}
