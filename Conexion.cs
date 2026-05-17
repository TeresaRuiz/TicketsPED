using System;
using System.Data;
using System.Data.SqlClient;
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
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
public void LlenarListaDesdeSQL(TAD_Lista listaDestino)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    // Consulta completa incluyendo Título y nombres descriptivos de Prioridades
                    string query = @"
                        SELECT 
                            t.IdTicket, 
                            u.Nombre AS Usuario, 
                            t.Titulo, 
                            t.Descripcion, 
                            e.NombreEstado,
                            t.FechaCreacion,
                            p1.NombrePrioridad AS PrioridadUsuario,
                            ISNULL(p2.NombrePrioridad, 'Sin asignar') AS PrioridadReal
                        FROM Tickets t 
                        INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario 
                        INNER JOIN Estados e ON t.IdEstado = e.IdEstado
                        INNER JOIN Prioridades p1 ON t.IdPrioridadUsuario = p1.IdPrioridad
                        LEFT JOIN Prioridades p2 ON t.IdPrioridadReal = p2.IdPrioridad
                        WHERE t.IdEstado <> 3"; // Evitamos cargar tickets cerrados en la cola activa

                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        // Invocación al constructor completo corregido de tu clase Ticket
                        Ticket nuevo = new Ticket(
                            dr["IdTicket"].ToString(),
                            dr["Usuario"].ToString(),
                            dr["Titulo"].ToString(),
                            dr["Descripcion"].ToString(),
                            dr["NombreEstado"].ToString(),
                            Convert.ToDateTime(dr["FechaCreacion"]),
                            "Soporte",
                            dr["PrioridadUsuario"].ToString(),
                            dr["PrioridadReal"].ToString()
                        );
                        listaDestino.Insertar(nuevo);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en la Lista Enlazada (Cola): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         public void LlenarPilaDesdeSQL(TAD_Pila pila)
        {
            SqlConnection cn = AbrirConexion();
            try
            {
                // Obtenemos las trazas ordenadas por fecha cronológica para que al hacer Push, el tope sea el más reciente (LIFO)
                string query = "SELECT IdHistorial, IdTicket, CampoModificado, ValorAnterior, ValorNuevo FROM HistorialCambios ORDER BY FechaCambio ASC";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                pila.VaciarPila();

                while (reader.Read())
                {
                    // Usamos el constructor vacío de Ticket y mapeamos los campos de la traza para su dibujo
                    Ticket t = new Ticket();
                    t.Usuario = reader["IdHistorial"].ToString();   // ID de auditoría para borrado físico
                    t.Id = reader["IdTicket"].ToString();            // ID del Ticket modificado
                    t.Titulo = reader["CampoModificado"].ToString(); // "IdEstado" o "IdPrioridadReal"
                    t.Responsable = reader["ValorAnterior"].ToString();
                    t.Estado = reader["ValorNuevo"].ToString();

                    pila.Push(t);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar la Pila de Trazabilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CerrarConexion(cn);
            }
        }
        public DataTable ObtenerHistorialCambios(int idTicket)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = AbrirConexion())
            {
                string query = "SELECT IdHistorial, CampoModificado, ValorAnterior, ValorNuevo, FechaCambio FROM HistorialCambios WHERE IdTicket = @id ORDER BY FechaCambio DESC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idTicket);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void RegistrarCambioHistorial(int idTicket, int idAdmin, string campo, string anterior, string nuevo)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = "INSERT INTO HistorialCambios (IdTicket, IdAdmin, CampoModificado, ValorAnterior, ValorNuevo, FechaCambio) VALUES (@idT, @idA, @campo, @ant, @nue, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idT", idTicket);
                cmd.Parameters.AddWithValue("@idA", idAdmin);
                cmd.Parameters.AddWithValue("@campo", campo);
                cmd.Parameters.AddWithValue("@ant", anterior);
                cmd.Parameters.AddWithValue("@nue", nuevo);
                cmd.ExecuteNonQuery();
            }
        }

        public bool EliminarRegistroHistorial(int idHistorial)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = "DELETE FROM HistorialCambios WHERE IdHistorial = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idHistorial);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ObtenerDetalleCompleto(int idTicket)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = @"
                    SELECT 
                        t.IdTicket, 
                        u.Nombre AS Usuario, 
                        t.Titulo, 
                        t.Descripcion, 
                        t.FechaCreacion, 
                        e.NombreEstado, 
                        p1.NombrePrioridad AS NombrePrioridadUsuario, 
                        ISNULL(p2.NombrePrioridad, 'Sin asignar') AS NombrePrioridadReal
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

        public DataTable ObtenerComentarios(int idTicket)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string query = @"
                    SELECT c.Comentario, c.Fecha, u.Nombre 
                    FROM Comentarios c 
                    INNER JOIN Usuarios u ON c.IdUsuario = u.IdUsuario
                    WHERE c.IdTicket = @id 
                    ORDER BY c.Fecha DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@id", idTicket);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

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

        // ════════════════════════════════════════════════════════
        // INTERFAZ: CONSULTAS COMPATIBLES CON DATAGRIDVIEW (BÚSQUEDA)
        // ════════════════════════════════════════════════════════
        public DataTable ObtenerTicketsParaGrid()
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = AbrirConexion();
            try
            {
                string query = @"
                    SELECT 
                        t.IdTicket, 
                        u.Nombre, 
                        t.Titulo, 
                        t.Descripcion, 
                        e.NombreEstado 
                    FROM Tickets t 
                    INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario 
                    INNER JOIN Estados e ON t.IdEstado = e.IdEstado";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar DataGridView: " + ex.Message);
            }
            finally
            {
                CerrarConexion(cn);
            }
            return tabla;
        }

        public DataTable ObtenerTicketsOrdenados(string opcion)
        {
            using (SqlConnection cn = AbrirConexion())
            {
                string orden = "t.IdTicket ASC";
                if (opcion == "VER TICKET RECIENTE") orden = "t.IdTicket DESC";

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

        // ════════════════════════════════════════════════════════
        // ACTUALIZACIONES DIRECTAS DE ATRIBUTOS (DML)
        // ════════════════════════════════════════════════════════
        public bool CambiarEstadoTicket(int idTicket, int idEstado)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    string query = "UPDATE Tickets SET IdEstado = @idEstado WHERE IdTicket = @idTicket";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idEstado", idEstado);
                    cmd.Parameters.AddWithValue("@idTicket", idTicket);
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

        public bool AsignarResponsable(int idTicket, string nombreResponsable)
        {
            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    string query = @"INSERT INTO HistorialCambios (IdTicket, IdAdmin, CampoModificado, ValorAnterior, ValorNuevo) 
                                     VALUES (@idT, 1, 'Responsable', 'Ninguno', @resp)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idT", idTicket);
                    cmd.Parameters.AddWithValue("@resp", nombreResponsable);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }
    }
}