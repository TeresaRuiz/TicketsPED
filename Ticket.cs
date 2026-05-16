using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
   
        public class Ticket
        {
            public string Id { get; set; }
            public string Usuario { get; set; }
            public string Detalle { get; set; }
            public string Estado { get; set; }
            public DateTime Fecha { get; set; }
            public string Responsable { get; set; }
            public string Titulo { get; set; }
            public string PrioridadUsuario { get; set; } // NUEVO
            public string PrioridadReal { get; set; } // NUEVO
                                                      
    // 1. CONSTRUCTOR VACÍO (Indispensable para el manejo flexible en la Pila LIFO)
        public Ticket()
        {
            Fecha = DateTime.Now;
            Responsable = "Sistema";
            PrioridadUsuario = "Media";
            PrioridadReal = "Sin asignar";
        }

        // 2. CONSTRUCTOR BÁSICO (Para creación rápida en prototipos)
        public Ticket(string id, string usuario, string titulo, string descripcion, string estado)
        {
            Id = id;
            Usuario = usuario;
            Titulo = titulo;
            Detalle = descripcion;
            Estado = estado;
            Fecha = DateTime.Now;
            Responsable = "Sistema";
            PrioridadUsuario = "Media";
            PrioridadReal = "Sin asignar";
        }

        // 3. CONSTRUCTOR INTERMEDIO (Desde SQL sin prioridades explícitas)
        public Ticket(string id, string usuario, string titulo, string descripcion, string estado, DateTime fecha, string responsable)
        {
            Id = id;
            Usuario = usuario;
            Titulo = titulo;
            Detalle = descripcion;
            Estado = estado;
            Fecha = fecha;
            Responsable = responsable;
            PrioridadUsuario = "Media";
            PrioridadReal = "Sin asignar";
        }

        // 4. CONSTRUCTOR COMPLETO (El que usará tu clase Conexion para llenar los Grids y la Cola)
        public Ticket(string id, string usuario, string titulo, string descripcion, string estado, DateTime fecha,
                      string responsable, string prioridadUsuario, string prioridadReal)
        {
            Id = id;
            Usuario = usuario;
            Titulo = titulo;
            Detalle = descripcion;
            Estado = estado;
            Fecha = fecha;
            Responsable = responsable;
            PrioridadUsuario = prioridadUsuario;
            PrioridadReal = prioridadReal;
        }
    }
}
