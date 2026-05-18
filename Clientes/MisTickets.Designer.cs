namespace TicketsMDB.Clientes
{
    partial class MisTickets
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panelActualizar = new System.Windows.Forms.Panel();
            this.lblNvaPrioridad = new System.Windows.Forms.Label();
            this.lblNvaDesc = new System.Windows.Forms.Label();
            this.lblNvoTitulo = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.cmbNuevaPrioridad = new System.Windows.Forms.ComboBox();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.txtNuevoTitulo = new System.Windows.Forms.TextBox();
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
            this.panelActualizar.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.panelActualizar);
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
            // panelActualizar
            // 
            this.panelActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActualizar.Controls.Add(this.lblNvaPrioridad);
            this.panelActualizar.Controls.Add(this.lblNvaDesc);
            this.panelActualizar.Controls.Add(this.lblNvoTitulo);
            this.panelActualizar.Controls.Add(this.btnGuardarCambios);
            this.panelActualizar.Controls.Add(this.cmbNuevaPrioridad);
            this.panelActualizar.Controls.Add(this.txtNuevaDescripcion);
            this.panelActualizar.Controls.Add(this.txtNuevoTitulo);
            this.panelActualizar.Location = new System.Drawing.Point(185, 120);
            this.panelActualizar.Name = "panelActualizar";
            this.panelActualizar.Size = new System.Drawing.Size(550, 380);
            this.panelActualizar.TabIndex = 6;
            // 
            // lblNvaPrioridad
            // 
            this.lblNvaPrioridad.AutoSize = true;
            this.lblNvaPrioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNvaPrioridad.Location = new System.Drawing.Point(40, 255);
            this.lblNvaPrioridad.Name = "lblNvaPrioridad";
            this.lblNvaPrioridad.Size = new System.Drawing.Size(126, 20);
            this.lblNvaPrioridad.TabIndex = 6;
            this.lblNvaPrioridad.Text = "Sugerir Prioridad:";
            // 
            // lblNvaDesc
            // 
            this.lblNvaDesc.AutoSize = true;
            this.lblNvaDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNvaDesc.Location = new System.Drawing.Point(40, 90);
            this.lblNvaDesc.Name = "lblNvaDesc";
            this.lblNvaDesc.Size = new System.Drawing.Size(142, 20);
            this.lblNvaDesc.TabIndex = 5;
            this.lblNvaDesc.Text = "Nueva Descripción:";
            // 
            // lblNvoTitulo
            // 
            this.lblNvoTitulo.AutoSize = true;
            this.lblNvoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNvoTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblNvoTitulo.Name = "lblNvoTitulo";
            this.lblNvoTitulo.Size = new System.Drawing.Size(103, 20);
            this.lblNvoTitulo.TabIndex = 4;
            this.lblNvoTitulo.Text = "Nuevo Título:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(350, 320);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(160, 40);
            this.btnGuardarCambios.TabIndex = 3;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // cmbNuevaPrioridad
            // 
            this.cmbNuevaPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevaPrioridad.FormattingEnabled = true;
            this.cmbNuevaPrioridad.Location = new System.Drawing.Point(40, 280);
            this.cmbNuevaPrioridad.Name = "cmbNuevaPrioridad";
            this.cmbNuevaPrioridad.Size = new System.Drawing.Size(200, 29);
            this.cmbNuevaPrioridad.TabIndex = 2;
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(40, 115);
            this.txtNuevaDescripcion.Multiline = true;
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(470, 120);
            this.txtNuevaDescripcion.TabIndex = 1;
            // 
            // txtNuevoTitulo
            // 
            this.txtNuevoTitulo.Location = new System.Drawing.Point(40, 45);
            this.txtNuevoTitulo.Name = "txtNuevoTitulo";
            this.txtNuevoTitulo.Size = new System.Drawing.Size(470, 29);
            this.txtNuevoTitulo.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(137, 35);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Mis tickets";
            // 
            // lblPageSub
            // 
            this.lblPageSub.AutoSize = true;
            this.lblPageSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSub.Location = new System.Drawing.Point(25, 49);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(322, 20);
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
            this.pnlFiltros.Location = new System.Drawing.Point(28, 85);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(864, 34);
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
            this.btnFiltroTodos.Click += new System.EventHandler(this.btnFiltroTodos_Click);
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
            this.btnFiltroAbierto.Click += new System.EventHandler(this.btnFiltroAbierto_Click);
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
            this.btnFiltroProceso.Click += new System.EventHandler(this.btnFiltroProceso_Click);
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
            this.btnFiltroCerrado.Click += new System.EventHandler(this.btnFiltroCerrado_Click);
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
            this.lvTickets.Location = new System.Drawing.Point(28, 135);
            this.lvTickets.MultiSelect = false;
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(864, 435);
            this.lvTickets.TabIndex = 3;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            this.lvTickets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvTickets_MouseClick);
            // 
            // colId
            // 
            this.colId.Text = "#";
            this.colId.Width = 50;
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Título";
            this.colTitulo.Width = 200;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 110;
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
            this.colFecha.Width = 100;
            // 
            // colAccion
            // 
            this.colAccion.Text = "Acciones";
            this.colAccion.Width = 140;
            // 
            // MisTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
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
            this.panelActualizar.ResumeLayout(false);
            this.panelActualizar.PerformLayout();
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
        private System.Windows.Forms.Panel panelActualizar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ComboBox cmbNuevaPrioridad;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.TextBox txtNuevoTitulo;
        private System.Windows.Forms.Label lblNvoTitulo;
        private System.Windows.Forms.Label lblNvaDesc;
        private System.Windows.Forms.Label lblNvaPrioridad;
    }
}