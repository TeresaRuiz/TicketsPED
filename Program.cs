using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexion conexion = new Conexion();
            SqlConnection cn = null;
            try
            {
                cn = conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios", cn);
                int total = (int)cmd.ExecuteScalar();

                if (total == 0)
                    Application.Run(new FormRegistro()); // Primer uso → registrar Admin
                else
                    Application.Run(new FormInicioSesion());    // Ya hay admin → ir al login
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }
        }
    }
}
