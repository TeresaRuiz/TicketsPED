using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace TicketsMDB.SuperAdmin
{
    public partial class FormGestionUsuarios : UserControl
    {
        private TAD_ListaUsuarios listaDeUsuarios = new TAD_ListaUsuarios();

        public FormGestionUsuarios()
        { 
            InitializeComponent();
            btnTodos.Click += (s, e) => FiltrarUsuariosPorCategoria("todos");
            btnAdmin.Click += (s, e) => FiltrarUsuariosPorCategoria("admin");
            btnCliente.Click += (s, e) => FiltrarUsuariosPorCategoria("cliente");
            btnBloqueados.Click += (s, e) => FiltrarUsuariosPorCategoria("bloqueados");
            
            CargarDesdeSQL();
            actualizarPantalla();
        }

        public void CargarDesdeSQL()
        {
            listaDeUsuarios.VaciarLista();
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                   
                    string query = @"SELECT u.Nombre, u.Usuario, u.Correo, u.Contrasena, r.NombreRol, u.Bloqueado, u.Telefono
                                     FROM Usuarios u 
                                     INNER JOIN Roles r ON u.IdRol = r.IdRol";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string nom = dr["Nombre"].ToString();
                        string usr = dr["Usuario"].ToString();
                        string tel = dr["Telefono"].ToString();
                        string em = dr["Correo"].ToString();
                        string pas = dr["Contrasena"].ToString();
                        string rol = dr["NombreRol"].ToString();
                        bool bloq = dr["Bloqueado"] != DBNull.Value ? Convert.ToBoolean(dr["Bloqueado"]) : false;
                        GestionUsuario nuevoU = new GestionUsuario(nom, usr, tel, em, pas, rol, bloq);
                        listaDeUsuarios.Insertar(nuevoU);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarPantalla()
        {
            flpUsuario.Controls.Clear();
            NodoUsuario aux = listaDeUsuarios.Primero;

            while (aux != null)
            {
                TarjetaGestionUsuario tarjeta = new TarjetaGestionUsuario(aux.Dato);

                tarjeta.Click += (s, e) =>
                {
                    GestionUsuario u = tarjeta.ObtenerDatos();
                    CargarDatosEnCampos(u);
                };

                flpUsuario.Controls.Add(tarjeta);
                aux = aux.Siguiente;
            }
        }

        private void CargarDatosEnCampos(GestionUsuario u)
        {
            string[] partes = u.Nombre.Split(' ');
            txtNombre.Text = partes[0];
            txtApellido.Text = partes.Length > 1 ? partes[1] : "";

            txtCorreo.Text = u.Correo;
            txtCorreo.ReadOnly = true;
            cmbRol.SelectedItem = u.Rol;
            chkBloqueado.Checked = u.Bloqueado;
            txtPassword.Text = "";
            txtTelefono.Text = u.Telefono;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Apellido y Correo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol para el usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo))
            {
                MessageBox.Show("Por favor, introduzca un correo electrónico válido (ejemplo@dominio.com).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patronTelefono = @"^[267][0-9]{3}-[0-9]{4}$";
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !Regex.IsMatch(txtTelefono.Text.Trim(), patronTelefono))
            {
                MessageBox.Show("Por favor, introduzca un número de teléfono válido con guion (ej: 7300-0000 o 2200-0000).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool actualizarPass = !string.IsNullOrWhiteSpace(txtPassword.Text);
            int idRol = cmbRol.SelectedIndex == 0 ? 1 : 2; 

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();

                   string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @em";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@em", txtCorreo.Text.Trim());
                    int existe = (int)checkCmd.ExecuteScalar();

                    bool esEdicion = txtCorreo.ReadOnly;
                    if (!esEdicion && existe > 0)
                    {
                        MessageBox.Show("¡Error! Este correo electrónico ya está registrado con otro usuario. Por favor, asigne un correo diferente.", "Correo Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (esEdicion && existe == 0)
                    {
                        MessageBox.Show("No se encontró el usuario original para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                     if (!esEdicion && !actualizarPass)
                    {
                        MessageBox.Show("Por favor, asigne una contraseña inicial para el nuevo usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string finalQuery;

                     if (esEdicion)
                    {
                        if (actualizarPass)
                        {
                            finalQuery = "UPDATE Usuarios SET Nombre = @nom, Contrasena = @pass, IdRol = @idrol, Telefono = @tel WHERE Correo = @em";
                        }
                        else
                        {
                            finalQuery = "UPDATE Usuarios SET Nombre = @nom, IdRol = @idrol, Telefono = @tel WHERE Correo = @em";
                        }
                    }
                    else
                    {
                        finalQuery = "INSERT INTO Usuarios (Nombre, Usuario, Correo, Contrasena, IdRol, Bloqueado, Telefono) " +
                                     "VALUES (@nom, @user, @em, @pass, @idrol, 0, @tel)";
                    }

                    SqlCommand cmd = new SqlCommand(finalQuery, con);

                 
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim() + " " + txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@idrol", idRol);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());

                    if (actualizarPass || !esEdicion)
                    {
                        string contrasenaHash = Hashear(txtPassword.Text);
                        cmd.Parameters.AddWithValue("@pass", contrasenaHash);
                    }

                    if (!esEdicion)
                    {
                        cmd.Parameters.AddWithValue("@user", txtNombre.Text.Trim().ToLower());
                    }

                    cmd.ExecuteNonQuery();

                    string mensajeExito = esEdicion ? "¡Usuario actualizado exitosamente en SQL Server!" : "¡Usuario guardado exitosamente en SQL Server!";
                    MessageBox.Show(mensajeExito, "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   if (esEdicion)
                    {
                        var actual = listaDeUsuarios.Primero;
                        while (actual != null)
                        {
                            if (actual.Dato.Correo == txtCorreo.Text.Trim())
                            {
                                actual.Dato.Nombre = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
                                actual.Dato.Telefono = txtTelefono.Text.Trim();
                                actual.Dato.Rol = cmbRol.SelectedItem.ToString();

                                if (actualizarPass)
                                {
                                    actual.Dato.Password = txtPassword.Text;
                                }
                                break;
                            }
                            actual = actual.Siguiente;
                        }
                    }
                    else
                    {
                        GestionUsuario nuevoU = new GestionUsuario(
                            txtNombre.Text.Trim() + " " + txtApellido.Text.Trim(),
                            txtNombre.Text.Trim().ToLower(),
                            txtTelefono.Text.Trim(),
                            txtCorreo.Text.Trim(),
                            txtPassword.Text,
                            cmbRol.SelectedItem.ToString(),
                            false
                        );
                        listaDeUsuarios.Insertar(nuevoU);
                    }

                    limpiarCampos();
                    CargarDesdeSQL();
                    actualizarPantalla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación: " + ex.Message, "Error de SQL/Estructuras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text)) return;

            if (MessageBox.Show("¿Está seguro que desea eliminar este usuario del sistema?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                    {
                        con.Open();
                        string query = "DELETE FROM Usuarios WHERE Correo = @em";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@em", txtCorreo.Text.Trim());
                        cmd.ExecuteNonQuery();

                        limpiarCampos();
                        CargarDesdeSQL();
                        actualizarPantalla();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede eliminar el usuario porque tiene registros asociados (como tickets abiertos o asignados) en el sistema.", "Restricción de Integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkBloqueado_CheckedChanged(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtCorreo.Text)) return;

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    string query = "UPDATE Usuarios SET Bloqueado = @bloq WHERE Correo = @em";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bloq", chkBloqueado.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@em", txtCorreo.Text.Trim());

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        CargarDesdeSQL();
                        actualizarPantalla();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estado de bloqueo: " + ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtCorreo.ReadOnly = false;
            txtPassword.Clear();
            txtTelefono.Clear();
            cmbRol.SelectedIndex = -1;
            chkBloqueado.Checked = false;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void BuscarUsuariosEnLista(string textoBusqueda)
        {
            flpUsuario.Controls.Clear();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                actualizarPantalla();
                return;
            }

            string busqueda = textoBusqueda.Trim().ToLower();
            var actual = listaDeUsuarios.Primero;
            bool seEncontroAlgo = false;

            while (actual != null)
            {
                GestionUsuario usuario = actual.Dato;

                if (usuario.Nombre.ToLower().Contains(busqueda) || usuario.Correo.ToLower().Contains(busqueda))
                {
                    TarjetaGestionUsuario tarjeta = new TarjetaGestionUsuario(usuario);
                    tarjeta.Click += (s, ev) => CargarDatosEnCampos(usuario);

                    flpUsuario.Controls.Add(tarjeta);
                    seEncontroAlgo = true;
                }
                actual = actual.Siguiente;
            }

            if (!seEncontroAlgo)
            {
                Label lblNoResultados = new Label();
                lblNoResultados.Text = "No se encontraron usuarios que coincidan.";
                lblNoResultados.AutoSize = true;
                lblNoResultados.ForeColor = Color.Gray;
                lblNoResultados.Font = new Font("Segoe UI", 10, FontStyle.Italic);
                flpUsuario.Controls.Add(lblNoResultados);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuariosEnLista(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                actualizarPantalla();
            }
            else
            {
                BuscarUsuariosEnLista(txtBuscar.Text);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números, el guion (-) y teclas de control como borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Bloquea la tecla
            }

            // Evita que metan más de un guion seguido
            if (e.KeyChar == '-' && txtTelefono.Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite letras, teclas de control (como borrar) y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla y no la deja pintarse en la caja
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla y no deja que se escriba el espacio
            }
        }

        private void FiltrarUsuariosPorCategoria(string categoria)
        {
            flpUsuario.Controls.Clear();
            NodoUsuario actual = listaDeUsuarios.Primero;

            while (actual != null)
            {
                GestionUsuario usuario = actual.Dato;
                bool cumpleCondicion = false;

                switch (categoria.ToLower())
                {
                    case "todos":
                        cumpleCondicion = true;
                        break;
                    case "admin":
                        if (usuario.Rol.ToLower() == "admin" || usuario.Rol.ToLower() == "administrador")
                            cumpleCondicion = true;
                        break;
                    case "cliente":
                        if (usuario.Rol.ToLower() == "cliente")
                            cumpleCondicion = true;
                        break;
                    case "bloqueados":
                        if (usuario.Bloqueado == true)
                            cumpleCondicion = true;
                        break;
                }

                if (cumpleCondicion)
                {
                    TarjetaGestionUsuario tarjeta = new TarjetaGestionUsuario(usuario);
                    tarjeta.Click += (s, e) => CargarDatosEnCampos(usuario);
                    flpUsuario.Controls.Add(tarjeta);
                }
                actual = actual.Siguiente;
            }
        }

        private void lblApellidoLbl_Click(object sender, EventArgs e)
        {

        }
    }
     
}
