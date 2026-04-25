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
    public partial class VistaCola : UserControl
    {
        private TAD_Lista lista; // Para guardar la referencia

        //  Este es el constructor 
        public VistaCola()
        {
            InitializeComponent();
        }

        
        public VistaCola(TAD_Lista listaCompartida)
        {
            InitializeComponent();

            // Guardamos la lista que viene del FormPrincipal
            this.lista = listaCompartida;

            // Llamamos a un método para dibujar las tarjetas en horizontal
            actualizarColaEstatica();
        }

        public void actualizarColaEstatica()
        {
            pnlColaHorizontal.Controls.Clear();
            Nodo aux = this.lista.Inicio;

            while (aux != null)
            {
             
                //  Creamos la tarjeta visual
                TarjetaTicket tarjeta = new TarjetaTicket(aux.Dato);

                
                tarjeta.Margin = new Padding(20, 10, 20, 10);

                // 5. La agregamos al riel horizontal
                pnlColaHorizontal.Controls.Add(tarjeta);

                // Dibujamos la fecla sol sí (hay un siguiente nodo)
                if (aux.Siguiente != null)
                {
                    Label flecha = new Label();
                    flecha.Text = "➡";
                    flecha.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                    flecha.ForeColor = Color.Black; // full negro aaa
                    flecha.AutoSize = true;
                    flecha.Padding = new Padding(0, 80, 0, 0); // Ajusta esto para centrarla verticalmente
                    pnlColaHorizontal.Controls.Add(flecha);
                }

                // Saltamos al siguiente nodo de la lista
                aux = aux.Siguiente;
            }
        }

        private void VistaCola_Load(object sender, EventArgs e)
        {

        }

        private void pnlColaHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
