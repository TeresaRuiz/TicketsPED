using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB
{
    public partial class FormRegistroTicket : UserControl
    {

        int prioridadSeleccionada = 0;

        public FormRegistroTicket()
        {
            InitializeComponent();
            CargarEstados();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {

            //validaciones

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (prioridadSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una prioridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexion db = new Conexion();
            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                string query = @"INSERT INTO Tickets
                (
                     IdUsuario,
                     Titulo,
                     Descripcion,
                     FechaCreacion,
                     IdEstado,
                     IdPrioridadUsuario
                )
                  VALUES
                (
                   @IdUsuario,
                   @Titulo,
                   @Descripcion,
                   @Fecha,
                   @Estado,
                   @Prioridad
                )";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdUsuario", SesionActual.IdUsuario);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text.Trim());

                cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(txtDescripcion.Text) ? (object)DBNull.Value : txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@Estado", 4);

                cmd.Parameters.AddWithValue("@Prioridad", prioridadSeleccionada);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket registrado correctamente de forma pendiente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el ticket: " + ex.Message, "Error de Persistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            prioridadSeleccionada = 0;
             }

        private void CargarEstados()
        {
            Conexion db = new Conexion();

            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdEstado, NombreEstado FROM Estados",
                    cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cmbEstado.DataSource = dt;
                cmbEstado.DisplayMember = "NombreEstado";
                cmbEstado.ValueMember = "IdEstado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            prioridadSeleccionada = 1;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            prioridadSeleccionada = 2;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            prioridadSeleccionada = 3;
        }
    }
}
