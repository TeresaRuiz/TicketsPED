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
    public partial class FormPrincipalCliente : Form
    {
        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }
        public FormPrincipalCliente()
        {
            InitializeComponent();
        }

        private void btnRegistroTicket_Click(object sender, EventArgs e)
        {
            MostrarControl(new FormRegistroTicket());
        }

        private void btnRegistroTicket_Click_1(object sender, EventArgs e)
        {
            MostrarControl(new FormRegistroTicket());
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}
