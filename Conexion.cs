using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB
{
    public class Conexion
    {
        public static string cadenaConexion = "Server=localhost;Database=BD_Tickets;Trusted_Connection=True;";

        public SqlConnection AbrirConexion()
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            return cn;
        }




        public void CerrarConexion(SqlConnection cn)
        {
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
                cn.Close();
        }
        public void LlenarListaDesdeSQL(TAD_Lista listaDestino)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    // Cambia 'Tickets' por el nombre real de tu tabla en SQL
                    string query = @"SELECT t.IdTicket, u.Nombre, t.Descripcion, e.NombreEstado 
                 FROM Tickets t 
                 INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario 
                 INNER JOIN Estados e ON t.IdEstado = e.IdEstado";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Ticket nuevo = new Ticket(
                            dr["IdTicket"].ToString(),    // ID real de la tabla
                            dr["Nombre"].ToString(),      // Nombre del usuario (del Join)
                            dr["Descripcion"].ToString(), // Descripción del ticket
                            dr["NombreEstado"].ToString() // Estado (Abierto/Cerrado)
                        );
                        listaDestino.Insertar(nuevo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        public void LlenarPilaDesdeSQL(TAD_Pila pila) // Quitamos el parámetro string idTicket
        {
            SqlConnection cn = AbrirConexion();
            try
            {
                // 1. Quitamos el WHERE para que traiga TODO
                // Usamos ORDER BY IdTicket ASC para que al hacer Push, 
                // el último ID creado quede arriba (Tope)
                string query = "SELECT IdTicket, IdUsuario, Titulo, Descripcion FROM Tickets ORDER BY IdTicket ASC";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                pila.VaciarPila();

                while (reader.Read())
                {
                    Ticket t = new Ticket(
                        reader["IdTicket"].ToString(),
                        reader["IdUsuario"].ToString(),
                        reader["Descripcion"].ToString(),
                        "Abierto"
                    );

                    pila.Push(t); // Cada ticket se apila uno sobre otro
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(cn);
            }
        }
        public DataTable ObtenerTicketsParaGrid() //QUITAR, se usó con el fin de mostrar los datos en el prototipo
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = AbrirConexion();

            try
            {
                // Traemos los campos principales
                string query = "SELECT IdTicket, IdUsuario, Titulo, Descripcion, IdEstado FROM Tickets";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);

                // El Adapter llena la tabla automáticamente
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar Grid: " + ex.Message);
            }
            finally
            {
                CerrarConexion(cn);
            }

            return tabla;
        }
    }
}
  