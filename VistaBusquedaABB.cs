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
    public partial class VistaBusquedaABB : UserControl
    {
        public VistaBusquedaABB()
        {
            InitializeComponent();

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
                    dgvTickets.Columns["IdUsuario"].HeaderText = "ID Cliente";
                    dgvTickets.Columns["Descripcion"].HeaderText = "Detalle del Problema";
                    dgvTickets.Columns["IdEstado"].HeaderText = "Estado (ID)";

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
                lblUsuario.Text = fila.Cells["IdUsuario"].Value.ToString();
                lblDetalle.Text = fila.Cells["Descripcion"].Value.ToString();
                lblEstado.Text = fila.Cells["IdEstado"].Value.ToString();
            }
        }
    }
}
