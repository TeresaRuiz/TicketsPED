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

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
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

                cmd.Parameters.AddWithValue("@IdUsuario", 2);
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaCreacion.Value);
                cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedValue);
                cmd.Parameters.AddWithValue("@Prioridad", prioridadSeleccionada);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmNuevoTicket_Load(object sender, EventArgs e)
        {
            CargarEstados();

            dtpFechaCreacion.Value = DateTime.Now;

            // Estado por defecto
            cmbEstado.SelectedIndex = 0;
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
