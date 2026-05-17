using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB.Clientes
{
    public partial class FormPerfil : UserControl
    {

        Conexion conexion = new Conexion();
        private string correoOriginal; //variable para almacenar el correo original del usuario

        public FormPerfil()
        {
            InitializeComponent();
            CargarDatosUsuario();
        }

        public string Hashear(string texto)
        {
            SHA256 sha = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(texto);
            byte[] hash = sha.ComputeHash(bytes);

            string resultado = "";

            for (int i = 0; i < hash.Length; i++)
            {
                resultado = resultado + hash[i].ToString("x2");
            }

            return resultado;
        }

        private void CargarDatosUsuario()
        {

            using (SqlConnection cn = conexion.AbrirConexion())
            {
                string query = "SELECT Nombre, Correo FROM Usuarios WHERE IdUsuario = @id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", SesionActual.IdUsuario);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombreCompleto = reader["Nombre"].ToString();
                    correoOriginal = reader["Correo"].ToString();

                    //llenar etiquetas superiores y textbox de correo
                    lblNombreCompleto.Text = nombreCompleto;
                    txtCorreoVal.Text = correoOriginal;

                    //logica para las iniciales
                    string[] partes = nombreCompleto.Split(' '); //partimos el nombre completo en partes (nombre, apellido)
                    lblInicialesGrande.Text = (partes.Length >= 2) //condicion: ¿nombre y apellido?
                        ? (partes[0][0].ToString().ToUpper() + partes[1][0].ToString().ToUpper()) //verdadero: iniciales de nombre y apellido
                        : nombreCompleto[0].ToString().ToUpper(); //falso: solo inicial del nombre

                    //dividir el nombre para los cuadros de edicion
                    txtNombre.Text = partes[0];
                    txtApellido.Text = partes.Length > 1 ? partes[1] : "";
                }
            }
        }

        private void btnGuardarCorreo_Click(object sender, EventArgs e)
        {

            string correoVal = txtCorreoVal.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtCorreoVal.Text))
            {
                MessageBox.Show("Por favor, completa el campo de correo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!txtCorreoVal.Text.Contains("@") || !txtCorreoVal.Text.Contains("."))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (correoVal == correoOriginal)
            {
                MessageBox.Show("No se han realizado cambios en el correo electrónico.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {
                using (SqlConnection cn = conexion.AbrirConexion())
                {
                    string queryVerificar = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @correo AND IdUsuario != @idUsuario";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, cn);
                    cmdVerificar.Parameters.AddWithValue("@correo", correoVal);
                    cmdVerificar.Parameters.AddWithValue("@idUsuario", SesionActual.IdUsuario);

                    int resultado = (int)cmdVerificar.ExecuteScalar();
                    if (resultado > 0)
                    {
                        MessageBox.Show("El correo electrónico ya está en uso por otro usuario.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string queryActualizar = "UPDATE Usuarios SET Correo = @correo WHERE IdUsuario = @idUsuario";
                    SqlCommand cmdActualizar = new SqlCommand(queryActualizar, cn);
                    cmdActualizar.Parameters.AddWithValue("@correo", correoVal);
                    cmdActualizar.Parameters.AddWithValue("@idUsuario", SesionActual.IdUsuario);

                    int filasAfectadas = cmdActualizar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                        CargarDatosUsuario(); //actualizamos formulario
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar los datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardarPass_Click(object sender, EventArgs e)
        {
            string contrasenaActual = txtPassActual.Text.Trim();
            string contrasenaNueva = txtPassNueva.Text.Trim();
            string contrasenaConf = txtPassConf.Text.Trim();

            if (string.IsNullOrWhiteSpace(contrasenaActual) || string.IsNullOrWhiteSpace(contrasenaNueva) || string.IsNullOrWhiteSpace(contrasenaConf))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(contrasenaNueva != contrasenaConf)
            {
                MessageBox.Show("La nueva contraseña y su confirmación no coinciden.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contrasenaNueva.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contrasenaActual == contrasenaNueva)
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la actual. Por favor, elige una diferente.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string contrasenaActualHash = Hashear(contrasenaActual);
            try
            {
                using (SqlConnection cn = conexion.AbrirConexion())
                {
                    string queryVerificar = "SELECT COUNT(*) FROM Usuarios WHERE IdUsuario = @idUsuario AND Contrasena = @contrasena";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, cn);
                    cmdVerificar.Parameters.AddWithValue("@idUsuario", SesionActual.IdUsuario);
                    cmdVerificar.Parameters.AddWithValue("@contrasena", contrasenaActualHash);
                    int resultado = (int)cmdVerificar.ExecuteScalar();
                    if (resultado == 0)
                    {
                        MessageBox.Show("La contraseña actual es incorrecta.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string contrasenaNuevaHash = Hashear(contrasenaNueva);
                    string queryActualizar = "UPDATE Usuarios SET Contrasena = @contrasenaNueva WHERE IdUsuario = @idUsuario";
                    SqlCommand cmdActualizar = new SqlCommand(queryActualizar, cn);
                    cmdActualizar.Parameters.AddWithValue("@contrasenaNueva", contrasenaNuevaHash);
                    cmdActualizar.Parameters.AddWithValue("@idUsuario", SesionActual.IdUsuario);
                    int filasAfectadas = cmdActualizar.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Contraseña actualizada correctamente.");
                        //limpiar campos
                        txtPassActual.Text = "";
                        txtPassNueva.Text = "";
                        txtPassConf.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
