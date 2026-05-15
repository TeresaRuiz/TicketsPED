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

        public void CambiarEstadoTicket(int idTicket, int idEstado)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = "UPDATE Tickets SET IdEstado = @idEstado WHERE IdTicket = @idTicket";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@idEstado", idEstado);
                cmd.Parameters.AddWithValue("@idTicket", idTicket);

                cmd.ExecuteNonQuery();
            }
        }


        public DataTable ObtenerTicketsOrdenados(string opcion)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string orden = "t.IdTicket ASC";

                if (opcion == "VER TICKET RECIENTE")
                {
                    orden = "t.IdTicket DESC";
                }
                else if (opcion == "VER TICKET MAS VIEJO")
                {
                    orden = "t.IdTicket ASC";
                }

                string query = @"
        SELECT
            t.IdTicket,
            u.Nombre,
            t.Titulo,
            t.Descripcion,
            e.NombreEstado
        FROM Tickets t
        INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario
        INNER JOIN Estados e ON t.IdEstado = e.IdEstado
        ORDER BY " + orden;

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable ObtenerTicketsParaGrid() //QUITAR, se usó con el fin de mostrar los datos en el prototipo
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = AbrirConexion();

            try
            {
                // Traemos los campos principales
                string query = "SELECT t.IdTicket, u.Nombre, t.Titulo, t.Descripcion, e.NombreEstado FROM Tickets t INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario INNER JOIN Estados e ON t.IdEstado = e.IdEstado";
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

        // Dentro de la clase Conexion en Conexion.cs

        public bool AsignarResponsable(int idTicket, string nombreResponsable)
        {
           try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    string query = @"INSERT INTO HistorialCambios (IdTicket, IdAdmin, CampoModificado, ValorNuevo) 
                             VALUES (@idT, 1, 'Responsable', @resp)"; // Usamos IdAdmin=1 como ejemplo
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idT", idTicket);
                    cmd.Parameters.AddWithValue("@resp", nombreResponsable);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool CambiarPrioridadReal(int idTicket, int idPrioridad)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    string query = "UPDATE Tickets SET IdPrioridadReal = @prio WHERE IdTicket = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@prio", idPrioridad);
                    cmd.Parameters.AddWithValue("@id", idTicket);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // Obtener información detallada de un ticket (con nombres en lugar de IDs)
        public DataTable ObtenerDetalleCompleto(int idTicket)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = @"SELECT t.IdTicket, u.Nombre as Usuario, t.Titulo, t.Descripcion, 
                         t.FechaCreacion, e.NombreEstado, p1.NombrePrioridad as PrioridadUsuario, 
                         p2.NombrePrioridad as PrioridadReal
                         FROM Tickets t
                         INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario
                         INNER JOIN Estados e ON t.IdEstado = e.IdEstado
                         INNER JOIN Prioridades p1 ON t.IdPrioridadUsuario = p1.IdPrioridad
                         LEFT JOIN Prioridades p2 ON t.IdPrioridadReal = p2.IdPrioridad
                         WHERE t.IdTicket = @id";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@id", idTicket);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Obtener comentarios de un ticket
        public DataTable ObtenerComentarios(int idTicket)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = @"SELECT c.Comentario, c.Fecha, u.Nombre 
                         FROM Comentarios c 
                         INNER JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                         WHERE c.IdTicket = @id ORDER BY c.Fecha DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@id", idTicket);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Guardar nuevo comentario
        public bool AgregarComentario(int idTicket, int idUsuario, string texto)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    string query = "INSERT INTO Comentarios (IdTicket, IdUsuario, Comentario) VALUES (@idT, @idU, @txt)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idT", idTicket);
                    cmd.Parameters.AddWithValue("@idU", idUsuario);
                    cmd.Parameters.AddWithValue("@txt", texto);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }
    }
}
  