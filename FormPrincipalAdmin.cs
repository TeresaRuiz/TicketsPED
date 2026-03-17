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
        public FormPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarControl(new Inicio());
        }

        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear(); // Limpia lo que había antes
            control.Dock = DockStyle.Fill;   // Que ocupe todo el espacio
            panelContenido.Controls.Add(control); // Lo agrega al panel
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

                // Cierra el formulario principal actual
                this.Hide();
                this.Close();
            }
        }
    }
}
