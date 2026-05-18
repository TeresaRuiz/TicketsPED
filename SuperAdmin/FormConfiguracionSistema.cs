using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB.SuperAdmin
{
    public partial class FormConfiguracionSistema : UserControl
    {
        public class NodoEstado
        {
            public ConfigEstado Dato { get; set; }
            public NodoEstado Siguiente { get; set; }
            public NodoEstado(ConfigEstado dato) { Dato = dato; Siguiente = null; }
        }
        private NodoEstado primeroEstado = null;
        private int idEstadoSeleccionado = 0;

        public class NodoPrioridad
        {
            public ConfigPrioridad Dato { get; set; }
            public NodoPrioridad Siguiente { get; set; }
            public NodoPrioridad(ConfigPrioridad dato) { Dato = dato; Siguiente = null; }
        }
        private NodoPrioridad primeroPrioridad = null;
        private int idPrioridadSeleccionado = 0;

        public class NodoRol
        {
            public ConfigRol Dato { get; set; }
            public NodoRol Siguiente { get; set; }
            public NodoRol(ConfigRol dato) { Dato = dato; Siguiente = null; }
        }
        private NodoRol primeroRol = null;
        private int idRolSeleccionado = 0;

        public FormConfiguracionSistema()
        {
            InitializeComponent();
            CargarEstados();
            CargarPrioridades();
            CargarRoles();
        }


        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEstado.Text))
            {
                MessageBox.Show("Por favor, escriba el nombre del estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idEstadoSeleccionado == 0) 
            {
                var actual = primeroEstado;
                while (actual != null)
                {
                    if (actual.Dato.NombreEstado.ToLower() == txtNombreEstado.Text.Trim().ToLower())
                    {
                        MessageBox.Show("Este estado ya existe en el catálogo actual.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    actual = actual.Siguiente;
                }
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    string query;

                    if (idEstadoSeleccionado > 0)
                        query = "UPDATE Estados SET NombreEstado = @nom WHERE IdEstado = @id";
                    else
                        query = "INSERT INTO Estados (NombreEstado) VALUES (@nom)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", txtNombreEstado.Text.Trim());

                    if (idEstadoSeleccionado > 0)
                        cmd.Parameters.AddWithValue("@id", idEstadoSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estado guardado correctamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnNuevoEstado_Click(null, null);
                    CargarEstados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el estado: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoEstado_Click(object sender, EventArgs e)
        {
            idEstadoSeleccionado = 0;
            txtNombreEstado.Text = "";
            txtNombreEstado.Focus();
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            if (idEstadoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione de la lista el estado que desea eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este estado del sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                    {
                        con.Open();
                        string query = "DELETE FROM Estados WHERE IdEstado = @id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idEstadoSeleccionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Estado eliminado exitosamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNuevoEstado_Click(null, null);
                        CargarEstados();
                    }
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar este estado porque ya está asociado a tickets existentes.", "Restricción de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarEstados()
        {
            primeroEstado = null;
            lvEstados.Items.Clear();

            string query = "SELECT IdEstado, NombreEstado FROM Estados";
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["IdEstado"]);
                        string nom = dr["NombreEstado"].ToString();
                        ConfigEstado nuevoE = new ConfigEstado(id, nom);

                        NodoEstado nuevoNodo = new NodoEstado(nuevoE);
                        nuevoNodo.Siguiente = primeroEstado;
                        primeroEstado = nuevoNodo;
                    }
                }

                NodoEstado actual = primeroEstado;
                while (actual != null)
                {
                    ListViewItem item = new ListViewItem(actual.Dato.IdEstado.ToString());
                    item.SubItems.Add(actual.Dato.NombreEstado);
                    item.Tag = actual.Dato;
                    lvEstados.Items.Add(item);
                    actual = actual.Siguiente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados: " + ex.Message, "Error SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEstados.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = lvEstados.SelectedItems[0];
                ConfigEstado estado = (ConfigEstado)itemSeleccionado.Tag;
                idEstadoSeleccionado = estado.IdEstado;
                txtNombreEstado.Text = estado.NombreEstado;
            }
        }


        private void lvPrioridades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrioridades.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = lvPrioridades.SelectedItems[0];
                ConfigPrioridad prioridad = (ConfigPrioridad)itemSeleccionado.Tag;
                idPrioridadSeleccionado = prioridad.IdPrioridad; 
                txtNombrePrioridad.Text = prioridad.NombrePrioridad;
            }
        }

        private void CargarPrioridades()
        {
            primeroPrioridad = null;
            lvPrioridades.Items.Clear();

            string query = "SELECT IdPrioridad, NombrePrioridad FROM Prioridades";
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["IdPrioridad"]);
                        string nom = dr["NombrePrioridad"].ToString();
                        ConfigPrioridad nuevaP = new ConfigPrioridad(id, nom);

                        NodoPrioridad nuevoNodo = new NodoPrioridad(nuevaP);
                        nuevoNodo.Siguiente = primeroPrioridad;
                        primeroPrioridad = nuevoNodo;
                    }
                }

                NodoPrioridad actual = primeroPrioridad;
                while (actual != null)
                {
                    ListViewItem item = new ListViewItem(actual.Dato.IdPrioridad.ToString());
                    item.SubItems.Add(actual.Dato.NombrePrioridad);
                    item.Tag = actual.Dato;
                    lvPrioridades.Items.Add(item);
                    actual = actual.Siguiente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las prioridades: " + ex.Message, "Error SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPrioridad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePrioridad.Text))
            {
                MessageBox.Show("Por favor, escriba el nombre de la prioridad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idPrioridadSeleccionado == 0)
            {
                var actual = primeroPrioridad;
                while (actual != null)
                {
                    if (actual.Dato.NombrePrioridad.ToLower() == txtNombrePrioridad.Text.Trim().ToLower())
                    {
                        MessageBox.Show("Esta prioridad ya existe en el sistema.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    actual = actual.Siguiente;
                }
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    string query;

                    if (idPrioridadSeleccionado > 0)
                        query = "UPDATE Prioridades SET NombrePrioridad = @nom WHERE IdPrioridad = @id";
                    else
                        query = "INSERT INTO Prioridades (NombrePrioridad) VALUES (@nom)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", txtNombrePrioridad.Text.Trim());

                    if (idPrioridadSeleccionado > 0)
                        cmd.Parameters.AddWithValue("@id", idPrioridadSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prioridad guardada correctamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idPrioridadSeleccionado = 0;
                    txtNombrePrioridad.Text = "";
                    CargarPrioridades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la prioridad: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPrioridad_Click(object sender, EventArgs e)
        {
            if (idPrioridadSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione una prioridad de la lista para eliminar.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar esta prioridad? Esto podría fallar si está asignada a un ticket.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                    {
                        con.Open();
                        string query = "DELETE FROM Prioridades WHERE IdPrioridad = @id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idPrioridadSeleccionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Prioridad velocidad eliminada correctamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idPrioridadSeleccionado = 0;
                        txtNombrePrioridad.Text = "";
                        CargarPrioridades();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede eliminar la prioridad porque está siendo utilizada en el sistema: " + ex.Message, "Error de Integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoPrioridad_Click(object sender, EventArgs e)
        {
            idPrioridadSeleccionado = 0;
            txtNombrePrioridad.Text = "";
            lvPrioridades.SelectedItems.Clear();
        }

        private void CargarRoles()
        {
            primeroRol = null;
            lvRoles.Items.Clear();

            string query = "SELECT IdRol, NombreRol, DescripcionRol FROM Roles";
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["IdRol"]);
                        string nom = dr["NombreRol"].ToString();
                        string desc = dr["DescripcionRol"].ToString();

                        ConfigRol nuevoR = new ConfigRol(id, nom, desc);
                        NodoRol nuevoNodo = new NodoRol(nuevoR);
                        nuevoNodo.Siguiente = primeroRol;
                        primeroRol = nuevoNodo;
                    }
                }

                NodoRol actual = primeroRol;
                while (actual != null)
                {
                    ListViewItem item = new ListViewItem(actual.Dato.IdRol.ToString());
                    item.SubItems.Add(actual.Dato.NombreRol);
                    item.SubItems.Add(actual.Dato.Descripcion);
                    item.Tag = actual.Dato;
                    lvRoles.Items.Add(item);
                    actual = actual.Siguiente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("Por favor, escriba el nombre del rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idRolSeleccionado == 0)
            {
                var actualRol = primeroRol;
                while (actualRol != null)
                {
                    if (actualRol.Dato.NombreRol.ToLower() == txtNombreRol.Text.Trim().ToLower())
                    {
                        MessageBox.Show("Este rol ya se encuentra registrado en el sistema.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    actualRol = actualRol.Siguiente;
                }
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                {
                    con.Open();
                    string query;

                    if (idRolSeleccionado > 0)
                        query = "UPDATE Roles SET NombreRol = @nom, DescripcionRol = @desc WHERE IdRol = @id";
                    else
                        query = "INSERT INTO Roles (NombreRol, DescripcionRol) VALUES (@nom, @desc)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", txtNombreRol.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescripcionRol.Text.Trim());

                    if (idRolSeleccionado > 0)
                        cmd.Parameters.AddWithValue("@id", idRolSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rol guardado correctamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnNuevoRol_Click(null, null);
                    CargarRoles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el rol: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = lvRoles.SelectedItems[0];
                ConfigRol rol = (ConfigRol)itemSeleccionado.Tag;
                idRolSeleccionado = rol.IdRol;
                txtNombreRol.Text = rol.NombreRol;
                txtDescripcionRol.Text = rol.Descripcion;
            }
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            idRolSeleccionado = 0;
            txtNombreRol.Text = "";
            txtDescripcionRol.Text = "";
            txtNombreRol.Focus();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (idRolSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un rol de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este rol? Esto podría afectar a los usuarios asociados.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(Conexion.cadenaConexion))
                    {
                        con.Open();
                        string query = "DELETE FROM Roles WHERE IdRol = @id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idRolSeleccionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Rol eliminado exitosamente.", "SoliTec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNuevoRol_Click(null, null);
                        CargarRoles();
                    }
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar este rol porque pertenece a usuarios registrados en el sistema.", "Restricción de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtNombreEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombrePrioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtDescripcionRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
