namespace TicketsMDB.Clientes
{
    partial class FormDetalleTicket
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTituloLbl = new System.Windows.Forms.Label();
            this.lblTituloVal = new System.Windows.Forms.Label();
            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.lblDescLbl = new System.Windows.Forms.Label();
            this.lblDescVal = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstadoLbl = new System.Windows.Forms.Label();
            this.lblEstadoVal = new System.Windows.Forms.Label();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.lblFechaVal = new System.Windows.Forms.Label();
            this.pnlPrioridades = new System.Windows.Forms.Panel();
            this.lblPrioLbl = new System.Windows.Forms.Label();
            this.pnlPrioUser = new System.Windows.Forms.Panel();
            this.lblPrioUserLbl = new System.Windows.Forms.Label();
            this.lblPrioUserVal = new System.Windows.Forms.Label();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.pnlPrioReal = new System.Windows.Forms.Panel();
            this.lblPrioRealLbl = new System.Windows.Forms.Label();
            this.lblPrioRealVal = new System.Windows.Forms.Label();
            this.lblHistorialLbl = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblComentariosLbl = new System.Windows.Forms.Label();
            this.lstComentarios = new System.Windows.Forms.ListBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlDescripcion.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlPrioridades.SuspendLayout();
            this.pnlPrioUser.SuspendLayout();
            this.pnlPrioReal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.btnVolver);
            this.pnlContent.Controls.Add(this.pnlTitulo);
            this.pnlContent.Controls.Add(this.pnlDescripcion);
            this.pnlContent.Controls.Add(this.pnlEstado);
            this.pnlContent.Controls.Add(this.pnlFecha);
            this.pnlContent.Controls.Add(this.pnlPrioridades);
            this.pnlContent.Controls.Add(this.lblHistorialLbl);
            this.pnlContent.Controls.Add(this.lstHistorial);
            this.pnlContent.Controls.Add(this.lblComentariosLbl);
            this.pnlContent.Controls.Add(this.lstComentarios);
            this.pnlContent.Controls.Add(this.txtComentario);
            this.pnlContent.Controls.Add(this.btnEnviar);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 20, 28, 20);
            this.pnlContent.Size = new System.Drawing.Size(860, 720);
            this.pnlContent.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnVolver.Location = new System.Drawing.Point(0, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(261, 28);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "← Volver a mis tickets";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.lblTituloLbl);
            this.pnlTitulo.Controls.Add(this.lblTituloVal);
            this.pnlTitulo.Location = new System.Drawing.Point(11, 34);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(837, 64);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTituloLbl
            // 
            this.lblTituloLbl.AutoSize = true;
            this.lblTituloLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTituloLbl.Location = new System.Drawing.Point(14, 10);
            this.lblTituloLbl.Name = "lblTituloLbl";
            this.lblTituloLbl.Size = new System.Drawing.Size(65, 21);
            this.lblTituloLbl.TabIndex = 0;
            this.lblTituloLbl.Text = "TÍTULO";
            // 
            // lblTituloVal
            // 
            this.lblTituloVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloVal.Location = new System.Drawing.Point(14, 32);
            this.lblTituloVal.Name = "lblTituloVal";
            this.lblTituloVal.Size = new System.Drawing.Size(770, 30);
            this.lblTituloVal.TabIndex = 1;
            this.lblTituloVal.Text = "—";
            // 
            // pnlDescripcion
            // 
            this.pnlDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlDescripcion.Controls.Add(this.lblDescLbl);
            this.pnlDescripcion.Controls.Add(this.lblDescVal);
            this.pnlDescripcion.Location = new System.Drawing.Point(12, 104);
            this.pnlDescripcion.Name = "pnlDescripcion";
            this.pnlDescripcion.Size = new System.Drawing.Size(837, 96);
            this.pnlDescripcion.TabIndex = 2;
            // 
            // lblDescLbl
            // 
            this.lblDescLbl.AutoSize = true;
            this.lblDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblDescLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDescLbl.Location = new System.Drawing.Point(14, 10);
            this.lblDescLbl.Name = "lblDescLbl";
            this.lblDescLbl.Size = new System.Drawing.Size(115, 21);
            this.lblDescLbl.TabIndex = 0;
            this.lblDescLbl.Text = "DESCRIPCIÓN";
            // 
            // lblDescVal
            // 
            this.lblDescVal.BackColor = System.Drawing.Color.Transparent;
            this.lblDescVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDescVal.Location = new System.Drawing.Point(14, 30);
            this.lblDescVal.Name = "lblDescVal";
            this.lblDescVal.Size = new System.Drawing.Size(770, 50);
            this.lblDescVal.TabIndex = 1;
            this.lblDescVal.Text = "—";
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.White;
            this.pnlEstado.Controls.Add(this.lblEstadoLbl);
            this.pnlEstado.Controls.Add(this.lblEstadoVal);
            this.pnlEstado.Location = new System.Drawing.Point(18, 206);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(390, 56);
            this.pnlEstado.TabIndex = 3;
            // 
            // lblEstadoLbl
            // 
            this.lblEstadoLbl.AutoSize = true;
            this.lblEstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstadoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEstadoLbl.Location = new System.Drawing.Point(14, 8);
            this.lblEstadoLbl.Name = "lblEstadoLbl";
            this.lblEstadoLbl.Size = new System.Drawing.Size(71, 21);
            this.lblEstadoLbl.TabIndex = 0;
            this.lblEstadoLbl.Text = "ESTADO";
            // 
            // lblEstadoVal
            // 
            this.lblEstadoVal.AutoSize = true;
            this.lblEstadoVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblEstadoVal.Location = new System.Drawing.Point(14, 28);
            this.lblEstadoVal.Name = "lblEstadoVal";
            this.lblEstadoVal.Size = new System.Drawing.Size(32, 28);
            this.lblEstadoVal.TabIndex = 1;
            this.lblEstadoVal.Text = "—";
            // 
            // pnlFecha
            // 
            this.pnlFecha.BackColor = System.Drawing.Color.White;
            this.pnlFecha.Controls.Add(this.lblFechaLbl);
            this.pnlFecha.Controls.Add(this.lblFechaVal);
            this.pnlFecha.Location = new System.Drawing.Point(458, 206);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(390, 56);
            this.pnlFecha.TabIndex = 4;
            // 
            // lblFechaLbl
            // 
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFechaLbl.Location = new System.Drawing.Point(14, 8);
            this.lblFechaLbl.Name = "lblFechaLbl";
            this.lblFechaLbl.Size = new System.Drawing.Size(169, 21);
            this.lblFechaLbl.TabIndex = 0;
            this.lblFechaLbl.Text = "FECHA DE CREACIÓN";
            // 
            // lblFechaVal
            // 
            this.lblFechaVal.AutoSize = true;
            this.lblFechaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFechaVal.Location = new System.Drawing.Point(14, 28);
            this.lblFechaVal.Name = "lblFechaVal";
            this.lblFechaVal.Size = new System.Drawing.Size(32, 28);
            this.lblFechaVal.TabIndex = 1;
            this.lblFechaVal.Text = "—";
            // 
            // pnlPrioridades
            // 
            this.pnlPrioridades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrioridades.BackColor = System.Drawing.Color.White;
            this.pnlPrioridades.Controls.Add(this.lblPrioLbl);
            this.pnlPrioridades.Controls.Add(this.pnlPrioUser);
            this.pnlPrioridades.Controls.Add(this.lblFlecha);
            this.pnlPrioridades.Controls.Add(this.pnlPrioReal);
            this.pnlPrioridades.Location = new System.Drawing.Point(18, 285);
            this.pnlPrioridades.Name = "pnlPrioridades";
            this.pnlPrioridades.Size = new System.Drawing.Size(830, 80);
            this.pnlPrioridades.TabIndex = 5;
            // 
            // lblPrioLbl
            // 
            this.lblPrioLbl.AutoSize = true;
            this.lblPrioLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrioLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPrioLbl.Location = new System.Drawing.Point(14, 8);
            this.lblPrioLbl.Name = "lblPrioLbl";
            this.lblPrioLbl.Size = new System.Drawing.Size(97, 21);
            this.lblPrioLbl.TabIndex = 0;
            this.lblPrioLbl.Text = "PRIORIDAD";
            // 
            // pnlPrioUser
            // 
            this.pnlPrioUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlPrioUser.Controls.Add(this.lblPrioUserLbl);
            this.pnlPrioUser.Controls.Add(this.lblPrioUserVal);
            this.pnlPrioUser.Location = new System.Drawing.Point(14, 28);
            this.pnlPrioUser.Name = "pnlPrioUser";
            this.pnlPrioUser.Size = new System.Drawing.Size(180, 40);
            this.pnlPrioUser.TabIndex = 1;
            // 
            // lblPrioUserLbl
            // 
            this.lblPrioUserLbl.AutoSize = true;
            this.lblPrioUserLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioUserLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPrioUserLbl.Location = new System.Drawing.Point(10, 4);
            this.lblPrioUserLbl.Name = "lblPrioUserLbl";
            this.lblPrioUserLbl.Size = new System.Drawing.Size(141, 20);
            this.lblPrioUserLbl.TabIndex = 0;
            this.lblPrioUserLbl.Text = "ASIGNADA POR TI";
            // 
            // lblPrioUserVal
            // 
            this.lblPrioUserVal.AutoSize = true;
            this.lblPrioUserVal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioUserVal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrioUserVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPrioUserVal.Location = new System.Drawing.Point(10, 20);
            this.lblPrioUserVal.Name = "lblPrioUserVal";
            this.lblPrioUserVal.Size = new System.Drawing.Size(35, 30);
            this.lblPrioUserVal.TabIndex = 1;
            this.lblPrioUserVal.Text = "—";
            // 
            // lblFlecha
            // 
            this.lblFlecha.AutoSize = true;
            this.lblFlecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFlecha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFlecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFlecha.Location = new System.Drawing.Point(202, 38);
            this.lblFlecha.Name = "lblFlecha";
            this.lblFlecha.Size = new System.Drawing.Size(41, 38);
            this.lblFlecha.TabIndex = 2;
            this.lblFlecha.Text = "→";
            // 
            // pnlPrioReal
            // 
            this.pnlPrioReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlPrioReal.Controls.Add(this.lblPrioRealLbl);
            this.pnlPrioReal.Controls.Add(this.lblPrioRealVal);
            this.pnlPrioReal.Location = new System.Drawing.Point(228, 28);
            this.pnlPrioReal.Name = "pnlPrioReal";
            this.pnlPrioReal.Size = new System.Drawing.Size(180, 40);
            this.pnlPrioReal.TabIndex = 3;
            // 
            // lblPrioRealLbl
            // 
            this.lblPrioRealLbl.AutoSize = true;
            this.lblPrioRealLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioRealLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioRealLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPrioRealLbl.Location = new System.Drawing.Point(10, 4);
            this.lblPrioRealLbl.Name = "lblPrioRealLbl";
            this.lblPrioRealLbl.Size = new System.Drawing.Size(115, 20);
            this.lblPrioRealLbl.TabIndex = 0;
            this.lblPrioRealLbl.Text = "REAL (ADMIN)";
            // 
            // lblPrioRealVal
            // 
            this.lblPrioRealVal.AutoSize = true;
            this.lblPrioRealVal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioRealVal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrioRealVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblPrioRealVal.Location = new System.Drawing.Point(10, 20);
            this.lblPrioRealVal.Name = "lblPrioRealVal";
            this.lblPrioRealVal.Size = new System.Drawing.Size(35, 30);
            this.lblPrioRealVal.TabIndex = 1;
            this.lblPrioRealVal.Text = "—";
            // 
            // lblHistorialLbl
            // 
            this.lblHistorialLbl.AutoSize = true;
            this.lblHistorialLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorialLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblHistorialLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHistorialLbl.Location = new System.Drawing.Point(0, 368);
            this.lblHistorialLbl.Name = "lblHistorialLbl";
            this.lblHistorialLbl.Size = new System.Drawing.Size(90, 21);
            this.lblHistorialLbl.TabIndex = 6;
            this.lblHistorialLbl.Text = "HISTORIAL";
            // 
            // lstHistorial
            // 
            this.lstHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistorial.BackColor = System.Drawing.Color.White;
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lstHistorial.ItemHeight = 25;
            this.lstHistorial.Location = new System.Drawing.Point(11, 392);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstHistorial.Size = new System.Drawing.Size(839, 77);
            this.lstHistorial.TabIndex = 7;
            // 
            // lblComentariosLbl
            // 
            this.lblComentariosLbl.AutoSize = true;
            this.lblComentariosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblComentariosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblComentariosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblComentariosLbl.Location = new System.Drawing.Point(7, 479);
            this.lblComentariosLbl.Name = "lblComentariosLbl";
            this.lblComentariosLbl.Size = new System.Drawing.Size(124, 21);
            this.lblComentariosLbl.TabIndex = 8;
            this.lblComentariosLbl.Text = "COMENTARIOS";
            // 
            // lstComentarios
            // 
            this.lstComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstComentarios.BackColor = System.Drawing.Color.White;
            this.lstComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComentarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lstComentarios.ItemHeight = 25;
            this.lstComentarios.Location = new System.Drawing.Point(11, 512);
            this.lstComentarios.Name = "lstComentarios";
            this.lstComentarios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstComentarios.Size = new System.Drawing.Size(832, 102);
            this.lstComentarios.TabIndex = 9;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtComentario.Location = new System.Drawing.Point(14, 639);
            this.txtComentario.MaxLength = 500;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(829, 58);
            this.txtComentario.TabIndex = 10;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(1350, 644);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(110, 58);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // FormDetalleTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 720);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.MinimumSize = new System.Drawing.Size(760, 620);
            this.Name = "FormDetalleTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Ticket — TicketsMDB";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlDescripcion.ResumeLayout(false);
            this.pnlDescripcion.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.pnlPrioridades.ResumeLayout(false);
            this.pnlPrioridades.PerformLayout();
            this.pnlPrioUser.ResumeLayout(false);
            this.pnlPrioUser.PerformLayout();
            this.pnlPrioReal.ResumeLayout(false);
            this.pnlPrioReal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnVolver;

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTituloLbl;
        private System.Windows.Forms.Label lblTituloVal;

        private System.Windows.Forms.Panel pnlDescripcion;
        private System.Windows.Forms.Label lblDescLbl;
        private System.Windows.Forms.Label lblDescVal;

        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblEstadoLbl;
        private System.Windows.Forms.Label lblEstadoVal;

        private System.Windows.Forms.Panel pnlFecha;
        private System.Windows.Forms.Label lblFechaLbl;
        private System.Windows.Forms.Label lblFechaVal;

        private System.Windows.Forms.Panel pnlPrioridades;
        private System.Windows.Forms.Label lblPrioLbl;
        private System.Windows.Forms.Panel pnlPrioUser;
        private System.Windows.Forms.Label lblPrioUserLbl;
        private System.Windows.Forms.Label lblPrioUserVal;
        private System.Windows.Forms.Label lblFlecha;
        private System.Windows.Forms.Panel pnlPrioReal;
        private System.Windows.Forms.Label lblPrioRealLbl;
        private System.Windows.Forms.Label lblPrioRealVal;

        private System.Windows.Forms.Label lblHistorialLbl;
        private System.Windows.Forms.ListBox lstHistorial;

        private System.Windows.Forms.Label lblComentariosLbl;
        private System.Windows.Forms.ListBox lstComentarios;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnEnviar;
    }
}