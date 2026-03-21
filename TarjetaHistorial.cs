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
    public partial class TarjetaHistorial : UserControl
    {
        public TarjetaHistorial(Ticket datos)
        {
            InitializeComponent();
            // Asignamos los datos a los labels que pusiste en el diseño
            lblEstado.Text = datos.Estado;
            lblFecha.Text = datos.Fecha.ToString("G"); // "G" da fecha y hora
            lblResponsable.Text = datos.Responsable;

            // Un toque de color según el estado
            if (datos.Estado == "ABIERTO") lblEstado.ForeColor = Color.Red;
            else if (datos.Estado == "EN PROCESO") lblEstado.ForeColor = Color.Orange;
        }
    }
}
