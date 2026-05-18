using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsMDB.SuperAdmin;

namespace TicketsMDB
{
    public partial class TarjetaGestionUsuario : UserControl
    {
        private GestionUsuario _datos;

        public TarjetaGestionUsuario(GestionUsuario datos)
        {
            InitializeComponent();
            _datos = datos;

            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
            this.Cursor = Cursors.Hand;

            CargarDatos(datos);
            AsignarEventosClick(this);
        }

        private void CargarDatos(GestionUsuario datos)
        {
            lblNombre.Text = datos.Nombre;
            lblUsuario.Text = "@" + datos.UsuarioLogin;  // ajusta si el campo se llama diferente
            lblCorreo.Text = datos.Correo;
            lblRol.Text = datos.Rol;

            // Iniciales del avatar
            string[] partes = datos.Nombre.Trim().Split(' ');
            lblIniciales.Text = partes.Length >= 2
                ? $"{partes[0][0]}{partes[1][0]}".ToUpper()
                : datos.Nombre.Length >= 2
                    ? datos.Nombre.Substring(0, 2).ToUpper()
                    : datos.Nombre.ToUpper();

            // Color según rol
            if (datos.Rol == "Admin")
            {
                pnlBarra.BackColor = Color.FromArgb(124, 58, 237);
                lblRol.ForeColor = Color.FromArgb(124, 58, 237);
                lblRol.BackColor = Color.FromArgb(250, 245, 255);
                pnlAvatar.BackColor = Color.FromArgb(250, 245, 255);
                lblIniciales.ForeColor = Color.FromArgb(124, 58, 237);
            }
            else if (datos.Rol == "SuperAdmin")
            {
                pnlBarra.BackColor = Color.FromArgb(253, 224, 71);
                lblRol.ForeColor = Color.FromArgb(120, 80, 0);
                lblRol.BackColor = Color.FromArgb(254, 249, 195);
                pnlAvatar.BackColor = Color.FromArgb(254, 249, 195);
                lblIniciales.ForeColor = Color.FromArgb(120, 80, 0);
            }
            else // Cliente
            {
                pnlBarra.BackColor = Color.FromArgb(37, 99, 235);
                lblRol.ForeColor = Color.FromArgb(37, 99, 235);
                lblRol.BackColor = Color.FromArgb(239, 246, 255);
                pnlAvatar.BackColor = Color.FromArgb(239, 246, 255);
                lblIniciales.ForeColor = Color.FromArgb(37, 99, 235);
            }

            // Si está bloqueado
            if (datos.Bloqueado)
            {
                pnlBarra.BackColor = Color.FromArgb(220, 38, 38);
                lblNombre.ForeColor = Color.FromArgb(148, 163, 184);
                this.BackColor = Color.FromArgb(254, 242, 242);
                lblRol.Text = datos.Rol + "  🔒";
            }
        }

        public GestionUsuario ObtenerDatos()
        {
            return _datos;
        }

        private void AsignarEventosClick(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
                if (c.HasChildren) AsignarEventosClick(c);
            }
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}