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

namespace TicketsMDB.Clientes
{
    public partial class MisTickets : UserControl
    {
        public MisTickets()
        {
            InitializeComponent();
            ConfigurarListView();
            CargarTickets();
        }

        private void ConfigurarListView()
        {
            lvTickets.View = View.Details;

            lvTickets.FullRowSelect = true;

            lvTickets.GridLines = true;

            lvTickets.Columns.Add("#", 50);
            lvTickets.Columns.Add("Título", 200);
            lvTickets.Columns.Add("Estado", 120);
            lvTickets.Columns.Add("Prioridad usuario", 150);
            lvTickets.Columns.Add("Prioridad real", 150);
            lvTickets.Columns.Add("Fecha", 150);
        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarTickets()
        {
            lvTickets.Items.Clear();
            Conexion db = new Conexion();

            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                string query = @"
                SELECT 
                    t.IdTicket,
                    t.Titulo,
                    e.NombreEstado,
                    p1.NombrePrioridad AS PrioridadUsuario,
                    ISNULL(p2.NombrePrioridad, 'Sin asignar') AS PrioridadReal,
                    t.FechaCreacion
                FROM Tickets t
                INNER JOIN Estados e
                    ON t.IdEstado = e.IdEstado
                INNER JOIN Prioridades p1
                    ON t.IdPrioridadUsuario = p1.IdPrioridad
                LEFT JOIN Prioridades p2
                    ON t.IdPrioridadReal = p2.IdPrioridad
                WHERE t.IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@IdUsuario", SesionActual.IdUsuario);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item =
                        new ListViewItem(dr["IdTicket"].ToString());

                    item.SubItems.Add(dr["Titulo"].ToString());
                    item.SubItems.Add(dr["NombreEstado"].ToString());
                    item.SubItems.Add(dr["PrioridadUsuario"].ToString());
                    item.SubItems.Add(dr["PrioridadReal"].ToString());
                    item.SubItems.Add(
                        Convert.ToDateTime(dr["FechaCreacion"])
                        .ToString("dd/MM/yyyy"));

                    lvTickets.Items.Add(item);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tickets: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un ticket");
                return;
            }

            int idTicket =
                Convert.ToInt32(lvTickets.SelectedItems[0].Text);

            VerDetalle(idTicket);
        }

        private void VerDetalle(int idTicket)
        {
            Conexion db = new Conexion();
            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                string query = @"
                SELECT 
                    t.IdTicket,
                    t.Titulo,
                    t.Descripcion,
                    e.NombreEstado,
                    p.NombrePrioridad,
                    t.FechaCreacion
                FROM Tickets t
                INNER JOIN Estados e
                    ON t.IdEstado = e.IdEstado
                INNER JOIN Prioridades p
                    ON t.IdPrioridadUsuario = p.IdPrioridad
                WHERE t.IdTicket = @IdTicket AND t.IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdTicket", idTicket);
                cmd.Parameters.AddWithValue("@IdUsuario", SesionActual.IdUsuario);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string detalle =
                        "ID: " + dr["IdTicket"] + "\n\n" +
                        "Título: " + dr["Titulo"] + "\n\n" +
                        "Descripción: " + dr["Descripcion"] + "\n\n" +
                        "Estado: " + dr["NombreEstado"] + "\n\n" +
                        "Prioridad: " + dr["NombrePrioridad"] + "\n\n" +
                        "Fecha: " + dr["FechaCreacion"];

                    MessageBox.Show(detalle,
                        "Detalle Ticket",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lvTickets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un ticket");
                return;
            }

            int idTicket =
                 Convert.ToInt32(lvTickets.SelectedItems[0].Text); 

            Conexion db = new Conexion();
            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                string query = @"
                UPDATE Tickets
                SET IdEstado = 2
                WHERE IdTicket = @IdTicket";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdTicket", idTicket);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket actualizado");

                CargarTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }
    }
    
}
