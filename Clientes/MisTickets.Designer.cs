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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnFiltroTodos = new System.Windows.Forms.Button();
            this.btnFiltroAbierto = new System.Windows.Forms.Button();
            this.btnFiltroProceso = new System.Windows.Forms.Button();
            this.btnFiltroCerrado = new System.Windows.Forms.Button();
            this.lvTickets = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioReal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlContent.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblPageTitle);
            this.pnlContent.Controls.Add(this.lblPageSub);
            this.pnlContent.Controls.Add(this.pnlFiltros);
            this.pnlContent.Controls.Add(this.lvTickets);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 22, 28, 20);
            this.pnlContent.Size = new System.Drawing.Size(920, 600);
            this.pnlContent.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(163, 41);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Mis tickets";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSub.Location = new System.Drawing.Point(0, 34);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(388, 25);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Listado completo de tus solicitudes de soporte.";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiltros.Controls.Add(this.btnFiltroTodos);
            this.pnlFiltros.Controls.Add(this.btnFiltroAbierto);
            this.pnlFiltros.Controls.Add(this.btnFiltroProceso);
            this.pnlFiltros.Controls.Add(this.btnFiltroCerrado);
            this.pnlFiltros.Location = new System.Drawing.Point(0, 66);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1580, 34);
            this.pnlFiltros.TabIndex = 2;
            // 
            // btnFiltroTodos
            // 
            this.btnFiltroTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnFiltroTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnFiltroTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltroTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFiltroTodos.Location = new System.Drawing.Point(0, 0);
            this.btnFiltroTodos.Name = "btnFiltroTodos";
            this.btnFiltroTodos.Size = new System.Drawing.Size(72, 28);
            this.btnFiltroTodos.TabIndex = 0;
            this.btnFiltroTodos.Text = "Todos";
            this.btnFiltroTodos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroAbierto
            // 
            this.btnFiltroAbierto.BackColor = System.Drawing.Color.White;
            this.btnFiltroAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroAbierto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroAbierto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnFiltroAbierto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAbierto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroAbierto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroAbierto.Location = new System.Drawing.Point(80, 0);
            this.btnFiltroAbierto.Name = "btnFiltroAbierto";
            this.btnFiltroAbierto.Size = new System.Drawing.Size(80, 28);
            this.btnFiltroAbierto.TabIndex = 1;
            this.btnFiltroAbierto.Text = "Abiertos";
            this.btnFiltroAbierto.UseVisualStyleBackColor = false;
            // 
            // btnFiltroProceso
            // 
            this.btnFiltroProceso.BackColor = System.Drawing.Color.White;
            this.btnFiltroProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroProceso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnFiltroProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroProceso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroProceso.Location = new System.Drawing.Point(168, 0);
            this.btnFiltroProceso.Name = "btnFiltroProceso";
            this.btnFiltroProceso.Size = new System.Drawing.Size(90, 28);
            this.btnFiltroProceso.TabIndex = 2;
            this.btnFiltroProceso.Text = "En proceso";
            this.btnFiltroProceso.UseVisualStyleBackColor = false;
            // 
            // btnFiltroCerrado
            // 
            this.btnFiltroCerrado.BackColor = System.Drawing.Color.White;
            this.btnFiltroCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroCerrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnFiltroCerrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnFiltroCerrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCerrado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltroCerrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnFiltroCerrado.Location = new System.Drawing.Point(266, 0);
            this.btnFiltroCerrado.Name = "btnFiltroCerrado";
            this.btnFiltroCerrado.Size = new System.Drawing.Size(80, 28);
            this.btnFiltroCerrado.TabIndex = 3;
            this.btnFiltroCerrado.Text = "Cerrados";
            this.btnFiltroCerrado.UseVisualStyleBackColor = false;
            // 
            // lvTickets
            // 
            this.lvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTickets.BackColor = System.Drawing.Color.White;
            this.lvTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitulo,
            this.colEstado,
            this.colPrioUser,
            this.colPrioReal,
            this.colFecha,
            this.colAccion});
            this.lvTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTickets.HideSelection = false;
            this.lvTickets.Location = new System.Drawing.Point(0, 112);
            this.lvTickets.MultiSelect = false;
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(1580, 920);
            this.lvTickets.TabIndex = 3;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "#";
            this.colId.Width = 52;
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Título";
            this.colTitulo.Width = 280;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 100;
            // 
            // colPrioUser
            // 
            this.colPrioUser.Text = "Prioridad usuario";
            this.colPrioUser.Width = 130;
            // 
            // colPrioReal
            // 
            this.colPrioReal.Text = "Prioridad real";
            this.colPrioReal.Width = 110;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 130;
            // 
            // colAccion
            // 
            this.colAccion.Text = "Acción";
            this.colAccion.Width = 100;
            // 
            // MisTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "MisTickets";
            this.Size = new System.Drawing.Size(920, 600);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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