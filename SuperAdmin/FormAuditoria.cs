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
    public partial class FormAuditoria : UserControl
    {
        public FormAuditoria()
        {
            InitializeComponent();
            CargarTiposFiltro();
            CargarAuditoria(0, DateTime.MinValue, DateTime.MaxValue, "Todos");
            CargarUsuariosFiltro();
            btnFiltrar.Click += btnFiltrar_Click;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
        }

        private void CargarUsuariosFiltro()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection cn = conexion.AbrirConexion())
            {
                string query = "SELECT IdUsuario, Nombre FROM Usuarios ORDER BY Nombre ASC";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                cmbUsuarioFiltro.Items.Clear();
                cmbUsuarioFiltro.Items.Add(new { Text = "Todos", Value = 0 });

                while (dr.Read())
                {
                    cmbUsuarioFiltro.Items.Add(new { Text = dr["Nombre"].ToString(), Value = (int)dr["IdUsuario"] });
                }

                cmbUsuarioFiltro.DisplayMember = "Text";
                cmbUsuarioFiltro.ValueMember = "Value";
                cmbUsuarioFiltro.SelectedIndex = 0;
            }
        }

        private void CargarTiposFiltro()
        {
            cmbTipoCambio.Items.Clear();
            cmbTipoCambio.Items.Add("Todos");
            cmbTipoCambio.Items.Add("Actualización");
            cmbTipoCambio.Items.Add("Creación");
            cmbTipoCambio.Items.Add("Comentario");
            cmbTipoCambio.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var selectedUser = (dynamic)cmbUsuarioFiltro.SelectedItem;
            string selectedTipo = cmbTipoCambio.SelectedItem.ToString();
            CargarAuditoria((int)selectedUser.Value, dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddDays(1), selectedTipo);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cmbUsuarioFiltro.SelectedIndex = 0;
            cmbTipoCambio.SelectedIndex = 0;
            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;
            CargarAuditoria(0, DateTime.MinValue, DateTime.MaxValue, "Todos");
        }

        private void CargarAuditoria(int userId, DateTime startDate, DateTime endDate, string tipo)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection cn = conexion.AbrirConexion())
            {
                List<string> filters = new List<string>();
                if (userId > 0) filters.Add("UsuarioId = @uId");
                if (startDate != DateTime.MinValue && endDate != DateTime.MaxValue) 
                    filters.Add("Fecha >= @start AND Fecha < @end");
                if (tipo != "Todos") filters.Add("Tipo = @tipo");
                
                string filterClause = filters.Count > 0 ? "WHERE " + string.Join(" AND ", filters) : "";
                
                string query = $@"
                    SELECT * FROM (
                        SELECT h.IdHistorial as Id, h.FechaCambio as Fecha, ISNULL(u.Nombre, 'Sistema') as Usuario, u.IdUsuario as UsuarioId, 'Actualización' as Tipo, 'Ticket #' + CAST(h.IdTicket AS VARCHAR) as Entidad, h.CampoModificado + ': ' + h.ValorAnterior + ' -> ' + h.ValorNuevo as Detalle
                        FROM HistorialCambios h
                        LEFT JOIN Usuarios u ON h.IdAdmin = u.IdUsuario
                        UNION ALL
                        SELECT t.IdTicket as Id, t.FechaCreacion as Fecha, u.Nombre as Usuario, u.IdUsuario as UsuarioId, 'Creación' as Tipo, 'Ticket #' + CAST(t.IdTicket AS VARCHAR) as Entidad, 'Nuevo ticket: ' + t.Titulo as Detalle
                        FROM Tickets t
                        JOIN Usuarios u ON t.IdUsuario = u.IdUsuario
                        UNION ALL
                        SELECT c.IdComentario as Id, c.Fecha as Fecha, u.Nombre as Usuario, u.IdUsuario as UsuarioId, 'Comentario' as Tipo, 'Ticket #' + CAST(c.IdTicket AS VARCHAR) as Entidad, LEFT(c.Comentario, 50) + '...' as Detalle
                        FROM Comentarios c
                        JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                    ) AuditLog
                    {filterClause}
                    ORDER BY Fecha DESC";

                SqlCommand cmd = new SqlCommand(query, cn);
                if (userId > 0) cmd.Parameters.AddWithValue("@uId", userId);
                if (startDate != DateTime.MinValue && endDate != DateTime.MaxValue)
                {
                    cmd.Parameters.AddWithValue("@start", startDate);
                    cmd.Parameters.AddWithValue("@end", endDate);
                }
                if (tipo != "Todos") cmd.Parameters.AddWithValue("@tipo", tipo);
                SqlDataReader dr = cmd.ExecuteReader();

                lvAuditoria.Items.Clear();
                int count = 0;
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(dr["Usuario"].ToString());
                    item.SubItems.Add(dr["Tipo"].ToString());
                    item.SubItems.Add(dr["Entidad"].ToString());
                    item.SubItems.Add(dr["Detalle"].ToString());
                    lvAuditoria.Items.Add(item);
                    count++;
                }
                lblTotalReg.Text = "Total: " + count + " registros";
            }
        }    }
}
