namespace TicketsMDB
{
    partial class FormRegistroTicket
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBadge = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblIniciales = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblTituloLbl = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblCharTitulo = new System.Windows.Forms.Label();
            this.lblDescLbl = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCharDesc = new System.Windows.Forms.Label();
            this.pnlDiv1 = new System.Windows.Forms.Panel();
            this.lblEstadoLbl = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.pnlDiv2 = new System.Windows.Forms.Panel();
            this.lblPrioridadLbl = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblBadge);
            this.pnlHeader.Controls.Add(this.lblTituloForm);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.pnlAvatar);
            this.pnlHeader.Controls.Add(this.lblNombreUsuario);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
            this.pnlHeader.Size = new System.Drawing.Size(1081, 118);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblBadge
            // 
            this.lblBadge.AutoSize = true;
            this.lblBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblBadge.Location = new System.Drawing.Point(24, 14);
            this.lblBadge.Name = "lblBadge";
            this.lblBadge.Size = new System.Drawing.Size(121, 23);
            this.lblBadge.TabIndex = 0;
            this.lblBadge.Text = "● Nuevo ticket";
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(24, 40);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(330, 36);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "Registrar ticket de soporte";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(24, 74);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(517, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Complete los campos para enviar su solicitud al equipo de soporte";
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlAvatar.Controls.Add(this.lblIniciales);
            this.pnlAvatar.Location = new System.Drawing.Point(1365, 20);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(34, 34);
            this.pnlAvatar.TabIndex = 3;
            // 
            // lblIniciales
            // 
            this.lblIniciales.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIniciales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIniciales.ForeColor = System.Drawing.Color.White;
            this.lblIniciales.Location = new System.Drawing.Point(0, 0);
            this.lblIniciales.Name = "lblIniciales";
            this.lblIniciales.Size = new System.Drawing.Size(34, 34);
            this.lblIniciales.TabIndex = 0;
            this.lblIniciales.Text = "JD";
            this.lblIniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(1405, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(93, 25);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Juan Díaz";
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.btnEnviar);
            this.pnlBody.Controls.Add(this.dtpFechaCreacion);
            this.pnlBody.Controls.Add(this.lblTituloLbl);
            this.pnlBody.Controls.Add(this.txtTitulo);
            this.pnlBody.Controls.Add(this.lblCharTitulo);
            this.pnlBody.Controls.Add(this.lblDescLbl);
            this.pnlBody.Controls.Add(this.txtDescripcion);
            this.pnlBody.Controls.Add(this.lblCharDesc);
            this.pnlBody.Controls.Add(this.pnlDiv1);
            this.pnlBody.Controls.Add(this.lblEstadoLbl);
            this.pnlBody.Controls.Add(this.cmbEstado);
            this.pnlBody.Controls.Add(this.lblFechaLbl);
            this.pnlBody.Controls.Add(this.pnlDiv2);
            this.pnlBody.Controls.Add(this.lblPrioridadLbl);
            this.pnlBody.Controls.Add(this.btnBaja);
            this.pnlBody.Controls.Add(this.btnMedia);
            this.pnlBody.Controls.Add(this.btnAlta);
            this.pnlBody.Controls.Add(this.lblHint);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 118);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 10);
            this.pnlBody.Size = new System.Drawing.Size(1081, 713);
            this.pnlBody.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Indigo;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(745, 395);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(194, 46);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar ticket";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Enabled = false;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(396, 323);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(399, 33);
            this.dtpFechaCreacion.TabIndex = 17;
            // 
            // lblTituloLbl
            // 
            this.lblTituloLbl.AutoSize = true;
            this.lblTituloLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTituloLbl.ForeColor = System.Drawing.Color.Black;
            this.lblTituloLbl.Location = new System.Drawing.Point(51, 63);
            this.lblTituloLbl.Name = "lblTituloLbl";
            this.lblTituloLbl.Size = new System.Drawing.Size(71, 21);
            this.lblTituloLbl.TabIndex = 0;
            this.lblTituloLbl.Text = "TÍTULO *";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.BackColor = System.Drawing.Color.LightGray;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(55, 104);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(984, 33);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblCharTitulo
            // 
            this.lblCharTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharTitulo.AutoSize = true;
            this.lblCharTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCharTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCharTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCharTitulo.Location = new System.Drawing.Point(1455, 80);
            this.lblCharTitulo.Name = "lblCharTitulo";
            this.lblCharTitulo.Size = new System.Drawing.Size(60, 21);
            this.lblCharTitulo.TabIndex = 2;
            this.lblCharTitulo.Text = "0 / 100";
            // 
            // lblDescLbl
            // 
            this.lblDescLbl.AutoSize = true;
            this.lblDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblDescLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDescLbl.ForeColor = System.Drawing.Color.Black;
            this.lblDescLbl.Location = new System.Drawing.Point(51, 150);
            this.lblDescLbl.Name = "lblDescLbl";
            this.lblDescLbl.Size = new System.Drawing.Size(109, 21);
            this.lblDescLbl.TabIndex = 3;
            this.lblDescLbl.Text = "DESCRIPCIÓN";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(59, 172);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(980, 80);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblCharDesc
            // 
            this.lblCharDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharDesc.AutoSize = true;
            this.lblCharDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCharDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCharDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCharDesc.Location = new System.Drawing.Point(1455, 198);
            this.lblCharDesc.Name = "lblCharDesc";
            this.lblCharDesc.Size = new System.Drawing.Size(60, 21);
            this.lblCharDesc.TabIndex = 5;
            this.lblCharDesc.Text = "0 / 255";
            // 
            // pnlDiv1
            // 
            this.pnlDiv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlDiv1.Location = new System.Drawing.Point(8, 272);
            this.pnlDiv1.Name = "pnlDiv1";
            this.pnlDiv1.Size = new System.Drawing.Size(1515, 1);
            this.pnlDiv1.TabIndex = 6;
            // 
            // lblEstadoLbl
            // 
            this.lblEstadoLbl.AutoSize = true;
            this.lblEstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoLbl.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoLbl.Location = new System.Drawing.Point(55, 285);
            this.lblEstadoLbl.Name = "lblEstadoLbl";
            this.lblEstadoLbl.Size = new System.Drawing.Size(78, 21);
            this.lblEstadoLbl.TabIndex = 7;
            this.lblEstadoLbl.Text = "ESTADO *";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.LightGray;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmbEstado.Location = new System.Drawing.Point(55, 307);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(294, 33);
            this.cmbEstado.TabIndex = 8;
            // 
            // lblFechaLbl
            // 
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.Black;
            this.lblFechaLbl.Location = new System.Drawing.Point(369, 285);
            this.lblFechaLbl.Name = "lblFechaLbl";
            this.lblFechaLbl.Size = new System.Drawing.Size(160, 21);
            this.lblFechaLbl.TabIndex = 9;
            this.lblFechaLbl.Text = "FECHA DE CREACIÓN";
            // 
            // pnlDiv2
            // 
            this.pnlDiv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlDiv2.Location = new System.Drawing.Point(8, 358);
            this.pnlDiv2.Name = "pnlDiv2";
            this.pnlDiv2.Size = new System.Drawing.Size(1515, 1);
            this.pnlDiv2.TabIndex = 11;
            // 
            // lblPrioridadLbl
            // 
            this.lblPrioridadLbl.AutoSize = true;
            this.lblPrioridadLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioridadLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPrioridadLbl.ForeColor = System.Drawing.Color.Black;
            this.lblPrioridadLbl.Location = new System.Drawing.Point(55, 371);
            this.lblPrioridadLbl.Name = "lblPrioridadLbl";
            this.lblPrioridadLbl.Size = new System.Drawing.Size(204, 21);
            this.lblPrioridadLbl.TabIndex = 12;
            this.lblPrioridadLbl.Text = "PRIORIDAD DEL USUARIO *";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBaja.Location = new System.Drawing.Point(55, 395);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(194, 46);
            this.btnBaja.TabIndex = 13;
            this.btnBaja.Text = "● Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMedia.Location = new System.Drawing.Point(262, 395);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(194, 46);
            this.btnMedia.TabIndex = 14;
            this.btnMedia.Text = "● Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnAlta.Location = new System.Drawing.Point(469, 395);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(194, 46);
            this.btnAlta.TabIndex = 15;
            this.btnAlta.Text = "● Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHint.ForeColor = System.Drawing.Color.Black;
            this.lblHint.Location = new System.Drawing.Point(55, 460);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(1515, 18);
            this.lblHint.TabIndex = 16;
            this.lblHint.Text = "ℹ  Esta es tu percepción del impacto. El equipo asignará la prioridad real.";
            // 
            // FormRegistroTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.MinimumSize = new System.Drawing.Size(600, 560);
            this.Name = "FormRegistroTicket";
            this.Size = new System.Drawing.Size(1081, 831);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Declaración de controles ──────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblIniciales;
        private System.Windows.Forms.Label lblNombreUsuario;

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTituloLbl;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblCharTitulo;
        private System.Windows.Forms.Label lblDescLbl;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCharDesc;
        private System.Windows.Forms.Panel pnlDiv1;
        private System.Windows.Forms.Label lblEstadoLbl;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblFechaLbl;
        private System.Windows.Forms.Panel pnlDiv2;
        private System.Windows.Forms.Label lblPrioridadLbl;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Button btnEnviar;
    }
}