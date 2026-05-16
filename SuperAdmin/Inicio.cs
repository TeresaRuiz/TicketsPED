using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketsMDB.SuperAdmin
{
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
            CargarContadores();
            CargarActividad();
            CargarUltimosUsuarios();
        }

        private void CargarUltimosUsuarios()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection cn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT u.Nombre, r.NombreRol, u.IdUsuario 
                    FROM Usuarios u 
                    JOIN Roles r ON u.IdRol = r.IdRol 
                    ORDER BY u.IdUsuario DESC";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                lvUltUsuarios.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Nombre"].ToString());
                    item.SubItems.Add(dr["NombreRol"].ToString());
                    item.SubItems.Add("ID: " + dr["IdUsuario"].ToString());
                    lvUltUsuarios.Items.Add(item);
                }
            }
        }

        private void CargarContadores()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection cn = conexion.AbrirConexion())
            {
                lblCardUsuariosNum.Text = new SqlCommand("SELECT COUNT(*) FROM Usuarios", cn).ExecuteScalar().ToString();
                lblCardAdminsNum.Text = new SqlCommand("SELECT COUNT(*) FROM Usuarios u JOIN Roles r ON u.IdRol = r.IdRol WHERE r.NombreRol = 'Admin'", cn).ExecuteScalar().ToString();
                lblCardTicketsNum.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets", cn).ExecuteScalar().ToString();
                lblCardAltaNum.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdPrioridadUsuario = 3 OR IdPrioridadReal = 3", cn).ExecuteScalar().ToString();
                lblCardPendientesNum.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdEstado != 3", cn).ExecuteScalar().ToString();

                lblEstAbiertosVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdEstado = 1", cn).ExecuteScalar().ToString();
                lblEstProcesoVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdEstado = 2", cn).ExecuteScalar().ToString();
                lblEstCerradosVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdEstado = 3", cn).ExecuteScalar().ToString();

                lblEstAltaVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdPrioridadReal = 3", cn).ExecuteScalar().ToString();
                lblEstMediaVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdPrioridadReal = 2", cn).ExecuteScalar().ToString();
                lblEstBajaVal.Text = new SqlCommand("SELECT COUNT(*) FROM Tickets WHERE IdPrioridadReal = 1", cn).ExecuteScalar().ToString();
            }
        }

        private void CargarActividad()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection cn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT * FROM (
                        SELECT t.FechaCreacion as Fecha, u.Nombre as Autor, 'Creó ticket: ' + t.Titulo as Accion
                        FROM Tickets t JOIN Usuarios u ON t.IdUsuario = u.IdUsuario
                        UNION ALL
                        SELECT h.FechaCambio as Fecha, u.Nombre as Autor, 'Actualizó ' + h.CampoModificado + ' (Ticket #' + CAST(h.IdTicket as VARCHAR) + ')' as Accion
                        FROM HistorialCambios h JOIN Usuarios u ON h.IdAdmin = u.IdUsuario
                        UNION ALL
                        SELECT c.Fecha as Fecha, u.Nombre as Autor, 'Comentó en Ticket #' + CAST(c.IdTicket as VARCHAR) as Accion
                        FROM Comentarios c JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                    ) Activity
                    WHERE Fecha >= DATEADD(hour, -24, GETDATE())
                    ORDER BY Fecha DESC";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                lvActividad.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(Convert.ToDateTime(dr["Fecha"]).ToString("HH:mm"));
                    item.SubItems.Add(dr["Autor"].ToString() + ": " + dr["Accion"].ToString());
                    lvActividad.Items.Add(item);
                }
            }
        }

        private void lvUltUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}