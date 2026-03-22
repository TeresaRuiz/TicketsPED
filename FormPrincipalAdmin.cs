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
        // Creamos la lista global para todo el formulario
        TAD_Lista miListaCompartida = new TAD_Lista();

        public FormPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // ¡ESTE ES EL CAMBIO CLAVE! 
            // Llamamos al constructor que SI carga los datos
            MostrarControl(new Inicio(miListaCompartida));
        }

        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            /* VistaCola pantallaCola = new VistaCola(miListaCompartida);
             MostrarControl(pantallaCola);*/

            MostrarControl(new VistaCola(miListaCompartida));
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
    }
}
