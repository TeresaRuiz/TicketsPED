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
            public string PrioridadUsuario { get; set; } // NUEVO
            public string PrioridadReal { get; set; } // NUEVO

            public Ticket(string id, string usuario, string detalle, string estado)
            {
                Id = id;
                Usuario = usuario;
                Detalle = detalle;
                Estado = estado;
                Fecha = DateTime.Now;
                Responsable = "Sistema";
                PrioridadUsuario = "Media";
                PrioridadReal = "Sin asignar";
            }

            public Ticket(string id, string usuario, string detalle, string estado, DateTime fecha, string responsable)
            {
                Id = id;
                Usuario = usuario;
                Detalle = detalle;
                Estado = estado;
                Fecha = fecha;
                Responsable = responsable;
                PrioridadUsuario = "Media";
                PrioridadReal = "Sin asignar";
            }

            public Ticket(string id, string usuario, string detalle, string estado, DateTime fecha,
                          string responsable, string prioridadUsuario, string prioridadReal)
            {
                Id = id;
                Usuario = usuario;
                Detalle = detalle;
                Estado = estado;
                Fecha = fecha;
                Responsable = responsable;
                PrioridadUsuario = prioridadUsuario;
                PrioridadReal = prioridadReal;
            }
        }
}
