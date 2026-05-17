namespace TicketsMDB.Clientes
{
    partial class FormPerfil
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlCardPassword = new System.Windows.Forms.Panel();
            this.lblPasswordTitulo = new System.Windows.Forms.Label();
            this.pnlDivPassword = new System.Windows.Forms.Panel();
            this.lblPassActualLbl = new System.Windows.Forms.Label();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.lblPassNuevaLbl = new System.Windows.Forms.Label();
            this.txtPassNueva = new System.Windows.Forms.TextBox();
            this.lblPassConfLbl = new System.Windows.Forms.Label();
            this.txtPassConf = new System.Windows.Forms.TextBox();
            this.lblPassHint = new System.Windows.Forms.Label();
            this.btnGuardarPass = new System.Windows.Forms.Button();
            this.pnlCardDatos = new System.Windows.Forms.Panel();
            this.btnGuardarCorreo = new System.Windows.Forms.Button();
            this.txtCorreoVal = new System.Windows.Forms.TextBox();
            this.lblDatosTitulo = new System.Windows.Forms.Label();
            this.pnlDivDatos = new System.Windows.Forms.Panel();
            this.lblCorreoLbl = new System.Windows.Forms.Label();
            this.lblNombreLbl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoLbl = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pnlAvatarGrande = new System.Windows.Forms.Panel();
            this.lblInicialesGrande = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblRolBadge = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlCardPassword.SuspendLayout();
            this.pnlCardDatos.SuspendLayout();
            this.pnlAvatarGrande.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.pnlCardPassword);
            this.pnlContent.Controls.Add(this.pnlCardDatos);
            this.pnlContent.Controls.Add(this.pnlAvatarGrande);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 24, 28, 24);
            this.pnlContent.Size = new System.Drawing.Size(1057, 680);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlCardPassword
            // 
            this.pnlCardPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCardPassword.BackColor = System.Drawing.Color.White;
            this.pnlCardPassword.Controls.Add(this.lblPasswordTitulo);
            this.pnlCardPassword.Controls.Add(this.pnlDivPassword);
            this.pnlCardPassword.Controls.Add(this.lblPassActualLbl);
            this.pnlCardPassword.Controls.Add(this.txtPassActual);
            this.pnlCardPassword.Controls.Add(this.lblPassNuevaLbl);
            this.pnlCardPassword.Controls.Add(this.txtPassNueva);
            this.pnlCardPassword.Controls.Add(this.lblPassConfLbl);
            this.pnlCardPassword.Controls.Add(this.txtPassConf);
            this.pnlCardPassword.Controls.Add(this.lblPassHint);
            this.pnlCardPassword.Controls.Add(this.btnGuardarPass);
            this.pnlCardPassword.Location = new System.Drawing.Point(0, 412);
            this.pnlCardPassword.Name = "pnlCardPassword";
            this.pnlCardPassword.Size = new System.Drawing.Size(1557, 250);
            this.pnlCardPassword.TabIndex = 0;
            // 
            // lblPasswordTitulo
            // 
            this.lblPasswordTitulo.AutoSize = true;
            this.lblPasswordTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPasswordTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPasswordTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblPasswordTitulo.Name = "lblPasswordTitulo";
            this.lblPasswordTitulo.Size = new System.Drawing.Size(171, 19);
            this.lblPasswordTitulo.TabIndex = 0;
            this.lblPasswordTitulo.Text = "CAMBIAR CONTRASEÑA";
            // 
            // pnlDivPassword
            // 
            this.pnlDivPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivPassword.Location = new System.Drawing.Point(18, 36);
            this.pnlDivPassword.Name = "pnlDivPassword";
            this.pnlDivPassword.Size = new System.Drawing.Size(1521, 1);
            this.pnlDivPassword.TabIndex = 1;
            // 
            // lblPassActualLbl
            // 
            this.lblPassActualLbl.AutoSize = true;
            this.lblPassActualLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPassActualLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassActualLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPassActualLbl.Location = new System.Drawing.Point(18, 50);
            this.lblPassActualLbl.Name = "lblPassActualLbl";
            this.lblPassActualLbl.Size = new System.Drawing.Size(134, 20);
            this.lblPassActualLbl.TabIndex = 2;
            this.lblPassActualLbl.Text = "Contraseña actual";
            // 
            // txtPassActual
            // 
            this.txtPassActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassActual.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassActual.Location = new System.Drawing.Point(18, 68);
            this.txtPassActual.MaxLength = 100;
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.PasswordChar = '●';
            this.txtPassActual.Size = new System.Drawing.Size(1017, 29);
            this.txtPassActual.TabIndex = 3;
            // 
            // lblPassNuevaLbl
            // 
            this.lblPassNuevaLbl.AutoSize = true;
            this.lblPassNuevaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPassNuevaLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassNuevaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPassNuevaLbl.Location = new System.Drawing.Point(18, 108);
            this.lblPassNuevaLbl.Name = "lblPassNuevaLbl";
            this.lblPassNuevaLbl.Size = new System.Drawing.Size(135, 20);
            this.lblPassNuevaLbl.TabIndex = 4;
            this.lblPassNuevaLbl.Text = "Nueva contraseña";
            // 
            // txtPassNueva
            // 
            this.txtPassNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassNueva.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassNueva.Location = new System.Drawing.Point(18, 126);
            this.txtPassNueva.MaxLength = 100;
            this.txtPassNueva.Name = "txtPassNueva";
            this.txtPassNueva.PasswordChar = '●';
            this.txtPassNueva.Size = new System.Drawing.Size(322, 29);
            this.txtPassNueva.TabIndex = 5;
            // 
            // lblPassConfLbl
            // 
            this.lblPassConfLbl.AutoSize = true;
            this.lblPassConfLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPassConfLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassConfLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPassConfLbl.Location = new System.Drawing.Point(360, 108);
            this.lblPassConfLbl.Name = "lblPassConfLbl";
            this.lblPassConfLbl.Size = new System.Drawing.Size(207, 20);
            this.lblPassConfLbl.TabIndex = 6;
            this.lblPassConfLbl.Text = "Confirmar nueva contraseña";
            // 
            // txtPassConf
            // 
            this.txtPassConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassConf.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassConf.Location = new System.Drawing.Point(360, 126);
            this.txtPassConf.MaxLength = 100;
            this.txtPassConf.Name = "txtPassConf";
            this.txtPassConf.PasswordChar = '●';
            this.txtPassConf.Size = new System.Drawing.Size(322, 29);
            this.txtPassConf.TabIndex = 7;
            // 
            // lblPassHint
            // 
            this.lblPassHint.AutoSize = true;
            this.lblPassHint.BackColor = System.Drawing.Color.Transparent;
            this.lblPassHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPassHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPassHint.Location = new System.Drawing.Point(18, 164);
            this.lblPassHint.Name = "lblPassHint";
            this.lblPassHint.Size = new System.Drawing.Size(303, 19);
            this.lblPassHint.TabIndex = 8;
            this.lblPassHint.Text = "La contraseña debe tener al menos 8 caracteres.";
            // 
            // btnGuardarPass
            // 
            this.btnGuardarPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(73)))));
            this.btnGuardarPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPass.FlatAppearance.BorderSize = 0;
            this.btnGuardarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnGuardarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPass.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPass.Location = new System.Drawing.Point(18, 188);
            this.btnGuardarPass.Name = "btnGuardarPass";
            this.btnGuardarPass.Size = new System.Drawing.Size(160, 34);
            this.btnGuardarPass.TabIndex = 9;
            this.btnGuardarPass.Text = "Cambiar contraseña";
            this.btnGuardarPass.UseVisualStyleBackColor = false;
            this.btnGuardarPass.Click += new System.EventHandler(this.btnGuardarPass_Click);
            // 
            // pnlCardDatos
            // 
            this.pnlCardDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCardDatos.BackColor = System.Drawing.Color.White;
            this.pnlCardDatos.Controls.Add(this.btnGuardarCorreo);
            this.pnlCardDatos.Controls.Add(this.txtCorreoVal);
            this.pnlCardDatos.Controls.Add(this.lblDatosTitulo);
            this.pnlCardDatos.Controls.Add(this.pnlDivDatos);
            this.pnlCardDatos.Controls.Add(this.lblCorreoLbl);
            this.pnlCardDatos.Controls.Add(this.lblNombreLbl);
            this.pnlCardDatos.Controls.Add(this.txtNombre);
            this.pnlCardDatos.Controls.Add(this.lblApellidoLbl);
            this.pnlCardDatos.Controls.Add(this.txtApellido);
            this.pnlCardDatos.Location = new System.Drawing.Point(0, 116);
            this.pnlCardDatos.Name = "pnlCardDatos";
            this.pnlCardDatos.Size = new System.Drawing.Size(1557, 280);
            this.pnlCardDatos.TabIndex = 1;
            // 
            // btnGuardarCorreo
            // 
            this.btnGuardarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(73)))));
            this.btnGuardarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCorreo.FlatAppearance.BorderSize = 0;
            this.btnGuardarCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnGuardarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCorreo.Location = new System.Drawing.Point(22, 208);
            this.btnGuardarCorreo.Name = "btnGuardarCorreo";
            this.btnGuardarCorreo.Size = new System.Drawing.Size(130, 34);
            this.btnGuardarCorreo.TabIndex = 11;
            this.btnGuardarCorreo.Text = "Guardar";
            this.btnGuardarCorreo.UseVisualStyleBackColor = false;
            this.btnGuardarCorreo.Click += new System.EventHandler(this.btnGuardarCorreo_Click);
            // 
            // txtCorreoVal
            // 
            this.txtCorreoVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtCorreoVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCorreoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtCorreoVal.Location = new System.Drawing.Point(22, 150);
            this.txtCorreoVal.MaxLength = 100;
            this.txtCorreoVal.Name = "txtCorreoVal";
            this.txtCorreoVal.Size = new System.Drawing.Size(1013, 29);
            this.txtCorreoVal.TabIndex = 10;
            // 
            // lblDatosTitulo
            // 
            this.lblDatosTitulo.AutoSize = true;
            this.lblDatosTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDatosTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblDatosTitulo.Name = "lblDatosTitulo";
            this.lblDatosTitulo.Size = new System.Drawing.Size(145, 19);
            this.lblDatosTitulo.TabIndex = 0;
            this.lblDatosTitulo.Text = "DATOS PERSONALES";
            // 
            // pnlDivDatos
            // 
            this.pnlDivDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivDatos.Location = new System.Drawing.Point(18, 36);
            this.pnlDivDatos.Name = "pnlDivDatos";
            this.pnlDivDatos.Size = new System.Drawing.Size(1521, 1);
            this.pnlDivDatos.TabIndex = 1;
            // 
            // lblCorreoLbl
            // 
            this.lblCorreoLbl.AutoSize = true;
            this.lblCorreoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCorreoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCorreoLbl.Location = new System.Drawing.Point(18, 127);
            this.lblCorreoLbl.Name = "lblCorreoLbl";
            this.lblCorreoLbl.Size = new System.Drawing.Size(137, 20);
            this.lblCorreoLbl.TabIndex = 2;
            this.lblCorreoLbl.Text = "Correo electrónico";
            // 
            // lblNombreLbl
            // 
            this.lblNombreLbl.AutoSize = true;
            this.lblNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNombreLbl.Location = new System.Drawing.Point(22, 59);
            this.lblNombreLbl.Name = "lblNombreLbl";
            this.lblNombreLbl.Size = new System.Drawing.Size(67, 20);
            this.lblNombreLbl.TabIndex = 5;
            this.lblNombreLbl.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNombre.Location = new System.Drawing.Point(22, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(322, 29);
            this.txtNombre.TabIndex = 6;
            // 
            // lblApellidoLbl
            // 
            this.lblApellidoLbl.AutoSize = true;
            this.lblApellidoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblApellidoLbl.Location = new System.Drawing.Point(364, 59);
            this.lblApellidoLbl.Name = "lblApellidoLbl";
            this.lblApellidoLbl.Size = new System.Drawing.Size(67, 20);
            this.lblApellidoLbl.TabIndex = 7;
            this.lblApellidoLbl.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtApellido.Location = new System.Drawing.Point(364, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(322, 29);
            this.txtApellido.TabIndex = 8;
            // 
            // pnlAvatarGrande
            // 
            this.pnlAvatarGrande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAvatarGrande.BackColor = System.Drawing.Color.White;
            this.pnlAvatarGrande.Controls.Add(this.lblInicialesGrande);
            this.pnlAvatarGrande.Controls.Add(this.lblNombreCompleto);
            this.pnlAvatarGrande.Controls.Add(this.lblRolBadge);
            this.pnlAvatarGrande.Location = new System.Drawing.Point(0, 0);
            this.pnlAvatarGrande.Name = "pnlAvatarGrande";
            this.pnlAvatarGrande.Size = new System.Drawing.Size(1557, 100);
            this.pnlAvatarGrande.TabIndex = 2;
            // 
            // lblInicialesGrande
            // 
            this.lblInicialesGrande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblInicialesGrande.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblInicialesGrande.ForeColor = System.Drawing.Color.White;
            this.lblInicialesGrande.Location = new System.Drawing.Point(18, 18);
            this.lblInicialesGrande.Name = "lblInicialesGrande";
            this.lblInicialesGrande.Size = new System.Drawing.Size(64, 64);
            this.lblInicialesGrande.TabIndex = 0;
            this.lblInicialesGrande.Text = "JD";
            this.lblInicialesGrande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(100, 22);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(125, 35);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Juan Díaz";
            // 
            // lblRolBadge
            // 
            this.lblRolBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblRolBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRolBadge.Location = new System.Drawing.Point(100, 56);
            this.lblRolBadge.Name = "lblRolBadge";
            this.lblRolBadge.Size = new System.Drawing.Size(60, 22);
            this.lblRolBadge.TabIndex = 2;
            this.lblRolBadge.Text = "Cliente";
            this.lblRolBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(680, 580);
            this.Name = "FormPerfil";
            this.Size = new System.Drawing.Size(1057, 680);
            this.pnlContent.ResumeLayout(false);
            this.pnlCardPassword.ResumeLayout(false);
            this.pnlCardPassword.PerformLayout();
            this.pnlCardDatos.ResumeLayout(false);
            this.pnlCardDatos.PerformLayout();
            this.pnlAvatarGrande.ResumeLayout(false);
            this.pnlAvatarGrande.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAvatarGrande;
        private System.Windows.Forms.Label lblInicialesGrande;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblRolBadge;
        private System.Windows.Forms.Panel pnlCardDatos;
        private System.Windows.Forms.Label lblDatosTitulo;
        private System.Windows.Forms.Panel pnlDivDatos;
        private System.Windows.Forms.Label lblCorreoLbl;
        private System.Windows.Forms.Label lblNombreLbl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoLbl;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel pnlCardPassword;
        private System.Windows.Forms.Label lblPasswordTitulo;
        private System.Windows.Forms.Panel pnlDivPassword;
        private System.Windows.Forms.Label lblPassActualLbl;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Label lblPassNuevaLbl;
        private System.Windows.Forms.TextBox txtPassNueva;
        private System.Windows.Forms.Label lblPassConfLbl;
        private System.Windows.Forms.TextBox txtPassConf;
        private System.Windows.Forms.Label lblPassHint;
        private System.Windows.Forms.Button btnGuardarPass;
        private System.Windows.Forms.TextBox txtCorreoVal;
        private System.Windows.Forms.Button btnGuardarCorreo;
    }
}