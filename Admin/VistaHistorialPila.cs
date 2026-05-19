using System;
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
        private Conexion con = new Conexion();

        public VistaHistorialPila()
        {
            InitializeComponent();
            this.pila = new TAD_Pila();
            CargarPilaGlobal();
        }

        private void CargarPilaGlobal()
        {
            this.pila.VaciarPila();
            con.LlenarPilaDesdeSQL(this.pila);
            actualizarPantallaPila();
        }
        

        private void btnDeshaer_Click(object sender, EventArgs e)
        {
            Ticket eliminado = this.pila.Pop();

            if (eliminado != null)
            {
                // Revertir el estado físico en SQL
                int idTicketTarget = int.Parse(eliminado.Id);
                string valorAnterior = eliminado.Responsable; // Almacenado en la pila

                if (eliminado.Titulo == "IdEstado")
                {
                    int idEstadoViejo = valorAnterior == "Abierto" ? 1 : valorAnterior == "En proceso" ? 2 : 3;
                    con.CambiarEstadoTicket(idTicketTarget, idEstadoViejo);
                }
                else if (eliminado.Titulo == "IdPrioridadReal")
                {
                    int idPrioridadVieja = valorAnterior == "Baja" ? 1 : valorAnterior == "Media" ? 2 : 3;
                    con.CambiarPrioridadReal(idTicketTarget, idPrioridadVieja);
                }

                // Borrar el registro correspondiente del historial de auditoría
                con.EliminarRegistroHistorial(int.Parse(eliminado.Usuario));

                MessageBox.Show($"Se ha deshecho con éxito el cambio del ticket #{eliminado.Id}. Regresó a '{valorAnterior}'.", "Deshecho exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPilaGlobal();
            }
            else
            {
                MessageBox.Show("No existen más acciones de trazabilidad en la pila global.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void actualizarPantallaPila()
        {
            if (this.pila == null || pnlContenedorPila == null) return;

            pnlContenedorPila.Controls.Clear();
            Nodo aux = this.pila.Tope;

            bool esPrimero = true;
            while (aux != null)
            {
                TarjetaHistorial tarjeta = new TarjetaHistorial(aux.Dato);
                tarjeta.Width = pnlContenedorPila.Width - 25;

                tarjeta.OnTarjetaDoubleClic += (idTicketSeleccionado) =>
                {
                    TicketsMDB.Admin.DetalleTicket frmDetalle = new TicketsMDB.Admin.DetalleTicket(idTicketSeleccionado);
                    frmDetalle.ShowDialog();    CargarPilaGlobal();
                };

                if (esPrimero)
                {
                    tarjeta.BackColor = Color.FromArgb(239, 246, 255);
                    tarjeta.BorderStyle = BorderStyle.FixedSingle;

                    label4.Text = $"#TK-{int.Parse(aux.Dato.Id):D4}";
                    label3.Text = aux.Dato.Estado.ToUpper();
                    esPrimero = false;
                }
                else
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.BorderStyle = BorderStyle.None;
                }

                pnlContenedorPila.Controls.Add(tarjeta);
                aux = aux.Siguiente;
            }

            if (this.pila.Tope == null)
            {
                label4.Text = "—";
                label3.Text = "SIN CAMBIOS";
            }
        }
    }
}
