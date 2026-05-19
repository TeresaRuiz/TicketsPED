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
    public partial class FormRegistro : Form
    {
        Conexion conexion = new Conexion();
        public FormRegistro()
        {
            InitializeComponent();
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
        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (nombre == "" || usuario == "" || correo == "" || contrasena == "" || telefono == "")
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

            for (int i = 0; i < telefono.Length; i++)
            {
                if (i != 4)
                {
                    if (!char.IsDigit(telefono[i]))
                    {
                        MessageBox.Show("El teléfono solo debe contener números.");
                        return;
                    }
                }
            }
            if (telefono.Length != 9 || telefono[4] != '-')
            {
                MessageBox.Show("Formato inválido. Use ####-####");
                return;
            }

            SqlConnection cn = null;
            try
            {
                cn = conexion.AbrirConexion();


                // Insertar siempre como Admin (IdRol = 1)
                string queryInsertar = @"INSERT INTO Usuarios (Nombre, Usuario, Correo, Contrasena, Telefono, IdRol)
                                  VALUES (@nombre, @usuario, @correo, @contrasena, @telefono, 3)";
                SqlCommand cmdInsertar = new SqlCommand(queryInsertar, cn);
                cmdInsertar.Parameters.AddWithValue("@nombre", nombre);
                cmdInsertar.Parameters.AddWithValue("@usuario", usuario);
                cmdInsertar.Parameters.AddWithValue("@correo", correo);
                string contrasenaHash = Hashear(contrasena);
                cmdInsertar.Parameters.AddWithValue("@contrasena", contrasenaHash);
                cmdInsertar.Parameters.AddWithValue("@telefono", telefono);

                int filas = cmdInsertar.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("¡Administrador registrado exitosamente!", "Éxito",
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

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios", cn);
                int total = (int)cmd.ExecuteScalar();

                if (total == 0)
                    lblMensaje.Text = "⚠ No hay administradores registrados. \n" +
                        " ¡Sé el primero!";
                else
                    lblMensaje.Text = ""; // No debería llegar aquí, pero por seguridad
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al verificar usuarios: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexion(cn);
            }
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTelefono.Text.Length == 4 &&
                !txtTelefono.Text.Contains("-"))
            {
                txtTelefono.Text = txtTelefono.Text + "-";
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
        }

        private void FormRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
