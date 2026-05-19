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
    public partial class FormPrincipalAdmin : Form
    {

        TAD_Cola miColaCompartida = new TAD_Cola();

        public FormPrincipalAdmin()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            MostrarControl(new Inicio(miColaCompartida));
            lblUsuario.Text = "Usuario: " + SesionActual.Nombre;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            MostrarControl(new Inicio(miColaCompartida));
        }

        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }

      

        private void btnProductos_Click(object sender, EventArgs e)
        {


            MostrarControl(new VistaCola(miColaCompartida));
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            VistaBusquedaABB vistaBusqueda = new VistaBusquedaABB();

            
            MostrarControl(vistaBusqueda);
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            // Creamos la vista y le pasamos la Pila de datos
            VistaHistorialPila vistaPila = new VistaHistorialPila();
            MostrarControl(vistaPila);
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            var resultado = MessageBox.Show(
               "¿Seguro que deseas cerrar sesión?",
               "Confirmar cierre de sesión",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question


           );


            if (resultado == DialogResult.Yes)
            {

                // Muestra nuevamente el formulario de login
                FormInicioSesion login = new FormInicioSesion();
                login.Show();
                this.Hide();

            }
        }

        private void FormPrincipalAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {


            Application.Exit();
        }
    }
}
