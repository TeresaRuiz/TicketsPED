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

namespace TicketsMDB
{
    public partial class FormRegistroCliente : Form
    {

        Conexion conexion = new Conexion();
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
        public FormRegistroCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (nombre == "" || usuario == "" || correo == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Por favor, ingresa un correo válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection cn = null;
            try
            {
                cn = conexion.AbrirConexion();


                string queryInsertar = @"INSERT INTO Usuarios (Nombre, Usuario, Correo, Contrasena, IdRol)
                                  VALUES (@nombre, @usuario, @correo, @contrasena, 2)";
                SqlCommand cmdInsertar = new SqlCommand(queryInsertar, cn);
                cmdInsertar.Parameters.AddWithValue("@nombre", nombre);
                cmdInsertar.Parameters.AddWithValue("@usuario", usuario);
                cmdInsertar.Parameters.AddWithValue("@correo", correo);
                string contrasenaHash = Hashear(contrasena);
                cmdInsertar.Parameters.AddWithValue("@contrasena", contrasenaHash);

                int filas = cmdInsertar.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("¡Cliente registrado exitosamente!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormInicioSesion loginForm = new FormInicioSesion();
                    loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
