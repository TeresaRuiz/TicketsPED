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

            // Configuramos el diseño base (estilo del equipo)
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
            this.Cursor = Cursors.Hand;

            CargarDatos(datos);
            AsignarEventosClick(this);
        }

        private void CargarDatos(GestionUsuario datos)
        {
            // Usamos los labels que diseñaste
            lblNombre.Text = datos.Nombre;
            lblCorreo.Text = datos.Correo;
            lblRol.Text = "Rol: " + datos.Rol;
            
            // Si el usuario está bloqueado, cambiamos el aspecto
            if (datos.Bloqueado)
            {
                lblNombre.ForeColor = Color.Gray;
                this.BackColor = Color.FromArgb(245, 245, 245); // Gris claro
            }
            else
            {
                lblNombre.ForeColor = Color.Black;
                this.BackColor = Color.White;
            }
        }

        // Método para devolver los datos al Form Principal
        public GestionUsuario ObtenerDatos()
        {
            return _datos;
        }

        // Esta función hace que, aunque toqués un Label o el Panel, el clic funcione
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