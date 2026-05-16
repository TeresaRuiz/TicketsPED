using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TicketsMDB
{
    public class HistorialTicket
    {
        Conexion db = new Conexion();

        // ESTRUCTURA DE DATOS PRINCIPAL
        public List<Ticket> listaTickets = new List<Ticket>();

        // =====================================
        // CARGAR TICKETS DESDE SQL
        // =====================================
        public void CargarTickets(int idUsuarioActual)
        {
            listaTickets.Clear();
            SqlConnection cn = null;

            try
            {
                cn = db.AbrirConexion();

                string query = @"
                SELECT 
                    t.IdTicket,
                    t.Titulo,
                    u.Nombre,
                    t.Descripcion,
                    e.NombreEstado,
                    t.FechaCreacion,
                    ISNULL(p1.NombrePrioridad, 'Media') AS PrioridadUsuario,
                    ISNULL(p2.NombrePrioridad, 'Sin asignar') AS PrioridadReal
                FROM Tickets t
                INNER JOIN Usuarios u ON t.IdUsuario = u.IdUsuario
                INNER JOIN Estados e ON t.IdEstado = e.IdEstado
                LEFT JOIN Prioridades p1 ON t.IdPrioridadUsuario = p1.IdPrioridad
                LEFT JOIN Prioridades p2 ON t.IdPrioridadReal = p2.IdPrioridad
                WHERE t.IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuarioActual);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Ensamblado perfecto siguiendo el orden del Constructor Completo Corregido de Ticket
                    Ticket t = new Ticket(
                        dr["IdTicket"].ToString(),                     // string id
                        dr["Nombre"].ToString(),                       // string usuario
                        dr["Titulo"].ToString(),                       // string titulo
                        dr["Descripcion"].ToString(),                  // string descripcion
                        dr["NombreEstado"].ToString(),                 // string estado
                        Convert.ToDateTime(dr["FechaCreacion"]),       // DateTime fecha
                        "Sistema",                                     // string responsable
                        dr["PrioridadUsuario"].ToString(),             // string prioridadUsuario
                        dr["PrioridadReal"].ToString()                 // string prioridadReal
                    );

                    listaTickets.Add(t);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al estructurar historial del usuario: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        // =====================================
        // FILTROS EN MEMORIA (LINQ)
        // =====================================

        // Todos
        public List<Ticket> ObtenerTodos()
        {
            return listaTickets;
        }

        // Abiertos
        public List<Ticket> ObtenerAbiertos()
        {
            return listaTickets.FindAll(t => t.Estado.Trim().Equals("Abierto", StringComparison.OrdinalIgnoreCase));
        }

        // En Proceso
        public List<Ticket> ObtenerEnProceso()
        {
            return listaTickets.FindAll(t => t.Estado.Trim().Equals("En proceso", StringComparison.OrdinalIgnoreCase));
        }

        // Cerrados
        public List<Ticket> ObtenerCerrados()
        {
            return listaTickets.FindAll(t => t.Estado.Trim().Equals("Cerrado", StringComparison.OrdinalIgnoreCase));
        }

        // =====================================
        // ACTUALIZACIONES DIRECTAS EN BASE DE DATOS
        // =====================================
        public bool ActualizarEstado(string idTicket, int nuevoEstado)
        {
            SqlConnection cn = null;
            try
            {
                cn = db.AbrirConexion();

                string query = @"
                UPDATE Tickets
                SET IdEstado = @Estado
                WHERE IdTicket = @IdTicket";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@IdTicket", idTicket);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }

        public bool ActualizarTicket(string idTicket, string titulo, int estado)
        {
            SqlConnection cn = null;
            try
            {
                cn = db.AbrirConexion();

                string query = @"
                UPDATE Tickets
                SET
                    Titulo = @Titulo,
                    IdEstado = @Estado
                WHERE IdTicket = @IdTicket";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@IdTicket", idTicket);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                db.CerrarConexion(cn);
            }
        }
    }
}