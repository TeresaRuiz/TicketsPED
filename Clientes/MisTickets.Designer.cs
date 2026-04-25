namespace TicketsMDB.Clientes
{
    partial class MisTickets
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();

            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnFiltroTodos = new System.Windows.Forms.Button();
            this.btnFiltroAbierto = new System.Windows.Forms.Button();
            this.btnFiltroProceso = new System.Windows.Forms.Button();
            this.btnFiltroCerrado = new System.Windows.Forms.Button();

            this.lvTickets = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colTitulo = new System.Windows.Forms.ColumnHeader();
            this.colEstado = new System.Windows.Forms.ColumnHeader();
            this.colPrioUser = new System.Windows.Forms.ColumnHeader();
            this.colPrioReal = new System.Windows.Forms.ColumnHeader();
            this.colFecha = new System.Windows.Forms.ColumnHeader();
            this.colAccion = new System.Windows.Forms.ColumnHeader();

            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════════════
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Text = "Mis Tickets — TicketsMDB";
            this.BackColor = System.Drawing.Color.White;
            this.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
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
            this.pnlAvatar.Location = new System.Drawing.Point(778, 12);
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
            this.lblNombreUsuario.Location = new System.Drawing.Point(815, 18);
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // ════════════════════════════════════════════════════════
            // CONTENT
            // ════════════════════════════════════════════════════════
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 22, 28, 20);
            this.pnlContent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPageTitle, this.lblPageSub,
                this.pnlFiltros,
                this.lvTickets
            });

            this.lblPageTitle.Text = "Mis tickets";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);

            this.lblPageSub.Text = "Listado completo de tus solicitudes de soporte.";
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPageSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.Location = new System.Drawing.Point(0, 34);

            // ════════════════════════════════════════════════════════
            // PANEL FILTROS
            // ════════════════════════════════════════════════════════
            this.pnlFiltros.Location = new System.Drawing.Point(0, 66);
            this.pnlFiltros.Size = new System.Drawing.Size(860, 34);
            this.pnlFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltros.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.pnlFiltros.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnFiltroTodos, this.btnFiltroAbierto,
                this.btnFiltroProceso, this.btnFiltroCerrado
            });

            // Botón Todos (activo por defecto)
            this.btnFiltroTodos.Text = "Todos";
            this.btnFiltroTodos.Location = new System.Drawing.Point(0, 0);
            this.btnFiltroTodos.Size = new System.Drawing.Size(72, 28);
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.btnFiltroTodos.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltroTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(191, 219, 254);
            this.btnFiltroTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(219, 234, 254);

            // Botón Abiertos
            this.btnFiltroAbierto.Text = "Abiertos";
            this.btnFiltroAbierto.Location = new System.Drawing.Point(80, 0);
            this.btnFiltroAbierto.Size = new System.Drawing.Size(80, 28);
            this.btnFiltroAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAbierto.BackColor = System.Drawing.Color.White;
            this.btnFiltroAbierto.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnFiltroAbierto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroAbierto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnFiltroAbierto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // Botón En proceso
            this.btnFiltroProceso.Text = "En proceso";
            this.btnFiltroProceso.Location = new System.Drawing.Point(168, 0);
            this.btnFiltroProceso.Size = new System.Drawing.Size(90, 28);
            this.btnFiltroProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroProceso.BackColor = System.Drawing.Color.White;
            this.btnFiltroProceso.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnFiltroProceso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroProceso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnFiltroProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // Botón Cerrados
            this.btnFiltroCerrado.Text = "Cerrados";
            this.btnFiltroCerrado.Location = new System.Drawing.Point(266, 0);
            this.btnFiltroCerrado.Size = new System.Drawing.Size(80, 28);
            this.btnFiltroCerrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCerrado.BackColor = System.Drawing.Color.White;
            this.btnFiltroCerrado.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnFiltroCerrado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroCerrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnFiltroCerrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // ════════════════════════════════════════════════════════
            // LISTVIEW TICKETS
            // ════════════════════════════════════════════════════════
            this.lvTickets.Location = new System.Drawing.Point(0, 112);
            this.lvTickets.Size = new System.Drawing.Size(860, 420);
            this.lvTickets.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.GridLines = false;
            this.lvTickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTickets.BackColor = System.Drawing.Color.White;
            this.lvTickets.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lvTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvTickets.MultiSelect = false;

            this.colId.Text = "#";
            this.colId.Width = 52;

            this.colTitulo.Text = "Título";
            this.colTitulo.Width = 280;

            this.colEstado.Text = "Estado";
            this.colEstado.Width = 100;

            this.colPrioUser.Text = "Prioridad usuario";
            this.colPrioUser.Width = 130;

            this.colPrioReal.Text = "Prioridad real";
            this.colPrioReal.Width = 110;

            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 130;

            this.colAccion.Text = "Acción";
            this.colAccion.Width = 100;

            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colId, this.colTitulo, this.colEstado,
                this.colPrioUser, this.colPrioReal,
                this.colFecha, this.colAccion
            });

            // ── Resume ─────────────────────────────────────────────────
            this.pnlFiltros.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnFiltroTodos;
        private System.Windows.Forms.Button btnFiltroAbierto;
        private System.Windows.Forms.Button btnFiltroProceso;
        private System.Windows.Forms.Button btnFiltroCerrado;

        private System.Windows.Forms.ListView lvTickets;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitulo;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colPrioUser;
        private System.Windows.Forms.ColumnHeader colPrioReal;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colAccion;
    }
}