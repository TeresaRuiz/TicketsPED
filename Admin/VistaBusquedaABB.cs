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
                // 1. Instanciamos nuestra clase de conexión
                Conexion con = new Conexion();

                // 2. Obtenemos el DataTable 
                DataTable datos = con.ObtenerTicketsParaGrid();

                // 3. Verificamos que traiga algo para evitar errores
                if (datos != null && datos.Rows.Count > 0)
                {
                    // Asignamos los datos al DataGrid
                    dgvTickets.DataSource = datos;

                    // Poner nombres bonitos a las columnas (Alias)
                    
                    dgvTickets.Columns["IdTicket"].HeaderText = "N° Ticket";
                    dgvTickets.Columns["Titulo"].HeaderText = "Asunto / Título";
                    dgvTickets.Columns["Nombre"].HeaderText = "Cliente";
                    dgvTickets.Columns["Descripcion"].HeaderText = "Detalle del Problema";
                    dgvTickets.Columns["NombreEstado"].HeaderText = "Estado";

                    // Ajustar el ancho para que se vea ordenado
                    dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos en el Grid: " + ex.Message);
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
            // Verificamos que no sea el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTickets.Rows[e.RowIndex];

                // Llenamos tus labels del panel lateral
                lblID.Text = fila.Cells["IdTicket"].Value.ToString();
                lblUsuario.Text = fila.Cells["Nombre"].Value.ToString();
                lblDetalle.Text = fila.Cells["Descripcion"].Value.ToString();
                lblEstado.Text = fila.Cells["NombreEstado"].Value.ToString();

                idTicketSeleccionado = Convert.ToInt32(fila.Cells["IdTicket"].Value);
                estadoActual = fila.Cells["NombreEstado"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idTicketSeleccionado == 0)
            {
                MessageBox.Show("Primero selecciona un ticket.");
                return;
            }

            int nuevoEstado = 0;

            if (estadoActual == "Abierto")
            {
                nuevoEstado = 2;
            }
            else if (estadoActual == "En proceso")
            {
                nuevoEstado = 3;
            }
            else
            {
                MessageBox.Show("Este ticket ya está resuelto.");
                return;
            }

            Conexion conexion = new Conexion();
            conexion.CambiarEstadoTicket(idTicketSeleccionado, nuevoEstado);

            MessageBox.Show("Estado actualizado correctamente.");

            CargarDatosAlGrid();

            lblID.Text = "";
            lblUsuario.Text = "";
            lblDetalle.Text = "";
            lblEstado.Text = "";

            idTicketSeleccionado = 0;
            estadoActual = "";
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            string opcion = cmbEstado.SelectedItem.ToString();

            DataTable datos = conexion.ObtenerTicketsOrdenados(opcion);

            dgvTickets.DataSource = datos;

            dgvTickets.Columns["IdTicket"].HeaderText = "N° Ticket";
            dgvTickets.Columns["Nombre"].HeaderText = "Cliente";
            dgvTickets.Columns["Titulo"].HeaderText = "Asunto / Título";
            dgvTickets.Columns["Descripcion"].HeaderText = "Detalle del problema";
            dgvTickets.Columns["NombreEstado"].HeaderText = "Estado";
        }
    }
    
}
