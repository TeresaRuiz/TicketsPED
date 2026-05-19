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
using TicketsMDB.SuperAdmin;

namespace TicketsMDB
{
    public partial class FormInicioSesion : Form
    {
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

        Conexion conexion = new Conexion();
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection cn = null;
            try
            {
                cn = conexion.AbrirConexion();
                string contrasenaHash = Hashear(contrasena);
                string query = @"SELECT u.IdUsuario, u.Nombre, r.NombreRol, u.Bloqueado
                 FROM Usuarios u
                 INNER JOIN Roles r ON u.IdRol = r.IdRol
                 WHERE u.Usuario = @usuario AND u.Contrasena = @contrasena";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaHash);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool bloqueado = false;

                    if (reader["Bloqueado"] != DBNull.Value)
                    {
                        bloqueado = Convert.ToBoolean(reader["Bloqueado"]);
                    }

                    if (bloqueado)
                    {
                        reader.Close();

                        MessageBox.Show("Este usuario se encuentra bloqueado. Contacte al administrador.",
                            "Acceso denegado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }


                    // Guardar datos de sesión
                    SesionActual.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    SesionActual.Nombre = reader["Nombre"].ToString();
                    SesionActual.Rol = reader["NombreRol"].ToString();

                    reader.Close();

                    MessageBox.Show($"Bienvenido, {SesionActual.Nombre}!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirigir según rol
                    switch (SesionActual.Rol)
                    {
                        case "Admin":
                            new FormPrincipalAdmin().Show();
                            break;

                        case "SuperAdmin":
                            new FormSuperAdminDashboard().Show();
                            break;


                        case "Cliente":
                            new FormPrincipalCliente().Show();
                            break;

                        default:
                            MessageBox.Show("Rol no reconocido.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    this.Hide();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void RegistrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistroCliente ventanaRegistro  = new FormRegistroCliente();

            ventanaRegistro.Show();
            this.Hide();
        }
    }
}
