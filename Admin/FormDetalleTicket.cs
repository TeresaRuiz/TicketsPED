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
    public partial class FormDetalleTicket : Form
    {
        private string ticketId;
        private Conexion con = new Conexion();

        public FormDetalleTicket(string id)
        {
            InitializeComponent();
            this.ticketId = id;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar detalles
            DataTable dt = con.ObtenerDetalleCompleto(int.Parse(ticketId));
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblID.Text = "TICKET #" + row["IdTicket"];
                lblUsuario.Text = "Solicitante: " + row["Usuario"];
                lblEstado.Text = "Estado actual: " + row["NombreEstado"];
                txtDescripcion.Text = row["Descripcion"].ToString();
            }

            // Cargar comentarios en el Grid
            dgvComentarios.DataSource = con.ObtenerComentarios(int.Parse(ticketId));
        }

        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoComentario.Text)) return;

            if (con.AgregarComentario(int.Parse(ticketId), 1, txtNuevoComentario.Text))
            {
                txtNuevoComentario.Clear();
                CargarDatos(); 
            }
        }
    }
}
