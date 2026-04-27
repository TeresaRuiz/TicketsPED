using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB.SuperAdmin
{
    public partial class FormSuperAdminDashboard : Form
    {
        public FormSuperAdminDashboard()
        {
            InitializeComponent();
        }

        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }
       
        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarControl(new Inicio());
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            MostrarControl(new FormGestionUsuarios());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MostrarControl(new FormConfiguracionSistema());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MostrarControl(new FormAuditoria());
        }
    }
}
