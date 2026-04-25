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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblIniciales = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();

            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();

            // ── Bloque: Título y Descripción ──
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTituloLbl = new System.Windows.Forms.Label();
            this.lblTituloVal = new System.Windows.Forms.Label();

            this.pnlDescripcion = new System.Windows.Forms.Panel();
            this.lblDescLbl = new System.Windows.Forms.Label();
            this.lblDescVal = new System.Windows.Forms.Label();

            // ── Bloque: Estado y Fecha (fila) ──
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstadoLbl = new System.Windows.Forms.Label();
            this.lblEstadoVal = new System.Windows.Forms.Label();

            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.lblFechaVal = new System.Windows.Forms.Label();

            // ── Bloque: Comparador de prioridades ──
            this.pnlPrioridades = new System.Windows.Forms.Panel();
            this.lblPrioLbl = new System.Windows.Forms.Label();
            this.pnlPrioUser = new System.Windows.Forms.Panel();
            this.lblPrioUserLbl = new System.Windows.Forms.Label();
            this.lblPrioUserVal = new System.Windows.Forms.Label();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.pnlPrioReal = new System.Windows.Forms.Panel();
            this.lblPrioRealLbl = new System.Windows.Forms.Label();
            this.lblPrioRealVal = new System.Windows.Forms.Label();

            // ── Historial ──
            this.lblHistorialLbl = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();

            // ── Comentarios ──
            this.lblComentariosLbl = new System.Windows.Forms.Label();
            this.lstComentarios = new System.Windows.Forms.ListBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();

            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlDescripcion.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlPrioridades.SuspendLayout();
            this.pnlPrioUser.SuspendLayout();
            this.pnlPrioReal.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════════════
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 720);
            this.MinimumSize = new System.Drawing.Size(760, 620);
            this.Text = "Detalle de Ticket — TicketsMDB";
            this.BackColor = System.Drawing.Color.White;
            this.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);

            // ════════════════════════════════════════════════════════
            // TOPBAR
            // ════════════════════════════════════════════════════════
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 54;
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(21, 40, 73);
            this.pnlTopBar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBrand, this.pnlAvatar, this.lblNombreUsuario
            });

            this.lblBrand.Text = "  TicketsMDB";
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(16, 16);

            this.pnlAvatar.Size = new System.Drawing.Size(30, 30);
            this.pnlAvatar.Location = new System.Drawing.Point(718, 12);
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatar.Controls.Add(this.lblIniciales);

            this.lblIniciales.Text = "JD";
            this.lblIniciales.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblIniciales.ForeColor = System.Drawing.Color.White;
            this.lblIniciales.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIniciales.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblNombreUsuario.Text = "Juan Díaz";
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(755, 18);
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // ════════════════════════════════════════════════════════
            // CONTENT
            // ════════════════════════════════════════════════════════
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 20, 28, 20);
            this.pnlContent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnVolver,
                this.pnlTitulo, this.pnlDescripcion,
                this.pnlEstado, this.pnlFecha,
                this.pnlPrioridades,
                this.lblHistorialLbl, this.lstHistorial,
                this.lblComentariosLbl, this.lstComentarios,
                this.txtComentario, this.btnEnviar
            });

            // Botón Volver
            this.btnVolver.Text = "← Volver a mis tickets";
            this.btnVolver.Location = new System.Drawing.Point(0, 0);
            this.btnVolver.Size = new System.Drawing.Size(170, 28);
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;

            // ════════════════════════════════════════════════════════
            // PANEL TÍTULO
            // ════════════════════════════════════════════════════════
            this.pnlTitulo.Location = new System.Drawing.Point(0, 38);
            this.pnlTitulo.Size = new System.Drawing.Size(800, 64);
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.pnlTitulo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTituloLbl, this.lblTituloVal
            });

            this.lblTituloLbl.Text = "TÍTULO";
            this.lblTituloLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTituloLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLbl.AutoSize = true;
            this.lblTituloLbl.Location = new System.Drawing.Point(14, 10);

            this.lblTituloVal.Text = "—";
            this.lblTituloVal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloVal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloVal.AutoSize = false;
            this.lblTituloVal.Size = new System.Drawing.Size(770, 30);
            this.lblTituloVal.Location = new System.Drawing.Point(14, 32);

            // ════════════════════════════════════════════════════════
            // PANEL DESCRIPCIÓN
            // ════════════════════════════════════════════════════════
            this.pnlDescripcion.Location = new System.Drawing.Point(0, 114);
            this.pnlDescripcion.Size = new System.Drawing.Size(800, 80);
            this.pnlDescripcion.BackColor = System.Drawing.Color.White;
            this.pnlDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.pnlDescripcion.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblDescLbl, this.lblDescVal
            });

            this.lblDescLbl.Text = "DESCRIPCIÓN";
            this.lblDescLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblDescLbl.AutoSize = true;
            this.lblDescLbl.Location = new System.Drawing.Point(14, 10);

            this.lblDescVal.Text = "—";
            this.lblDescVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescVal.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDescVal.BackColor = System.Drawing.Color.Transparent;
            this.lblDescVal.AutoSize = false;
            this.lblDescVal.Size = new System.Drawing.Size(770, 50);
            this.lblDescVal.Location = new System.Drawing.Point(14, 30);

            // ════════════════════════════════════════════════════════
            // PANEL ESTADO (mitad izquierda)
            // ════════════════════════════════════════════════════════
            this.pnlEstado.Location = new System.Drawing.Point(0, 206);
            this.pnlEstado.Size = new System.Drawing.Size(390, 56);
            this.pnlEstado.BackColor = System.Drawing.Color.White;
            this.pnlEstado.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top;
            this.pnlEstado.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblEstadoLbl, this.lblEstadoVal
            });

            this.lblEstadoLbl.Text = "ESTADO";
            this.lblEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEstadoLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblEstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoLbl.AutoSize = true;
            this.lblEstadoLbl.Location = new System.Drawing.Point(14, 8);

            this.lblEstadoVal.Text = "—";
            this.lblEstadoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoVal.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblEstadoVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoVal.AutoSize = true;
            this.lblEstadoVal.Location = new System.Drawing.Point(14, 28);

            // ════════════════════════════════════════════════════════
            // PANEL FECHA (mitad derecha)
            // ════════════════════════════════════════════════════════
            this.pnlFecha.Location = new System.Drawing.Point(410, 206);
            this.pnlFecha.Size = new System.Drawing.Size(390, 56);
            this.pnlFecha.BackColor = System.Drawing.Color.White;
            this.pnlFecha.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top;
            this.pnlFecha.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFechaLbl, this.lblFechaVal
            });

            this.lblFechaLbl.Text = "FECHA DE CREACIÓN";
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFechaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.Location = new System.Drawing.Point(14, 8);

            this.lblFechaVal.Text = "—";
            this.lblFechaVal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaVal.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFechaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVal.AutoSize = true;
            this.lblFechaVal.Location = new System.Drawing.Point(14, 28);

            // ════════════════════════════════════════════════════════
            // PANEL PRIORIDADES (comparador)
            // ════════════════════════════════════════════════════════
            this.pnlPrioridades.Location = new System.Drawing.Point(0, 274);
            this.pnlPrioridades.Size = new System.Drawing.Size(800, 80);
            this.pnlPrioridades.BackColor = System.Drawing.Color.White;
            this.pnlPrioridades.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.pnlPrioridades.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPrioLbl, this.pnlPrioUser, this.lblFlecha, this.pnlPrioReal
            });

            this.lblPrioLbl.Text = "PRIORIDAD";
            this.lblPrioLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrioLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPrioLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioLbl.AutoSize = true;
            this.lblPrioLbl.Location = new System.Drawing.Point(14, 8);

            // Sub-panel prioridad usuario
            this.pnlPrioUser.Location = new System.Drawing.Point(14, 28);
            this.pnlPrioUser.Size = new System.Drawing.Size(180, 40);
            this.pnlPrioUser.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.pnlPrioUser.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPrioUserLbl, this.lblPrioUserVal
            });

            this.lblPrioUserLbl.Text = "ASIGNADA POR TI";
            this.lblPrioUserLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioUserLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPrioUserLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioUserLbl.AutoSize = true;
            this.lblPrioUserLbl.Location = new System.Drawing.Point(10, 4);

            this.lblPrioUserVal.Text = "—";
            this.lblPrioUserVal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrioUserVal.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblPrioUserVal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioUserVal.AutoSize = true;
            this.lblPrioUserVal.Location = new System.Drawing.Point(10, 20);

            // Flecha
            this.lblFlecha.Text = "→";
            this.lblFlecha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFlecha.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblFlecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Location = new System.Drawing.Point(202, 38);

            // Sub-panel prioridad real
            this.pnlPrioReal.Location = new System.Drawing.Point(228, 28);
            this.pnlPrioReal.Size = new System.Drawing.Size(180, 40);
            this.pnlPrioReal.BackColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.pnlPrioReal.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPrioRealLbl, this.lblPrioRealVal
            });

            this.lblPrioRealLbl.Text = "REAL (ADMIN)";
            this.lblPrioRealLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioRealLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPrioRealLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioRealLbl.AutoSize = true;
            this.lblPrioRealLbl.Location = new System.Drawing.Point(10, 4);

            this.lblPrioRealVal.Text = "—";
            this.lblPrioRealVal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrioRealVal.ForeColor = System.Drawing.Color.FromArgb(5, 122, 85);
            this.lblPrioRealVal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioRealVal.AutoSize = true;
            this.lblPrioRealVal.Location = new System.Drawing.Point(10, 20);

            // ════════════════════════════════════════════════════════
            // HISTORIAL (solo lectura)
            // ════════════════════════════════════════════════════════
            this.lblHistorialLbl.Text = "HISTORIAL";
            this.lblHistorialLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblHistorialLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblHistorialLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorialLbl.AutoSize = true;
            this.lblHistorialLbl.Location = new System.Drawing.Point(0, 368);

            this.lstHistorial.Location = new System.Drawing.Point(0, 388);
            this.lstHistorial.Size = new System.Drawing.Size(800, 100);
            this.lstHistorial.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistorial.BackColor = System.Drawing.Color.White;
            this.lstHistorial.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lstHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistorial.SelectionMode = System.Windows.Forms.SelectionMode.None;

            // ════════════════════════════════════════════════════════
            // COMENTARIOS
            // ════════════════════════════════════════════════════════
            this.lblComentariosLbl.Text = "COMENTARIOS";
            this.lblComentariosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblComentariosLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblComentariosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblComentariosLbl.AutoSize = true;
            this.lblComentariosLbl.Location = new System.Drawing.Point(0, 502);

            this.lstComentarios.Location = new System.Drawing.Point(0, 522);
            this.lstComentarios.Size = new System.Drawing.Size(800, 110);
            this.lstComentarios.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.lstComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComentarios.BackColor = System.Drawing.Color.White;
            this.lstComentarios.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lstComentarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstComentarios.SelectionMode = System.Windows.Forms.SelectionMode.None;

            // TextBox nuevo comentario
            this.txtComentario.Location = new System.Drawing.Point(0, 644);
            this.txtComentario.Size = new System.Drawing.Size(680, 58);
            this.txtComentario.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.txtComentario.Multiline = true;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.MaxLength = 500;
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Botón Enviar comentario
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Location = new System.Drawing.Point(690, 644);
            this.btnEnviar.Size = new System.Drawing.Size(110, 58);
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);

            // ── Resume ─────────────────────────────────────────────────
            this.pnlPrioUser.ResumeLayout(false);
            this.pnlPrioUser.PerformLayout();
            this.pnlPrioReal.ResumeLayout(false);
            this.pnlPrioReal.PerformLayout();
            this.pnlPrioridades.ResumeLayout(false);
            this.pnlPrioridades.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlDescripcion.ResumeLayout(false);
            this.pnlDescripcion.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Declaración de controles ──────────────────────────────────────
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblIniciales;
        private System.Windows.Forms.Label lblNombreUsuario;

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