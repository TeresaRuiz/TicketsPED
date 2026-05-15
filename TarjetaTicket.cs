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
    public partial class TarjetaTicket : UserControl
    {
       
        public Ticket InfoTicket { get; private set; }
        // Constructor que recibe el objeto Ticket
        public TarjetaTicket(Ticket datos)
        {
            InitializeComponent();

            // Llamamos a la función que llena los datos y pone los colores
            CargarDatos(datos);
            this.InfoTicket = datos; // Guardamos la referencia
            // Configuramos el aspecto de la tarjeta
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            // Esto ayuda a que no se vea pegada a las demás
            this.Margin = new Padding(10);
            AsignarEventoClicRecursivo(this);
        }
        private void AsignarEventoClicRecursivo(Control padre)
        {
            foreach (Control hijo in padre.Controls)
            {
                // Hacemos que el hijo use el mismo evento de clic que el padre
                hijo.Click += (s, e) => this.OnClick(e);

                // Si el hijo tiene más hijos dentro (como un Panel), también los cubrimos
                if (hijo.HasChildren)
                    AsignarEventoClicRecursivo(hijo);
            }
        }
        private void CargarDatos(Ticket datos)
        {
            // Usamos los nombres exactos de tus Labels del diseño
            lblID.Text = "Ticket: #" + datos.Id;
            lblUsuario.Text = "Usuario: " + datos.Usuario;
            lblDetalle.Text = "Descripcion:" + datos.Detalle;
            
            lblEstado.Text = "Estado: " + datos.Estado;

            // Lógica de colores según el nombre del estado en tu base BD_Tickets
            
            if (datos.Estado == "Abierto")
                lblEstado.ForeColor = Color.Red;
            else if (datos.Estado == "En proceso") 
                lblEstado.ForeColor = Color.Orange;
            else if (datos.Estado == "Cerrado")
                lblEstado.ForeColor = Color.Green;
            if (datos.PrioridadReal == "Alta")
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.FromArgb(255, 241, 242); 
                lblID.ForeColor = Color.Red;
            }
        }

        private void Tarjetatickets_Enter(object sender, EventArgs e)
        {

        }
    }
}
