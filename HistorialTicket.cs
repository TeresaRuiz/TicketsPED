using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TicketsMDB
{
    public class HistorialTicket
    {
        Conexion db = new Conexion();

       
        public TAD_Lista listaTickets = new TAD_Lista();

        
        public void CargarTickets(int idUsuarioActual)
        {
            listaTickets.VaciarLista();
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
                    Ticket t = new Ticket(
                        dr["IdTicket"].ToString(),
                        dr["Nombre"].ToString(),
                        dr["Titulo"].ToString(),
                        dr["Descripcion"].ToString(),
                        dr["NombreEstado"].ToString(),
                        Convert.ToDateTime(dr["FechaCreacion"]),
                        "Sistema",
                        dr["PrioridadUsuario"].ToString(),
                        dr["PrioridadReal"].ToString()
                    );

                    listaTickets.Insertar(t);
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

        public TAD_Lista ObtenerTodos()
        {
            return listaTickets;
        }

       
        public TAD_Lista ObtenerAbiertos()
        {
            TAD_Lista filtrada = new TAD_Lista();
            Nodo aux = listaTickets.Inicio;

            while (aux != null)
            {
                if (aux.Dato.Estado.Trim().Equals("Abierto", StringComparison.OrdinalIgnoreCase))
                {
                    filtrada.Insertar(aux.Dato);
                }
                aux = aux.Siguiente;
            }
            return filtrada;
        }

        
        public TAD_Lista ObtenerEnProceso()
        {
            TAD_Lista filtrada = new TAD_Lista();
            Nodo aux = listaTickets.Inicio;

            while (aux != null)
            {
                if (aux.Dato.Estado.Trim().Equals("En proceso", StringComparison.OrdinalIgnoreCase))
                {
                    filtrada.Insertar(aux.Dato);
                }
                aux = aux.Siguiente;
            }
            return filtrada;
        }

        public TAD_Lista ObtenerCerrados()
        {
            TAD_Lista filtrada = new TAD_Lista();
            Nodo aux = listaTickets.Inicio;

            while (aux != null)
            {
                if (aux.Dato.Estado.Trim().Equals("Cerrado", StringComparison.OrdinalIgnoreCase))
                {
                    filtrada.Insertar(aux.Dato);
                }
                aux = aux.Siguiente;
            }
            return filtrada;
        }

    
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