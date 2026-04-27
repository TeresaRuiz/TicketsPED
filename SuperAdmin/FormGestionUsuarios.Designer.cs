namespace TicketsMDB.SuperAdmin
{
    partial class FormGestionUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlSeguridad = new System.Windows.Forms.Panel();
            this.lblSeguridadTitulo = new System.Windows.Forms.Label();
            this.pnlDivSeg = new System.Windows.Forms.Panel();
            this.chkBloqueado = new System.Windows.Forms.CheckBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblFormTitulo = new System.Windows.Forms.Label();
            this.pnlDivForm = new System.Windows.Forms.Panel();
            this.lblNombreLbl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoLbl = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCorreoLbl = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefonoLbl = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblRolLbl = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblPasswordLbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftHeader = new System.Windows.Forms.Panel();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.pnlFiltroRoles = new System.Windows.Forms.Panel();
            this.btnFiltroTodos = new System.Windows.Forms.Button();
            this.btnFiltroAdmin = new System.Windows.Forms.Button();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.btnFiltroBloqueado = new System.Windows.Forms.Button();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstadoUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBody.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlSeguridad.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.pnlFiltroRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1200, 740);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlRight.Controls.Add(this.pnlAcciones);
            this.pnlRight.Controls.Add(this.pnlSeguridad);
            this.pnlRight.Controls.Add(this.pnlFormCard);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(720, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlRight.Size = new System.Drawing.Size(480, 740);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnLimpiar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Location = new System.Drawing.Point(16, 484);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlAcciones.Size = new System.Drawing.Size(448, 118);
            this.pnlAcciones.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(33, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Location = new System.Drawing.Point(257, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLimpiar.Location = new System.Drawing.Point(180, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 34);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // pnlSeguridad
            // 
            this.pnlSeguridad.BackColor = System.Drawing.Color.White;
            this.pnlSeguridad.Controls.Add(this.lblSeguridadTitulo);
            this.pnlSeguridad.Controls.Add(this.pnlDivSeg);
            this.pnlSeguridad.Controls.Add(this.chkBloqueado);
            this.pnlSeguridad.Controls.Add(this.btnResetPassword);
            this.pnlSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeguridad.Location = new System.Drawing.Point(16, 394);
            this.pnlSeguridad.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSeguridad.Name = "pnlSeguridad";
            this.pnlSeguridad.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlSeguridad.Size = new System.Drawing.Size(448, 90);
            this.pnlSeguridad.TabIndex = 1;
            // 
            // lblSeguridadTitulo
            // 
            this.lblSeguridadTitulo.AutoSize = true;
            this.lblSeguridadTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSeguridadTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeguridadTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSeguridadTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblSeguridadTitulo.Name = "lblSeguridadTitulo";
            this.lblSeguridadTitulo.Size = new System.Drawing.Size(101, 21);
            this.lblSeguridadTitulo.TabIndex = 0;
            this.lblSeguridadTitulo.Text = "SEGURIDAD";
            // 
            // pnlDivSeg
            // 
            this.pnlDivSeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivSeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivSeg.Location = new System.Drawing.Point(16, 30);
            this.pnlDivSeg.Name = "pnlDivSeg";
            this.pnlDivSeg.Size = new System.Drawing.Size(648, 1);
            this.pnlDivSeg.TabIndex = 1;
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.BackColor = System.Drawing.Color.Transparent;
            this.chkBloqueado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBloqueado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkBloqueado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chkBloqueado.Location = new System.Drawing.Point(16, 46);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Size = new System.Drawing.Size(199, 29);
            this.chkBloqueado.TabIndex = 2;
            this.chkBloqueado.Text = "Usuario bloqueado";
            this.chkBloqueado.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnResetPassword.Location = new System.Drawing.Point(272, 44);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(160, 30);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Resetear contraseña";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.lblFormTitulo);
            this.pnlFormCard.Controls.Add(this.pnlDivForm);
            this.pnlFormCard.Controls.Add(this.lblNombreLbl);
            this.pnlFormCard.Controls.Add(this.txtNombre);
            this.pnlFormCard.Controls.Add(this.lblApellidoLbl);
            this.pnlFormCard.Controls.Add(this.txtApellido);
            this.pnlFormCard.Controls.Add(this.lblCorreoLbl);
            this.pnlFormCard.Controls.Add(this.txtCorreo);
            this.pnlFormCard.Controls.Add(this.lblTelefonoLbl);
            this.pnlFormCard.Controls.Add(this.txtTelefono);
            this.pnlFormCard.Controls.Add(this.lblRolLbl);
            this.pnlFormCard.Controls.Add(this.cmbRol);
            this.pnlFormCard.Controls.Add(this.lblPasswordLbl);
            this.pnlFormCard.Controls.Add(this.txtPassword);
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormCard.Location = new System.Drawing.Point(16, 14);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlFormCard.Size = new System.Drawing.Size(448, 380);
            this.pnlFormCard.TabIndex = 2;
            // 
            // lblFormTitulo
            // 
            this.lblFormTitulo.AutoSize = true;
            this.lblFormTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFormTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFormTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblFormTitulo.Name = "lblFormTitulo";
            this.lblFormTitulo.Size = new System.Drawing.Size(169, 21);
            this.lblFormTitulo.TabIndex = 0;
            this.lblFormTitulo.Text = "DATOS DEL USUARIO";
            // 
            // pnlDivForm
            // 
            this.pnlDivForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivForm.Location = new System.Drawing.Point(16, 34);
            this.pnlDivForm.Name = "pnlDivForm";
            this.pnlDivForm.Size = new System.Drawing.Size(648, 1);
            this.pnlDivForm.TabIndex = 1;
            // 
            // lblNombreLbl
            // 
            this.lblNombreLbl.AutoSize = true;
            this.lblNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNombreLbl.Location = new System.Drawing.Point(16, 46);
            this.lblNombreLbl.Name = "lblNombreLbl";
            this.lblNombreLbl.Size = new System.Drawing.Size(76, 23);
            this.lblNombreLbl.TabIndex = 2;
            this.lblNombreLbl.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNombre.Location = new System.Drawing.Point(13, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 33);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellidoLbl
            // 
            this.lblApellidoLbl.AutoSize = true;
            this.lblApellidoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblApellidoLbl.Location = new System.Drawing.Point(16, 104);
            this.lblApellidoLbl.Name = "lblApellidoLbl";
            this.lblApellidoLbl.Size = new System.Drawing.Size(78, 23);
            this.lblApellidoLbl.TabIndex = 4;
            this.lblApellidoLbl.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtApellido.Location = new System.Drawing.Point(16, 122);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(416, 33);
            this.txtApellido.TabIndex = 5;
            // 
            // lblCorreoLbl
            // 
            this.lblCorreoLbl.AutoSize = true;
            this.lblCorreoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCorreoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCorreoLbl.Location = new System.Drawing.Point(16, 162);
            this.lblCorreoLbl.Name = "lblCorreoLbl";
            this.lblCorreoLbl.Size = new System.Drawing.Size(157, 23);
            this.lblCorreoLbl.TabIndex = 6;
            this.lblCorreoLbl.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCorreo.Location = new System.Drawing.Point(16, 180);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(416, 33);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblTelefonoLbl
            // 
            this.lblTelefonoLbl.AutoSize = true;
            this.lblTelefonoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefonoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTelefonoLbl.Location = new System.Drawing.Point(16, 220);
            this.lblTelefonoLbl.Name = "lblTelefonoLbl";
            this.lblTelefonoLbl.Size = new System.Drawing.Size(78, 23);
            this.lblTelefonoLbl.TabIndex = 8;
            this.lblTelefonoLbl.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtTelefono.Location = new System.Drawing.Point(16, 238);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(192, 33);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblRolLbl
            // 
            this.lblRolLbl.AutoSize = true;
            this.lblRolLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblRolLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRolLbl.Location = new System.Drawing.Point(224, 220);
            this.lblRolLbl.Name = "lblRolLbl";
            this.lblRolLbl.Size = new System.Drawing.Size(36, 23);
            this.lblRolLbl.TabIndex = 10;
            this.lblRolLbl.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbRol.Location = new System.Drawing.Point(224, 238);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(192, 33);
            this.cmbRol.TabIndex = 11;
            // 
            // lblPasswordLbl
            // 
            this.lblPasswordLbl.AutoSize = true;
            this.lblPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPasswordLbl.Location = new System.Drawing.Point(16, 278);
            this.lblPasswordLbl.Name = "lblPasswordLbl";
            this.lblPasswordLbl.Size = new System.Drawing.Size(339, 23);
            this.lblPasswordLbl.TabIndex = 12;
            this.lblPasswordLbl.Text = "Contraseña (dejar vacío para no cambiar)";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.Location = new System.Drawing.Point(16, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(416, 33);
            this.txtPassword.TabIndex = 13;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.pnlLeftHeader);
            this.pnlLeft.Controls.Add(this.pnlFiltroRoles);
            this.pnlLeft.Controls.Add(this.lvUsuarios);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(720, 740);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlLeftHeader
            // 
            this.pnlLeftHeader.BackColor = System.Drawing.Color.White;
            this.pnlLeftHeader.Controls.Add(this.lblTituloLista);
            this.pnlLeftHeader.Controls.Add(this.txtBuscar);
            this.pnlLeftHeader.Controls.Add(this.btnNuevoUsuario);
            this.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftHeader.Location = new System.Drawing.Point(0, 42);
            this.pnlLeftHeader.Name = "pnlLeftHeader";
            this.pnlLeftHeader.Padding = new System.Windows.Forms.Padding(16, 12, 16, 8);
            this.pnlLeftHeader.Size = new System.Drawing.Size(720, 64);
            this.pnlLeftHeader.TabIndex = 0;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloLista.Location = new System.Drawing.Point(16, 16);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Size = new System.Drawing.Size(257, 36);
            this.lblTituloLista.TabIndex = 0;
            this.lblTituloLista.Text = "Usuarios del sistema";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscar.Location = new System.Drawing.Point(220, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(240, 33);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar usuario...";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(490, 16);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(130, 30);
            this.btnNuevoUsuario.TabIndex = 2;
            this.btnNuevoUsuario.Text = "+ Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // pnlFiltroRoles
            // 
            this.pnlFiltroRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFiltroRoles.Controls.Add(this.btnFiltroTodos);
            this.pnlFiltroRoles.Controls.Add(this.btnFiltroAdmin);
            this.pnlFiltroRoles.Controls.Add(this.btnFiltroCliente);
            this.pnlFiltroRoles.Controls.Add(this.btnFiltroBloqueado);
            this.pnlFiltroRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroRoles.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltroRoles.Name = "pnlFiltroRoles";
            this.pnlFiltroRoles.Padding = new System.Windows.Forms.Padding(16, 8, 16, 6);
            this.pnlFiltroRoles.Size = new System.Drawing.Size(720, 42);
            this.pnlFiltroRoles.TabIndex = 1;
            // 
            // btnFiltroTodos
            // 
            this.btnFiltroTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnFiltroTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroTodos.FlatAppearance.BorderSize = 0;
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFiltroTodos.ForeColor = System.Drawing.Color.White;
            this.btnFiltroTodos.Location = new System.Drawing.Point(16, 7);
            this.btnFiltroTodos.Name = "btnFiltroTodos";
            this.btnFiltroTodos.Size = new System.Drawing.Size(66, 24);
            this.btnFiltroTodos.TabIndex = 0;
            this.btnFiltroTodos.Text = "Todos";
            this.btnFiltroTodos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroAdmin
            // 
            this.btnFiltroAdmin.BackColor = System.Drawing.Color.White;
            this.btnFiltroAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnFiltroAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAdmin.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFiltroAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroAdmin.Location = new System.Drawing.Point(90, 7);
            this.btnFiltroAdmin.Name = "btnFiltroAdmin";
            this.btnFiltroAdmin.Size = new System.Drawing.Size(66, 24);
            this.btnFiltroAdmin.TabIndex = 1;
            this.btnFiltroAdmin.Text = "Admin";
            this.btnFiltroAdmin.UseVisualStyleBackColor = false;
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.BackColor = System.Drawing.Color.White;
            this.btnFiltroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFiltroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroCliente.Location = new System.Drawing.Point(164, 7);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(66, 24);
            this.btnFiltroCliente.TabIndex = 2;
            this.btnFiltroCliente.Text = "Cliente";
            this.btnFiltroCliente.UseVisualStyleBackColor = false;
            // 
            // btnFiltroBloqueado
            // 
            this.btnFiltroBloqueado.BackColor = System.Drawing.Color.White;
            this.btnFiltroBloqueado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroBloqueado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroBloqueado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFiltroBloqueado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroBloqueado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFiltroBloqueado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroBloqueado.Location = new System.Drawing.Point(238, 7);
            this.btnFiltroBloqueado.Name = "btnFiltroBloqueado";
            this.btnFiltroBloqueado.Size = new System.Drawing.Size(90, 24);
            this.btnFiltroBloqueado.TabIndex = 3;
            this.btnFiltroBloqueado.Text = "Bloqueados";
            this.btnFiltroBloqueado.UseVisualStyleBackColor = false;
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.BackColor = System.Drawing.Color.White;
            this.lvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colCorreo,
            this.colRol,
            this.colEstadoUser,
            this.colFechaReg});
            this.lvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lvUsuarios.MultiSelect = false;
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(720, 740);
            this.lvUsuarios.TabIndex = 2;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "#";
            this.colId.Width = 42;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre completo";
            this.colNombre.Width = 180;
            // 
            // colCorreo
            // 
            this.colCorreo.Text = "Correo";
            this.colCorreo.Width = 190;
            // 
            // colRol
            // 
            this.colRol.Text = "Rol";
            this.colRol.Width = 90;
            // 
            // colEstadoUser
            // 
            this.colEstadoUser.Text = "Estado";
            this.colEstadoUser.Width = 90;
            // 
            // colFechaReg
            // 
            this.colFechaReg.Text = "Registro";
            this.colFechaReg.Width = 110;
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormGestionUsuarios";
            this.Size = new System.Drawing.Size(1200, 740);
            this.pnlBody.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlSeguridad.ResumeLayout(false);
            this.pnlSeguridad.PerformLayout();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlLeftHeader.PerformLayout();
            this.pnlFiltroRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftHeader;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Panel pnlFiltroRoles;
        private System.Windows.Forms.Button btnFiltroTodos;
        private System.Windows.Forms.Button btnFiltroAdmin;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.Button btnFiltroBloqueado;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCorreo;
        private System.Windows.Forms.ColumnHeader colRol;
        private System.Windows.Forms.ColumnHeader colEstadoUser;
        private System.Windows.Forms.ColumnHeader colFechaReg;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblFormTitulo;
        private System.Windows.Forms.Panel pnlDivForm;
        private System.Windows.Forms.Label lblNombreLbl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoLbl;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCorreoLbl;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefonoLbl;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblRolLbl;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblPasswordLbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlSeguridad;
        private System.Windows.Forms.Label lblSeguridadTitulo;
        private System.Windows.Forms.Panel pnlDivSeg;
        private System.Windows.Forms.CheckBox chkBloqueado;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}