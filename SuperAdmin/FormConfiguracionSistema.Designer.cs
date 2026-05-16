namespace TicketsMDB.SuperAdmin
{
    partial class FormConfiguracionSistema
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
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabEstados = new System.Windows.Forms.TabPage();
            this.pnlEstadosBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoEstado = new System.Windows.Forms.Button();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.lvEstados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPrioridades = new System.Windows.Forms.TabPage();
            this.pnlPrioridadesBody = new System.Windows.Forms.Panel();
            this.pnlFormPrioridad = new System.Windows.Forms.Panel();
            this.txtNombrePrioridad = new System.Windows.Forms.TextBox();
            this.lblPrioNombreLbl = new System.Windows.Forms.Label();
            this.btnNuevoPrioridad = new System.Windows.Forms.Button();
            this.btnGuardarPrioridad = new System.Windows.Forms.Button();
            this.btnEliminarPrioridad = new System.Windows.Forms.Button();
            this.lvPrioridades = new System.Windows.Forms.ListView();
            this.colPrioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.pnlRolesBody = new System.Windows.Forms.Panel();
            this.pnlFormRol = new System.Windows.Forms.Panel();
            this.lblRolNombreLbl = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblRolDescLbl = new System.Windows.Forms.Label();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.btnNuevoRol = new System.Windows.Forms.Button();
            this.btnGuardarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.colRolId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEsta = new System.Windows.Forms.ListView();
            this.colEstadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFormEstado = new System.Windows.Forms.Panel();
            this.btnEstadoEliminar = new System.Windows.Forms.Button();
            this.btnEstadoGuardar = new System.Windows.Forms.Button();
            this.btnEstadoNuevo = new System.Windows.Forms.Button();
            this.txtEstadoNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoNombreLbl = new System.Windows.Forms.Label();
            this.lvCategorias = new System.Windows.Forms.ListView();
            this.colCatId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFormCategoria = new System.Windows.Forms.Panel();
            this.btnCatEliminar = new System.Windows.Forms.Button();
            this.btnCatGuardar = new System.Windows.Forms.Button();
            this.btnCatNuevo = new System.Windows.Forms.Button();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.lblCatDescLbl = new System.Windows.Forms.Label();
            this.txtCatNombre = new System.Windows.Forms.TextBox();
            this.lblCatNombreLbl = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabEstados.SuspendLayout();
            this.pnlEstadosBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPrioridades.SuspendLayout();
            this.pnlPrioridadesBody.SuspendLayout();
            this.pnlFormPrioridad.SuspendLayout();
            this.tabRoles.SuspendLayout();
            this.pnlRolesBody.SuspendLayout();
            this.pnlFormRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlBody.Controls.Add(this.tabConfig);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlBody.Size = new System.Drawing.Size(900, 640);
            this.pnlBody.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabEstados);
            this.tabConfig.Controls.Add(this.tabPrioridades);
            this.tabConfig.Controls.Add(this.tabRoles);
            this.tabConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConfig.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabConfig.Location = new System.Drawing.Point(16, 14);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(868, 612);
            this.tabConfig.TabIndex = 0;
            // 
            // tabEstados
            // 
            this.tabEstados.BackColor = System.Drawing.Color.White;
            this.tabEstados.Controls.Add(this.pnlEstadosBody);
            this.tabEstados.Location = new System.Drawing.Point(4, 30);
            this.tabEstados.Name = "tabEstados";
            this.tabEstados.Size = new System.Drawing.Size(860, 578);
            this.tabEstados.TabIndex = 0;
            this.tabEstados.Text = "  Estados  ";
            // 
            // pnlEstadosBody
            // 
            this.pnlEstadosBody.BackColor = System.Drawing.Color.White;
            this.pnlEstadosBody.Controls.Add(this.panel1);
            this.pnlEstadosBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadosBody.Location = new System.Drawing.Point(0, 0);
            this.pnlEstadosBody.Name = "pnlEstadosBody";
            this.pnlEstadosBody.Size = new System.Drawing.Size(860, 578);
            this.pnlEstadosBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lvEstados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 578);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.txtNombreEstado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnNuevoEstado);
            this.panel2.Controls.Add(this.btnGuardarEstado);
            this.panel2.Controls.Add(this.btnEliminarEstado);
            this.panel2.Location = new System.Drawing.Point(570, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 540);
            this.panel2.TabIndex = 0;
            // 
            // txtNombreEstado
            // 
            this.txtNombreEstado.Location = new System.Drawing.Point(21, 54);
            this.txtNombreEstado.Name = "txtNombreEstado";
            this.txtNombreEstado.Size = new System.Drawing.Size(243, 29);
            this.txtNombreEstado.TabIndex = 5;
            this.txtNombreEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEstado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar Estado";
            // 
            // btnNuevoEstado
            // 
            this.btnNuevoEstado.BackColor = System.Drawing.Color.White;
            this.btnNuevoEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnNuevoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnNuevoEstado.Location = new System.Drawing.Point(14, 88);
            this.btnNuevoEstado.Name = "btnNuevoEstado";
            this.btnNuevoEstado.Size = new System.Drawing.Size(76, 30);
            this.btnNuevoEstado.TabIndex = 2;
            this.btnNuevoEstado.Text = "Nuevo";
            this.btnNuevoEstado.UseVisualStyleBackColor = false;
            this.btnNuevoEstado.Click += new System.EventHandler(this.btnNuevoEstado_Click);
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnGuardarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEstado.FlatAppearance.BorderSize = 0;
            this.btnGuardarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarEstado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstado.Location = new System.Drawing.Point(98, 88);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarEstado.TabIndex = 3;
            this.btnGuardarEstado.Text = "Guardar";
            this.btnGuardarEstado.UseVisualStyleBackColor = false;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEliminarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminarEstado.Location = new System.Drawing.Point(186, 88);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarEstado.TabIndex = 4;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = false;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // lvEstados
            // 
            this.lvEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEstados.BackColor = System.Drawing.Color.White;
            this.lvEstados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEstados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEstados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvEstados.FullRowSelect = true;
            this.lvEstados.HideSelection = false;
            this.lvEstados.Location = new System.Drawing.Point(0, 0);
            this.lvEstados.MultiSelect = false;
            this.lvEstados.Name = "lvEstados";
            this.lvEstados.Size = new System.Drawing.Size(550, 1018);
            this.lvEstados.TabIndex = 1;
            this.lvEstados.UseCompatibleStateImageBehavior = false;
            this.lvEstados.View = System.Windows.Forms.View.Details;
            this.lvEstados.SelectedIndexChanged += new System.EventHandler(this.lvEstados_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre de estado";
            this.columnHeader2.Width = 200;
            // 
            // tabPrioridades
            // 
            this.tabPrioridades.BackColor = System.Drawing.Color.White;
            this.tabPrioridades.Controls.Add(this.pnlPrioridadesBody);
            this.tabPrioridades.Location = new System.Drawing.Point(4, 30);
            this.tabPrioridades.Name = "tabPrioridades";
            this.tabPrioridades.Size = new System.Drawing.Size(860, 578);
            this.tabPrioridades.TabIndex = 1;
            this.tabPrioridades.Text = "  Prioridades  ";
            // 
            // pnlPrioridadesBody
            // 
            this.pnlPrioridadesBody.BackColor = System.Drawing.Color.White;
            this.pnlPrioridadesBody.Controls.Add(this.pnlFormPrioridad);
            this.pnlPrioridadesBody.Controls.Add(this.lvPrioridades);
            this.pnlPrioridadesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrioridadesBody.Location = new System.Drawing.Point(0, 0);
            this.pnlPrioridadesBody.Name = "pnlPrioridadesBody";
            this.pnlPrioridadesBody.Size = new System.Drawing.Size(860, 578);
            this.pnlPrioridadesBody.TabIndex = 0;
            // 
            // pnlFormPrioridad
            // 
            this.pnlFormPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormPrioridad.Controls.Add(this.txtNombrePrioridad);
            this.pnlFormPrioridad.Controls.Add(this.lblPrioNombreLbl);
            this.pnlFormPrioridad.Controls.Add(this.btnNuevoPrioridad);
            this.pnlFormPrioridad.Controls.Add(this.btnGuardarPrioridad);
            this.pnlFormPrioridad.Controls.Add(this.btnEliminarPrioridad);
            this.pnlFormPrioridad.Location = new System.Drawing.Point(570, 0);
            this.pnlFormPrioridad.Name = "pnlFormPrioridad";
            this.pnlFormPrioridad.Size = new System.Drawing.Size(280, 540);
            this.pnlFormPrioridad.TabIndex = 0;
            // 
            // txtNombrePrioridad
            // 
            this.txtNombrePrioridad.Location = new System.Drawing.Point(24, 56);
            this.txtNombrePrioridad.Name = "txtNombrePrioridad";
            this.txtNombrePrioridad.Size = new System.Drawing.Size(227, 29);
            this.txtNombrePrioridad.TabIndex = 5;
            this.txtNombrePrioridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePrioridad_KeyPress);
            // 
            // lblPrioNombreLbl
            // 
            this.lblPrioNombreLbl.AutoSize = true;
            this.lblPrioNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPrioNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblPrioNombreLbl.Name = "lblPrioNombreLbl";
            this.lblPrioNombreLbl.Size = new System.Drawing.Size(172, 20);
            this.lblPrioNombreLbl.TabIndex = 0;
            this.lblPrioNombreLbl.Text = "Nombre de la prioridad";
            // 
            // btnNuevoPrioridad
            // 
            this.btnNuevoPrioridad.BackColor = System.Drawing.Color.White;
            this.btnNuevoPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPrioridad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnNuevoPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPrioridad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnNuevoPrioridad.Location = new System.Drawing.Point(22, 110);
            this.btnNuevoPrioridad.Name = "btnNuevoPrioridad";
            this.btnNuevoPrioridad.Size = new System.Drawing.Size(76, 30);
            this.btnNuevoPrioridad.TabIndex = 2;
            this.btnNuevoPrioridad.Text = "Nuevo";
            this.btnNuevoPrioridad.UseVisualStyleBackColor = false;
            this.btnNuevoPrioridad.Click += new System.EventHandler(this.btnNuevoPrioridad_Click);
            // 
            // btnGuardarPrioridad
            // 
            this.btnGuardarPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnGuardarPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPrioridad.FlatAppearance.BorderSize = 0;
            this.btnGuardarPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPrioridad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPrioridad.Location = new System.Drawing.Point(106, 110);
            this.btnGuardarPrioridad.Name = "btnGuardarPrioridad";
            this.btnGuardarPrioridad.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarPrioridad.TabIndex = 3;
            this.btnGuardarPrioridad.Text = "Guardar";
            this.btnGuardarPrioridad.UseVisualStyleBackColor = false;
            this.btnGuardarPrioridad.Click += new System.EventHandler(this.btnGuardarPrioridad_Click);
            // 
            // btnEliminarPrioridad
            // 
            this.btnEliminarPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPrioridad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEliminarPrioridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminarPrioridad.Location = new System.Drawing.Point(194, 110);
            this.btnEliminarPrioridad.Name = "btnEliminarPrioridad";
            this.btnEliminarPrioridad.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarPrioridad.TabIndex = 4;
            this.btnEliminarPrioridad.Text = "Eliminar";
            this.btnEliminarPrioridad.UseVisualStyleBackColor = false;
            this.btnEliminarPrioridad.Click += new System.EventHandler(this.btnEliminarPrioridad_Click);
            // 
            // lvPrioridades
            // 
            this.lvPrioridades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvPrioridades.BackColor = System.Drawing.Color.White;
            this.lvPrioridades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPrioridades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPrioId,
            this.colPrioNombre});
            this.lvPrioridades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvPrioridades.FullRowSelect = true;
            this.lvPrioridades.HideSelection = false;
            this.lvPrioridades.Location = new System.Drawing.Point(0, 0);
            this.lvPrioridades.MultiSelect = false;
            this.lvPrioridades.Name = "lvPrioridades";
            this.lvPrioridades.Size = new System.Drawing.Size(550, 1018);
            this.lvPrioridades.TabIndex = 1;
            this.lvPrioridades.UseCompatibleStateImageBehavior = false;
            this.lvPrioridades.View = System.Windows.Forms.View.Details;
            this.lvPrioridades.SelectedIndexChanged += new System.EventHandler(this.lvPrioridades_SelectedIndexChanged);
            // 
            // colPrioId
            // 
            this.colPrioId.Text = "#ID";
            this.colPrioId.Width = 163;
            // 
            // colPrioNombre
            // 
            this.colPrioNombre.Text = "Nombre de prioridad";
            this.colPrioNombre.Width = 200;
            // 
            // tabRoles
            // 
            this.tabRoles.BackColor = System.Drawing.Color.White;
            this.tabRoles.Controls.Add(this.pnlRolesBody);
            this.tabRoles.Location = new System.Drawing.Point(4, 30);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(860, 578);
            this.tabRoles.TabIndex = 3;
            this.tabRoles.Text = "  Roles  ";
            // 
            // pnlRolesBody
            // 
            this.pnlRolesBody.BackColor = System.Drawing.Color.White;
            this.pnlRolesBody.Controls.Add(this.pnlFormRol);
            this.pnlRolesBody.Controls.Add(this.lvRoles);
            this.pnlRolesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRolesBody.Location = new System.Drawing.Point(0, 0);
            this.pnlRolesBody.Name = "pnlRolesBody";
            this.pnlRolesBody.Size = new System.Drawing.Size(860, 578);
            this.pnlRolesBody.TabIndex = 0;
            // 
            // pnlFormRol
            // 
            this.pnlFormRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormRol.Controls.Add(this.lblRolNombreLbl);
            this.pnlFormRol.Controls.Add(this.txtNombreRol);
            this.pnlFormRol.Controls.Add(this.lblRolDescLbl);
            this.pnlFormRol.Controls.Add(this.txtDescripcionRol);
            this.pnlFormRol.Controls.Add(this.btnNuevoRol);
            this.pnlFormRol.Controls.Add(this.btnGuardarRol);
            this.pnlFormRol.Controls.Add(this.btnEliminarRol);
            this.pnlFormRol.Location = new System.Drawing.Point(570, 0);
            this.pnlFormRol.Name = "pnlFormRol";
            this.pnlFormRol.Size = new System.Drawing.Size(280, 540);
            this.pnlFormRol.TabIndex = 0;
            // 
            // lblRolNombreLbl
            // 
            this.lblRolNombreLbl.AutoSize = true;
            this.lblRolNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblRolNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRolNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblRolNombreLbl.Name = "lblRolNombreLbl";
            this.lblRolNombreLbl.Size = new System.Drawing.Size(115, 20);
            this.lblRolNombreLbl.TabIndex = 0;
            this.lblRolNombreLbl.Text = "Nombre del rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.BackColor = System.Drawing.Color.White;
            this.txtNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombreRol.Location = new System.Drawing.Point(14, 40);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(250, 29);
            this.txtNombreRol.TabIndex = 1;
            this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
            // 
            // lblRolDescLbl
            // 
            this.lblRolDescLbl.AutoSize = true;
            this.lblRolDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblRolDescLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRolDescLbl.Location = new System.Drawing.Point(14, 80);
            this.lblRolDescLbl.Name = "lblRolDescLbl";
            this.lblRolDescLbl.Size = new System.Drawing.Size(90, 20);
            this.lblRolDescLbl.TabIndex = 2;
            this.lblRolDescLbl.Text = "Descripción";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.BackColor = System.Drawing.Color.White;
            this.txtDescripcionRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescripcionRol.Location = new System.Drawing.Point(14, 100);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(250, 60);
            this.txtDescripcionRol.TabIndex = 3;
            this.txtDescripcionRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionRol_KeyPress);
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.BackColor = System.Drawing.Color.White;
            this.btnNuevoRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnNuevoRol.Location = new System.Drawing.Point(14, 178);
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.Size = new System.Drawing.Size(76, 30);
            this.btnNuevoRol.TabIndex = 4;
            this.btnNuevoRol.Text = "Nuevo";
            this.btnNuevoRol.UseVisualStyleBackColor = false;
            this.btnNuevoRol.Click += new System.EventHandler(this.btnNuevoRol_Click);
            // 
            // btnGuardarRol
            // 
            this.btnGuardarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnGuardarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRol.FlatAppearance.BorderSize = 0;
            this.btnGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardarRol.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRol.Location = new System.Drawing.Point(98, 178);
            this.btnGuardarRol.Name = "btnGuardarRol";
            this.btnGuardarRol.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarRol.TabIndex = 5;
            this.btnGuardarRol.Text = "Guardar";
            this.btnGuardarRol.UseVisualStyleBackColor = false;
            this.btnGuardarRol.Click += new System.EventHandler(this.btnGuardarRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminarRol.Location = new System.Drawing.Point(186, 178);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarRol.TabIndex = 6;
            this.btnEliminarRol.Text = "Eliminar";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // lvRoles
            // 
            this.lvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvRoles.BackColor = System.Drawing.Color.White;
            this.lvRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRolId,
            this.colRolNombre,
            this.colRolDesc});
            this.lvRoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvRoles.FullRowSelect = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(0, 0);
            this.lvRoles.MultiSelect = false;
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(550, 1018);
            this.lvRoles.TabIndex = 1;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            this.lvRoles.SelectedIndexChanged += new System.EventHandler(this.lvRoles_SelectedIndexChanged);
            // 
            // colRolId
            // 
            this.colRolId.Text = "#";
            this.colRolId.Width = 50;
            // 
            // colRolNombre
            // 
            this.colRolNombre.Text = "Nombre del rol";
            this.colRolNombre.Width = 160;
            // 
            // colRolDesc
            // 
            this.colRolDesc.Text = "Descripción";
            this.colRolDesc.Width = 320;
            // 
            // lvEsta
            // 
            this.lvEsta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEsta.BackColor = System.Drawing.Color.Black;
            this.lvEsta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEsta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvEsta.FullRowSelect = true;
            this.lvEsta.HideSelection = false;
            this.lvEsta.Location = new System.Drawing.Point(0, 0);
            this.lvEsta.MultiSelect = false;
            this.lvEsta.Name = "lvEsta";
            this.lvEsta.Size = new System.Drawing.Size(550, 1014);
            this.lvEsta.TabIndex = 1;
            this.lvEsta.UseCompatibleStateImageBehavior = false;
            this.lvEsta.View = System.Windows.Forms.View.Details;
            // 
            // colEstadoId
            // 
            this.colEstadoId.DisplayIndex = 0;
            this.colEstadoId.Text = "#";
            this.colEstadoId.Width = 50;
            // 
            // colEstadoNombre
            // 
            this.colEstadoNombre.DisplayIndex = 1;
            this.colEstadoNombre.Text = "Nombre del estado";
            this.colEstadoNombre.Width = 480;
            // 
            // pnlFormEstado
            // 
            this.pnlFormEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormEstado.Location = new System.Drawing.Point(1230, 0);
            this.pnlFormEstado.Name = "pnlFormEstado";
            this.pnlFormEstado.Size = new System.Drawing.Size(280, 1014);
            this.pnlFormEstado.TabIndex = 0;
            // 
            // btnEstadoEliminar
            // 
            this.btnEstadoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEstadoEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadoEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnEstadoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEstadoEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEstadoEliminar.Location = new System.Drawing.Point(186, 88);
            this.btnEstadoEliminar.Name = "btnEstadoEliminar";
            this.btnEstadoEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnEstadoEliminar.TabIndex = 4;
            this.btnEstadoEliminar.Text = "Eliminar";
            this.btnEstadoEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEstadoGuardar
            // 
            this.btnEstadoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnEstadoGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadoGuardar.FlatAppearance.BorderSize = 0;
            this.btnEstadoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEstadoGuardar.ForeColor = System.Drawing.Color.White;
            this.btnEstadoGuardar.Location = new System.Drawing.Point(98, 88);
            this.btnEstadoGuardar.Name = "btnEstadoGuardar";
            this.btnEstadoGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnEstadoGuardar.TabIndex = 3;
            this.btnEstadoGuardar.Text = "Guardar";
            this.btnEstadoGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEstadoNuevo
            // 
            this.btnEstadoNuevo.BackColor = System.Drawing.Color.White;
            this.btnEstadoNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadoNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnEstadoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstadoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnEstadoNuevo.Location = new System.Drawing.Point(14, 88);
            this.btnEstadoNuevo.Name = "btnEstadoNuevo";
            this.btnEstadoNuevo.Size = new System.Drawing.Size(76, 30);
            this.btnEstadoNuevo.TabIndex = 2;
            this.btnEstadoNuevo.Text = "Nuevo";
            this.btnEstadoNuevo.UseVisualStyleBackColor = false;
            // 
            // txtEstadoNombre
            // 
            this.txtEstadoNombre.BackColor = System.Drawing.Color.White;
            this.txtEstadoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadoNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEstadoNombre.Location = new System.Drawing.Point(14, 40);
            this.txtEstadoNombre.Name = "txtEstadoNombre";
            this.txtEstadoNombre.Size = new System.Drawing.Size(250, 29);
            this.txtEstadoNombre.TabIndex = 1;
            // 
            // lblEstadoNombreLbl
            // 
            this.lblEstadoNombreLbl.AutoSize = true;
            this.lblEstadoNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblEstadoNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblEstadoNombreLbl.Name = "lblEstadoNombreLbl";
            this.lblEstadoNombreLbl.Size = new System.Drawing.Size(164, 23);
            this.lblEstadoNombreLbl.TabIndex = 0;
            // 
            // lvCategorias
            // 
            this.lvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvCategorias.BackColor = System.Drawing.Color.White;
            this.lvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCategorias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvCategorias.FullRowSelect = true;
            this.lvCategorias.HideSelection = false;
            this.lvCategorias.Location = new System.Drawing.Point(0, 0);
            this.lvCategorias.MultiSelect = false;
            this.lvCategorias.Name = "lvCategorias";
            this.lvCategorias.Size = new System.Drawing.Size(550, 1014);
            this.lvCategorias.TabIndex = 1;
            this.lvCategorias.UseCompatibleStateImageBehavior = false;
            this.lvCategorias.View = System.Windows.Forms.View.Details;
            // 
            // colCatId
            // 
            this.colCatId.DisplayIndex = 0;
            this.colCatId.Text = "#";
            this.colCatId.Width = 50;
            // 
            // colCatNombre
            // 
            this.colCatNombre.DisplayIndex = 1;
            this.colCatNombre.Text = "Nombre";
            this.colCatNombre.Width = 200;
            // 
            // colCatDesc
            // 
            this.colCatDesc.DisplayIndex = 2;
            this.colCatDesc.Text = "Descripción";
            this.colCatDesc.Width = 280;
            // 
            // pnlFormCategoria
            // 
            this.pnlFormCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormCategoria.Location = new System.Drawing.Point(570, 0);
            this.pnlFormCategoria.Name = "pnlFormCategoria";
            this.pnlFormCategoria.Size = new System.Drawing.Size(280, 540);
            this.pnlFormCategoria.TabIndex = 0;
            // 
            // btnCatEliminar
            // 
            this.btnCatEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCatEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnCatEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCatEliminar.Location = new System.Drawing.Point(186, 178);
            this.btnCatEliminar.Name = "btnCatEliminar";
            this.btnCatEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnCatEliminar.TabIndex = 6;
            this.btnCatEliminar.Text = "Eliminar";
            this.btnCatEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCatGuardar
            // 
            this.btnCatGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnCatGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatGuardar.FlatAppearance.BorderSize = 0;
            this.btnCatGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCatGuardar.ForeColor = System.Drawing.Color.White;
            this.btnCatGuardar.Location = new System.Drawing.Point(98, 178);
            this.btnCatGuardar.Name = "btnCatGuardar";
            this.btnCatGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnCatGuardar.TabIndex = 5;
            this.btnCatGuardar.Text = "Guardar";
            this.btnCatGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCatNuevo
            // 
            this.btnCatNuevo.BackColor = System.Drawing.Color.White;
            this.btnCatNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCatNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCatNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCatNuevo.Location = new System.Drawing.Point(14, 178);
            this.btnCatNuevo.Name = "btnCatNuevo";
            this.btnCatNuevo.Size = new System.Drawing.Size(76, 30);
            this.btnCatNuevo.TabIndex = 4;
            this.btnCatNuevo.Text = "Nuevo";
            this.btnCatNuevo.UseVisualStyleBackColor = false;
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BackColor = System.Drawing.Color.White;
            this.txtCatDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatDesc.Location = new System.Drawing.Point(14, 100);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(250, 60);
            this.txtCatDesc.TabIndex = 3;
            // 
            // lblCatDescLbl
            // 
            this.lblCatDescLbl.AutoSize = true;
            this.lblCatDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCatDescLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCatDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCatDescLbl.Location = new System.Drawing.Point(14, 80);
            this.lblCatDescLbl.Name = "lblCatDescLbl";
            this.lblCatDescLbl.Size = new System.Drawing.Size(103, 23);
            this.lblCatDescLbl.TabIndex = 2;
            // 
            // txtCatNombre
            // 
            this.txtCatNombre.BackColor = System.Drawing.Color.White;
            this.txtCatNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatNombre.Location = new System.Drawing.Point(14, 40);
            this.txtCatNombre.Name = "txtCatNombre";
            this.txtCatNombre.Size = new System.Drawing.Size(250, 29);
            this.txtCatNombre.TabIndex = 1;
            // 
            // lblCatNombreLbl
            // 
            this.lblCatNombreLbl.AutoSize = true;
            this.lblCatNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCatNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCatNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCatNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblCatNombreLbl.Name = "lblCatNombreLbl";
            this.lblCatNombreLbl.Size = new System.Drawing.Size(76, 23);
            this.lblCatNombreLbl.TabIndex = 0;
            // 
            // FormConfiguracionSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "FormConfiguracionSistema";
            this.Size = new System.Drawing.Size(900, 640);
            this.pnlBody.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabEstados.ResumeLayout(false);
            this.pnlEstadosBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPrioridades.ResumeLayout(false);
            this.pnlPrioridadesBody.ResumeLayout(false);
            this.pnlFormPrioridad.ResumeLayout(false);
            this.pnlFormPrioridad.PerformLayout();
            this.tabRoles.ResumeLayout(false);
            this.pnlRolesBody.ResumeLayout(false);
            this.pnlFormRol.ResumeLayout(false);
            this.pnlFormRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabEstados;
        private System.Windows.Forms.Panel pnlEstadosBody;
        private System.Windows.Forms.TabPage tabPrioridades;
        private System.Windows.Forms.Panel pnlPrioridadesBody;
        private System.Windows.Forms.Panel pnlFormPrioridad;
        private System.Windows.Forms.Label lblPrioNombreLbl;
        private System.Windows.Forms.Button btnNuevoPrioridad;
        private System.Windows.Forms.Button btnGuardarPrioridad;
        private System.Windows.Forms.Button btnEliminarPrioridad;
        private System.Windows.Forms.ListView lvPrioridades;
        private System.Windows.Forms.ColumnHeader colPrioId;
        private System.Windows.Forms.ColumnHeader colPrioNombre;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.Panel pnlRolesBody;
        private System.Windows.Forms.Panel pnlFormRol;
        private System.Windows.Forms.Label lblRolNombreLbl;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lblRolDescLbl;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private System.Windows.Forms.Button btnNuevoRol;
        private System.Windows.Forms.Button btnGuardarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader colRolId;
        private System.Windows.Forms.ColumnHeader colRolNombre;
        private System.Windows.Forms.ColumnHeader colRolDesc;
        private System.Windows.Forms.ListView lvEsta;
        private System.Windows.Forms.ColumnHeader colEstadoId;
        private System.Windows.Forms.ColumnHeader colEstadoNombre;
        private System.Windows.Forms.Panel pnlFormEstado;
        private System.Windows.Forms.Button btnEstadoEliminar;
        private System.Windows.Forms.Button btnEstadoGuardar;
        private System.Windows.Forms.Button btnEstadoNuevo;
        private System.Windows.Forms.TextBox txtEstadoNombre;
        private System.Windows.Forms.Label lblEstadoNombreLbl;
        private System.Windows.Forms.ListView lvCategorias;
        private System.Windows.Forms.ColumnHeader colCatId;
        private System.Windows.Forms.ColumnHeader colCatNombre;
        private System.Windows.Forms.ColumnHeader colCatDesc;
        private System.Windows.Forms.Panel pnlFormCategoria;
        private System.Windows.Forms.Button btnCatEliminar;
        private System.Windows.Forms.Button btnCatGuardar;
        private System.Windows.Forms.Button btnCatNuevo;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Label lblCatDescLbl;
        private System.Windows.Forms.TextBox txtCatNombre;
        private System.Windows.Forms.Label lblCatNombreLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoEstado;
        private System.Windows.Forms.Button btnGuardarEstado;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.ListView lvEstados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtNombrePrioridad;
        private System.Windows.Forms.TextBox txtNombreEstado;
    }
}