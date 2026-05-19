namespace TicketsMDB.Admin
{
    partial class DetalleTicket
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.lblBadgeId = new System.Windows.Forms.Label();
            this.lblBadgeEstado = new System.Windows.Forms.Label();
            this.lblBadgePrioridad = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.lblAccTitulo = new System.Windows.Forms.Label();
            this.pnlDivAcc = new System.Windows.Forms.Panel();
            this.lblCambiarEstadoLbl = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblPriorRealAccLbl = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblComentarioLbl = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.lblDescTitulo = new System.Windows.Forms.Label();
            this.pnlDivDesc = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.pnlDivInfo = new System.Windows.Forms.Panel();
            this.lblUsuarioLbl = new System.Windows.Forms.Label();
            this.lblUsuarioVal = new System.Windows.Forms.Label();
            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.lblFechaVal = new System.Windows.Forms.Label();
            this.lblEstadoLbl = new System.Windows.Forms.Label();
            this.lblEstadoVal = new System.Windows.Forms.Label();
            this.lblPriorUsuarioLbl = new System.Windows.Forms.Label();
            this.lblPriorUsuarioVal = new System.Windows.Forms.Label();
            this.lblPriorRealLbl = new System.Windows.Forms.Label();
            this.lblPriorRealVal = new System.Windows.Forms.Label();
            this.lblAsignadoLbl = new System.Windows.Forms.Label();
            this.lblAsignadoVal = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlWarnDeshacer = new System.Windows.Forms.Panel();
            this.lblWarnIcono = new System.Windows.Forms.Label();
            this.lblWarnTexto = new System.Windows.Forms.Label();
            this.pnlTimeline = new System.Windows.Forms.Panel();
            this.pnlDivHistorial = new System.Windows.Forms.Panel();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlDescripcion.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlWarnDeshacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnVolver);
            this.pnlTopBar.Controls.Add(this.lblTituloPanel);
            this.pnlTopBar.Controls.Add(this.lblBadgeId);
            this.pnlTopBar.Controls.Add(this.lblBadgeEstado);
            this.pnlTopBar.Controls.Add(this.lblBadgePrioridad);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1024, 45);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnVolver.Location = new System.Drawing.Point(8, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 28);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloPanel.Location = new System.Drawing.Point(44, 10);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(199, 32);
            this.lblTituloPanel.TabIndex = 1;
            this.lblTituloPanel.Text = "Detalle del ticket";
            // 
            // lblBadgeId
            // 
            this.lblBadgeId.AutoSize = true;
            this.lblBadgeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblBadgeId.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblBadgeId.Location = new System.Drawing.Point(282, 11);
            this.lblBadgeId.Name = "lblBadgeId";
            this.lblBadgeId.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblBadgeId.Size = new System.Drawing.Size(100, 27);
            this.lblBadgeId.TabIndex = 2;
            this.lblBadgeId.Text = "#TK-0001";
            // 
            // lblBadgeEstado
            // 
            this.lblBadgeEstado.AutoSize = true;
            this.lblBadgeEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.lblBadgeEstado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadgeEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblBadgeEstado.Location = new System.Drawing.Point(402, 12);
            this.lblBadgeEstado.Name = "lblBadgeEstado";
            this.lblBadgeEstado.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblBadgeEstado.Size = new System.Drawing.Size(105, 25);
            this.lblBadgeEstado.TabIndex = 3;
            this.lblBadgeEstado.Text = "En proceso";
            // 
            // lblBadgePrioridad
            // 
            this.lblBadgePrioridad.AutoSize = true;
            this.lblBadgePrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblBadgePrioridad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBadgePrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblBadgePrioridad.Location = new System.Drawing.Point(513, 14);
            this.lblBadgePrioridad.Name = "lblBadgePrioridad";
            this.lblBadgePrioridad.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblBadgePrioridad.Size = new System.Drawing.Size(128, 25);
            this.lblBadgePrioridad.TabIndex = 4;
            this.lblBadgePrioridad.Text = "Alta prioridad";
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlLeft.Controls.Add(this.pnlAcciones);
            this.pnlLeft.Controls.Add(this.pnlDescripcion);
            this.pnlLeft.Controls.Add(this.pnlInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 45);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlLeft.Size = new System.Drawing.Size(600, 635);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.White;
            this.pnlAcciones.Controls.Add(this.lblAccTitulo);
            this.pnlAcciones.Controls.Add(this.pnlDivAcc);
            this.pnlAcciones.Controls.Add(this.lblCambiarEstadoLbl);
            this.pnlAcciones.Controls.Add(this.cmbEstado);
            this.pnlAcciones.Controls.Add(this.lblPriorRealAccLbl);
            this.pnlAcciones.Controls.Add(this.cmbPrioridad);
            this.pnlAcciones.Controls.Add(this.lblComentarioLbl);
            this.pnlAcciones.Controls.Add(this.txtComentario);
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Controls.Add(this.btnDeshacer);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Location = new System.Drawing.Point(12, 340);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlAcciones.Size = new System.Drawing.Size(576, 220);
            this.pnlAcciones.TabIndex = 2;
            // 
            // lblAccTitulo
            // 
            this.lblAccTitulo.AutoSize = true;
            this.lblAccTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAccTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAccTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblAccTitulo.Name = "lblAccTitulo";
            this.lblAccTitulo.Size = new System.Drawing.Size(89, 21);
            this.lblAccTitulo.TabIndex = 0;
            this.lblAccTitulo.Text = "ACCIONES";
            // 
            // pnlDivAcc
            // 
            this.pnlDivAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivAcc.Location = new System.Drawing.Point(12, 26);
            this.pnlDivAcc.Name = "pnlDivAcc";
            this.pnlDivAcc.Size = new System.Drawing.Size(552, 1);
            this.pnlDivAcc.TabIndex = 1;
            // 
            // lblCambiarEstadoLbl
            // 
            this.lblCambiarEstadoLbl.AutoSize = true;
            this.lblCambiarEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCambiarEstadoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCambiarEstadoLbl.Location = new System.Drawing.Point(12, 35);
            this.lblCambiarEstadoLbl.Name = "lblCambiarEstadoLbl";
            this.lblCambiarEstadoLbl.Size = new System.Drawing.Size(130, 23);
            this.lblCambiarEstadoLbl.TabIndex = 2;
            this.lblCambiarEstadoLbl.Text = "Cambiar estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbEstado.Items.AddRange(new object[] {
            "Abierto",
            "En proceso",
            "Resuelto",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(12, 53);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(170, 33);
            this.cmbEstado.TabIndex = 3;
            // 
            // lblPriorRealAccLbl
            // 
            this.lblPriorRealAccLbl.AutoSize = true;
            this.lblPriorRealAccLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPriorRealAccLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPriorRealAccLbl.Location = new System.Drawing.Point(200, 35);
            this.lblPriorRealAccLbl.Name = "lblPriorRealAccLbl";
            this.lblPriorRealAccLbl.Size = new System.Drawing.Size(112, 23);
            this.lblPriorRealAccLbl.TabIndex = 4;
            this.lblPriorRealAccLbl.Text = "Prioridad real";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbPrioridad.Location = new System.Drawing.Point(200, 53);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(170, 33);
            this.cmbPrioridad.TabIndex = 5;
            // 
            // lblComentarioLbl
            // 
            this.lblComentarioLbl.AutoSize = true;
            this.lblComentarioLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblComentarioLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblComentarioLbl.Location = new System.Drawing.Point(12, 85);
            this.lblComentarioLbl.Name = "lblComentarioLbl";
            this.lblComentarioLbl.Size = new System.Drawing.Size(163, 23);
            this.lblComentarioLbl.TabIndex = 6;
            this.lblComentarioLbl.Text = "Agregar comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtComentario.Location = new System.Drawing.Point(12, 103);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(552, 50);
            this.txtComentario.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(420, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDeshacer.FlatAppearance.BorderSize = 0;
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeshacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeshacer.Location = new System.Drawing.Point(442, 165);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(122, 30);
            this.btnDeshacer.TabIndex = 9;
            this.btnDeshacer.Text = "↩ Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // pnlDescripcion
            // 
            this.pnlDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlDescripcion.Controls.Add(this.lblDescTitulo);
            this.pnlDescripcion.Controls.Add(this.pnlDivDesc);
            this.pnlDescripcion.Controls.Add(this.txtDescripcion);
            this.pnlDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDescripcion.Location = new System.Drawing.Point(12, 170);
            this.pnlDescripcion.Name = "pnlDescripcion";
            this.pnlDescripcion.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlDescripcion.Size = new System.Drawing.Size(576, 170);
            this.pnlDescripcion.TabIndex = 1;
            // 
            // lblDescTitulo
            // 
            this.lblDescTitulo.AutoSize = true;
            this.lblDescTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDescTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblDescTitulo.Name = "lblDescTitulo";
            this.lblDescTitulo.Size = new System.Drawing.Size(115, 21);
            this.lblDescTitulo.TabIndex = 0;
            this.lblDescTitulo.Text = "DESCRIPCIÓN";
            // 
            // pnlDivDesc
            // 
            this.pnlDivDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivDesc.Location = new System.Drawing.Point(12, 26);
            this.pnlDivDesc.Name = "pnlDivDesc";
            this.pnlDivDesc.Size = new System.Drawing.Size(552, 1);
            this.pnlDivDesc.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(552, 115);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.lblInfoTitulo);
            this.pnlInfo.Controls.Add(this.pnlDivInfo);
            this.pnlInfo.Controls.Add(this.lblUsuarioLbl);
            this.pnlInfo.Controls.Add(this.lblUsuarioVal);
            this.pnlInfo.Controls.Add(this.lblFechaLbl);
            this.pnlInfo.Controls.Add(this.lblFechaVal);
            this.pnlInfo.Controls.Add(this.lblEstadoLbl);
            this.pnlInfo.Controls.Add(this.lblEstadoVal);
            this.pnlInfo.Controls.Add(this.lblPriorUsuarioLbl);
            this.pnlInfo.Controls.Add(this.lblPriorUsuarioVal);
            this.pnlInfo.Controls.Add(this.lblPriorRealLbl);
            this.pnlInfo.Controls.Add(this.lblPriorRealVal);
            this.pnlInfo.Controls.Add(this.lblAsignadoLbl);
            this.pnlInfo.Controls.Add(this.lblAsignadoVal);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(12, 10);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlInfo.Size = new System.Drawing.Size(576, 160);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfoTitulo
            // 
            this.lblInfoTitulo.AutoSize = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblInfoTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(213, 21);
            this.lblInfoTitulo.TabIndex = 0;
            this.lblInfoTitulo.Text = "INFORMACIÓN DEL TICKET";
            // 
            // pnlDivInfo
            // 
            this.pnlDivInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivInfo.Location = new System.Drawing.Point(12, 26);
            this.pnlDivInfo.Name = "pnlDivInfo";
            this.pnlDivInfo.Size = new System.Drawing.Size(552, 1);
            this.pnlDivInfo.TabIndex = 1;
            // 
            // lblUsuarioLbl
            // 
            this.lblUsuarioLbl.AutoSize = true;
            this.lblUsuarioLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUsuarioLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUsuarioLbl.Location = new System.Drawing.Point(12, 35);
            this.lblUsuarioLbl.Name = "lblUsuarioLbl";
            this.lblUsuarioLbl.Size = new System.Drawing.Size(68, 23);
            this.lblUsuarioLbl.TabIndex = 2;
            this.lblUsuarioLbl.Text = "Usuario";
            // 
            // lblUsuarioVal
            // 
            this.lblUsuarioVal.AutoSize = true;
            this.lblUsuarioVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblUsuarioVal.Location = new System.Drawing.Point(12, 50);
            this.lblUsuarioVal.Name = "lblUsuarioVal";
            this.lblUsuarioVal.Size = new System.Drawing.Size(30, 25);
            this.lblUsuarioVal.TabIndex = 3;
            this.lblUsuarioVal.Text = "—";
            // 
            // lblFechaLbl
            // 
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFechaLbl.Location = new System.Drawing.Point(180, 35);
            this.lblFechaLbl.Name = "lblFechaLbl";
            this.lblFechaLbl.Size = new System.Drawing.Size(147, 23);
            this.lblFechaLbl.TabIndex = 4;
            this.lblFechaLbl.Text = "Fecha de creación";
            // 
            // lblFechaVal
            // 
            this.lblFechaVal.AutoSize = true;
            this.lblFechaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFechaVal.Location = new System.Drawing.Point(180, 50);
            this.lblFechaVal.Name = "lblFechaVal";
            this.lblFechaVal.Size = new System.Drawing.Size(30, 25);
            this.lblFechaVal.TabIndex = 5;
            this.lblFechaVal.Text = "—";
            // 
            // lblEstadoLbl
            // 
            this.lblEstadoLbl.AutoSize = true;
            this.lblEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstadoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEstadoLbl.Location = new System.Drawing.Point(12, 75);
            this.lblEstadoLbl.Name = "lblEstadoLbl";
            this.lblEstadoLbl.Size = new System.Drawing.Size(112, 23);
            this.lblEstadoLbl.TabIndex = 6;
            this.lblEstadoLbl.Text = "Estado actual";
            // 
            // lblEstadoVal
            // 
            this.lblEstadoVal.AutoSize = true;
            this.lblEstadoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblEstadoVal.Location = new System.Drawing.Point(12, 90);
            this.lblEstadoVal.Name = "lblEstadoVal";
            this.lblEstadoVal.Size = new System.Drawing.Size(30, 25);
            this.lblEstadoVal.TabIndex = 7;
            this.lblEstadoVal.Text = "—";
            // 
            // lblPriorUsuarioLbl
            // 
            this.lblPriorUsuarioLbl.AutoSize = true;
            this.lblPriorUsuarioLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPriorUsuarioLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPriorUsuarioLbl.Location = new System.Drawing.Point(180, 75);
            this.lblPriorUsuarioLbl.Name = "lblPriorUsuarioLbl";
            this.lblPriorUsuarioLbl.Size = new System.Drawing.Size(140, 23);
            this.lblPriorUsuarioLbl.TabIndex = 8;
            this.lblPriorUsuarioLbl.Text = "Prioridad usuario";
            // 
            // lblPriorUsuarioVal
            // 
            this.lblPriorUsuarioVal.AutoSize = true;
            this.lblPriorUsuarioVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriorUsuarioVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPriorUsuarioVal.Location = new System.Drawing.Point(180, 90);
            this.lblPriorUsuarioVal.Name = "lblPriorUsuarioVal";
            this.lblPriorUsuarioVal.Size = new System.Drawing.Size(30, 25);
            this.lblPriorUsuarioVal.TabIndex = 9;
            this.lblPriorUsuarioVal.Text = "—";
            // 
            // lblPriorRealLbl
            // 
            this.lblPriorRealLbl.AutoSize = true;
            this.lblPriorRealLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPriorRealLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPriorRealLbl.Location = new System.Drawing.Point(12, 115);
            this.lblPriorRealLbl.Name = "lblPriorRealLbl";
            this.lblPriorRealLbl.Size = new System.Drawing.Size(112, 23);
            this.lblPriorRealLbl.TabIndex = 10;
            this.lblPriorRealLbl.Text = "Prioridad real";
            // 
            // lblPriorRealVal
            // 
            this.lblPriorRealVal.AutoSize = true;
            this.lblPriorRealVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriorRealVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblPriorRealVal.Location = new System.Drawing.Point(12, 130);
            this.lblPriorRealVal.Name = "lblPriorRealVal";
            this.lblPriorRealVal.Size = new System.Drawing.Size(30, 25);
            this.lblPriorRealVal.TabIndex = 11;
            this.lblPriorRealVal.Text = "—";
            // 
            // lblAsignadoLbl
            // 
            this.lblAsignadoLbl.AutoSize = true;
            this.lblAsignadoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAsignadoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAsignadoLbl.Location = new System.Drawing.Point(180, 115);
            this.lblAsignadoLbl.Name = "lblAsignadoLbl";
            this.lblAsignadoLbl.Size = new System.Drawing.Size(95, 23);
            this.lblAsignadoLbl.TabIndex = 12;
            this.lblAsignadoLbl.Text = "Asignado a";
            // 
            // lblAsignadoVal
            // 
            this.lblAsignadoVal.AutoSize = true;
            this.lblAsignadoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAsignadoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblAsignadoVal.Location = new System.Drawing.Point(180, 130);
            this.lblAsignadoVal.Name = "lblAsignadoVal";
            this.lblAsignadoVal.Size = new System.Drawing.Size(30, 25);
            this.lblAsignadoVal.TabIndex = 13;
            this.lblAsignadoVal.Text = "—";
            this.lblAsignadoVal.Click += new System.EventHandler(this.lblAsignadoVal_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlRight.Controls.Add(this.pnlWarnDeshacer);
            this.pnlRight.Controls.Add(this.pnlTimeline);
            this.pnlRight.Controls.Add(this.pnlDivHistorial);
            this.pnlRight.Controls.Add(this.lblHistorialTitulo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(600, 45);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlRight.Size = new System.Drawing.Size(424, 635);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlWarnDeshacer
            // 
            this.pnlWarnDeshacer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWarnDeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.pnlWarnDeshacer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWarnDeshacer.Controls.Add(this.lblWarnIcono);
            this.pnlWarnDeshacer.Controls.Add(this.lblWarnTexto);
            this.pnlWarnDeshacer.Location = new System.Drawing.Point(12, 550);
            this.pnlWarnDeshacer.Name = "pnlWarnDeshacer";
            this.pnlWarnDeshacer.Padding = new System.Windows.Forms.Padding(6);
            this.pnlWarnDeshacer.Size = new System.Drawing.Size(400, 65);
            this.pnlWarnDeshacer.TabIndex = 3;
            // 
            // lblWarnIcono
            // 
            this.lblWarnIcono.AutoSize = true;
            this.lblWarnIcono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWarnIcono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblWarnIcono.Location = new System.Drawing.Point(2, 12);
            this.lblWarnIcono.Name = "lblWarnIcono";
            this.lblWarnIcono.Size = new System.Drawing.Size(43, 30);
            this.lblWarnIcono.TabIndex = 0;
            this.lblWarnIcono.Text = "⚠";
            // 
            // lblWarnTexto
            // 
            this.lblWarnTexto.AutoSize = true;
            this.lblWarnTexto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWarnTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.lblWarnTexto.Location = new System.Drawing.Point(41, 12);
            this.lblWarnTexto.Name = "lblWarnTexto";
            this.lblWarnTexto.Size = new System.Drawing.Size(348, 42);
            this.lblWarnTexto.TabIndex = 1;
            this.lblWarnTexto.Text = "\"Deshacer\" revierte únicamente el último cambio\r\nguardado en este ticket.";
            // 
            // pnlTimeline
            // 
            this.pnlTimeline.AutoSize = true;
            this.pnlTimeline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTimeline.BackColor = System.Drawing.Color.Transparent;
            this.pnlTimeline.Location = new System.Drawing.Point(12, 35);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(0, 0);
            this.pnlTimeline.TabIndex = 2;
            // 
            // pnlDivHistorial
            // 
            this.pnlDivHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivHistorial.Location = new System.Drawing.Point(12, 26);
            this.pnlDivHistorial.Name = "pnlDivHistorial";
            this.pnlDivHistorial.Size = new System.Drawing.Size(400, 1);
            this.pnlDivHistorial.TabIndex = 1;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblHistorialTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHistorialTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(191, 21);
            this.lblHistorialTitulo.TabIndex = 0;
            this.lblHistorialTitulo.Text = "HISTORIAL DE CAMBIOS";
            // 
            // DetalleTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1024, 680);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DetalleTicket";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.pnlDescripcion.ResumeLayout(false);
            this.pnlDescripcion.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlWarnDeshacer.ResumeLayout(false);
            this.pnlWarnDeshacer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Label lblBadgeId;
        private System.Windows.Forms.Label lblBadgeEstado;
        private System.Windows.Forms.Label lblBadgePrioridad;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Panel pnlDivInfo;
        private System.Windows.Forms.Label lblUsuarioLbl;
        public System.Windows.Forms.Label lblUsuarioVal;
        private System.Windows.Forms.Label lblFechaLbl;
        public System.Windows.Forms.Label lblFechaVal;
        private System.Windows.Forms.Label lblEstadoLbl;
        public System.Windows.Forms.Label lblEstadoVal;
        private System.Windows.Forms.Label lblPriorUsuarioLbl;
        public System.Windows.Forms.Label lblPriorUsuarioVal;
        private System.Windows.Forms.Label lblPriorRealLbl;
        public System.Windows.Forms.Label lblPriorRealVal;
        private System.Windows.Forms.Label lblAsignadoLbl;
        public System.Windows.Forms.Label lblAsignadoVal;
        private System.Windows.Forms.Panel pnlDescripcion;
        private System.Windows.Forms.Label lblDescTitulo;
        private System.Windows.Forms.Panel pnlDivDesc;
        public System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label lblAccTitulo;
        private System.Windows.Forms.Panel pnlDivAcc;
        private System.Windows.Forms.Label lblCambiarEstadoLbl;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblPriorRealAccLbl;
        public System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblComentarioLbl;
        public System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblHistorialTitulo;
        private System.Windows.Forms.Panel pnlDivHistorial;
        public System.Windows.Forms.Panel pnlTimeline;
        private System.Windows.Forms.Panel pnlWarnDeshacer;
        private System.Windows.Forms.Label lblWarnIcono;
        private System.Windows.Forms.Label lblWarnTexto;
    }
}