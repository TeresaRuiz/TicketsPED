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
    public partial class VistaHistorialPila : UserControl
    {
        private TAD_Pila pila;

        // 2. CONSTRUCTOR
        public VistaHistorialPila()
        {
            InitializeComponent();

            // 3. INICIALIZACIÓN
            // Creamos la instancia de la pila para que no sea null
            this.pila = new TAD_Pila();

            // 4. LLENADO DESDE SQL
            Conexion con = new Conexion();
            con.LlenarPilaDesdeSQL(this.pila);

            // 5. DIBUJO
            actualizarPantallaPila();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeshaer_Click(object sender, EventArgs e)
        {
            Ticket eliminado = this.pila.Pop(); // Quitamos de la RAM

            if (eliminado != null)
            {
                // AQUÍ PODÉS MANDAR EL DELETE A SQL LUEGO
                actualizarPantallaPila(); // Refrescamos la vista para que desaparezca la tarjeta
                MessageBox.Show("Se ha deshecho el cambio: " + eliminado.Estado);
            }
        }
        public void actualizarPantallaPila()
        {
            // Verificación de seguridad si no hay pila o panel, no hacemos nada
            if (this.pila == null || pnlContenedorPila == null) return;

            // Limpiamos el panel para no duplicar tarjetas al refrescar
            pnlContenedorPila.Controls.Clear();

                               
            // Usamos un nodo auxiliar para no perder la referencia original de la pila
            Nodo aux = this.pila.Tope;

            // Ciclo para recorrer la estructura LIFO
            while (aux != null)
            {
                
                // Le pasamos el 'Dato' que es el objeto Ticket del nodo actual
                TarjetaHistorial tarjeta = new TarjetaHistorial(aux.Dato);

                tarjeta.BackColor = Color.White;
                // Resaltar la primera tarjeta es opcional (el Cambio Más Reciente)
                if (aux == this.pila.Tope)
                {
                    tarjeta.BackColor = Color.FromArgb(230, 240, 255);
                    tarjeta.BorderStyle = BorderStyle.FixedSingle;// Un azulito muy claro
                                                                 
                }
                else
                {
                    tarjeta.BorderStyle = BorderStyle.None;
                }
                //  Agregamos la tarjeta al panel visual
                pnlContenedorPila.Controls.Add(tarjeta);

                //  Avanzamos al siguiente nodo (el que está "abajo" en la pila)
                aux = aux.Siguiente;
            }
        }
    }
}
