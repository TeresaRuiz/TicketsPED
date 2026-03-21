using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class Ticket
    {
        // Atributos del ticket
        public string Id { get; set; }
        public string Usuario { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        //fecha y responsables se añadieron para mostrar la parte de busqueda avanzada 
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }

        // CONSTRUCTOR
        // Se usa para cargar datos de la base de datos actual.
        // Como SQL solo nos da 4 datos, este constructor "inventa" la fecha y el responsable
        // para que las tarjetas de la interfaz no salgan vacías.
        public Ticket(string id, string usuario, string detalle, string estado)
        {
            Id = id;
            Usuario = usuario;
            Detalle = detalle;
            Estado = estado;
            // Llenamos estos con valores por defecto para que no queden nulos
            Fecha = DateTime.Now; 
            Responsable = "Sistema"; 
        }

        
        
        // Este es el modelo se creo de forma temporal para el area de busqueda avanzada
        // Recibe los 6 datos reales desde SQL (incluyendo fecha y encargado real).
        public Ticket(string id, string usuario, string detalle, string estado, DateTime fecha, string responsable)
        {
            Id = id;
            Usuario = usuario;
            Detalle = detalle;
            Estado = estado;
            Fecha = fecha;
            Responsable = responsable;
        }
    }
}
