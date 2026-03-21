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
    }
}
