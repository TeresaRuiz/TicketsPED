using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsMDB
{
    public class GestionUsuario
    {
        public string Nombre { get; set; }
        public string UsuarioLogin { get; set; }
        public string Telefono { get; set; }

        public string Correo { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public bool Bloqueado { get; set; }

        // El único constructor de carga completa
        public GestionUsuario(string nombre, string usuarioLogin, string telefono, string correo, string password, string rol, bool bloqueado)
        {
            Nombre = nombre;
            UsuarioLogin = usuarioLogin;
            Telefono = telefono;
            Correo = correo;
            Password = password;
            Rol = rol;
            Bloqueado = bloqueado;
        }
    }
}
