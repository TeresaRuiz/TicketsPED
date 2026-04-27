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
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.pnlRolesBody = new System.Windows.Forms.Panel();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.colRolId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRolDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFormRol = new System.Windows.Forms.Panel();
            this.btnRolEliminar = new System.Windows.Forms.Button();
            this.btnRolGuardar = new System.Windows.Forms.Button();
            this.btnRolNuevo = new System.Windows.Forms.Button();
            this.txtRolDesc = new System.Windows.Forms.TextBox();
            this.lblRolDescLbl = new System.Windows.Forms.Label();
            this.txtRolNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombreLbl = new System.Windows.Forms.Label();
            this.tabPrioridades = new System.Windows.Forms.TabPage();
            this.pnlPrioridadesBody = new System.Windows.Forms.Panel();
            this.lvPrioridades = new System.Windows.Forms.ListView();
            this.colPrioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFormPrioridad = new System.Windows.Forms.Panel();
            this.btnPrioEliminar = new System.Windows.Forms.Button();
            this.btnPrioGuardar = new System.Windows.Forms.Button();
            this.btnPrioNuevo = new System.Windows.Forms.Button();
            this.txtPrioNombre = new System.Windows.Forms.TextBox();
            this.lblPrioNombreLbl = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.pnlEstadosBody = new System.Windows.Forms.Panel();
            this.lvEstados = new System.Windows.Forms.ListView();
            this.colEstadoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstadoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFormEstado = new System.Windows.Forms.Panel();
            this.btnEstadoEliminar = new System.Windows.Forms.Button();
            this.btnEstadoGuardar = new System.Windows.Forms.Button();
            this.btnEstadoNuevo = new System.Windows.Forms.Button();
            this.txtEstadoNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoNombreLbl = new System.Windows.Forms.Label();
            this.tabEstados = new System.Windows.Forms.TabPage();
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
            this.tabRoles.SuspendLayout();
            this.pnlRolesBody.SuspendLayout();
            this.pnlFormRol.SuspendLayout();
            this.tabPrioridades.SuspendLayout();
            this.pnlPrioridadesBody.SuspendLayout();
            this.pnlFormPrioridad.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabEstados.SuspendLayout();
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
            // tabRoles
            // 
            this.tabRoles.BackColor = System.Drawing.Color.White;
            this.tabRoles.Controls.Add(this.pnlRolesBody);
            this.tabRoles.Location = new System.Drawing.Point(4, 34);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Size = new System.Drawing.Size(860, 574);
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
            this.pnlRolesBody.Size = new System.Drawing.Size(860, 574);
            this.pnlRolesBody.TabIndex = 0;
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
            this.lvRoles.Size = new System.Drawing.Size(550, 1014);
            this.lvRoles.TabIndex = 1;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
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
            // pnlFormRol
            // 
            this.pnlFormRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormRol.Controls.Add(this.lblRolNombreLbl);
            this.pnlFormRol.Controls.Add(this.txtRolNombre);
            this.pnlFormRol.Controls.Add(this.lblRolDescLbl);
            this.pnlFormRol.Controls.Add(this.txtRolDesc);
            this.pnlFormRol.Controls.Add(this.btnRolNuevo);
            this.pnlFormRol.Controls.Add(this.btnRolGuardar);
            this.pnlFormRol.Controls.Add(this.btnRolEliminar);
            this.pnlFormRol.Location = new System.Drawing.Point(570, 0);
            this.pnlFormRol.Name = "pnlFormRol";
            this.pnlFormRol.Size = new System.Drawing.Size(280, 540);
            this.pnlFormRol.TabIndex = 0;
            // 
            // btnRolEliminar
            // 
            this.btnRolEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRolEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnRolEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRolEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRolEliminar.Location = new System.Drawing.Point(186, 178);
            this.btnRolEliminar.Name = "btnRolEliminar";
            this.btnRolEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnRolEliminar.TabIndex = 6;
            this.btnRolEliminar.Text = "Eliminar";
            this.btnRolEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRolGuardar
            // 
            this.btnRolGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnRolGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolGuardar.FlatAppearance.BorderSize = 0;
            this.btnRolGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRolGuardar.ForeColor = System.Drawing.Color.White;
            this.btnRolGuardar.Location = new System.Drawing.Point(98, 178);
            this.btnRolGuardar.Name = "btnRolGuardar";
            this.btnRolGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnRolGuardar.TabIndex = 5;
            this.btnRolGuardar.Text = "Guardar";
            this.btnRolGuardar.UseVisualStyleBackColor = false;
            // 
            // btnRolNuevo
            // 
            this.btnRolNuevo.BackColor = System.Drawing.Color.White;
            this.btnRolNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnRolNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRolNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnRolNuevo.Location = new System.Drawing.Point(14, 178);
            this.btnRolNuevo.Name = "btnRolNuevo";
            this.btnRolNuevo.Size = new System.Drawing.Size(76, 30);
            this.btnRolNuevo.TabIndex = 4;
            this.btnRolNuevo.Text = "Nuevo";
            this.btnRolNuevo.UseVisualStyleBackColor = false;
            // 
            // txtRolDesc
            // 
            this.txtRolDesc.BackColor = System.Drawing.Color.White;
            this.txtRolDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRolDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRolDesc.Location = new System.Drawing.Point(14, 100);
            this.txtRolDesc.Multiline = true;
            this.txtRolDesc.Name = "txtRolDesc";
            this.txtRolDesc.Size = new System.Drawing.Size(250, 60);
            this.txtRolDesc.TabIndex = 3;
            // 
            // lblRolDescLbl
            // 
            this.lblRolDescLbl.AutoSize = true;
            this.lblRolDescLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblRolDescLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRolDescLbl.Location = new System.Drawing.Point(14, 80);
            this.lblRolDescLbl.Name = "lblRolDescLbl";
            this.lblRolDescLbl.Size = new System.Drawing.Size(103, 23);
            this.lblRolDescLbl.TabIndex = 2;
            this.lblRolDescLbl.Text = "Descripción";
            // 
            // txtRolNombre
            // 
            this.txtRolNombre.BackColor = System.Drawing.Color.White;
            this.txtRolNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRolNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRolNombre.Location = new System.Drawing.Point(14, 40);
            this.txtRolNombre.Name = "txtRolNombre";
            this.txtRolNombre.Size = new System.Drawing.Size(250, 33);
            this.txtRolNombre.TabIndex = 1;
            // 
            // lblRolNombreLbl
            // 
            this.lblRolNombreLbl.AutoSize = true;
            this.lblRolNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblRolNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRolNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRolNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblRolNombreLbl.Name = "lblRolNombreLbl";
            this.lblRolNombreLbl.Size = new System.Drawing.Size(133, 23);
            this.lblRolNombreLbl.TabIndex = 0;
            this.lblRolNombreLbl.Text = "Nombre del rol";
            // 
            // tabPrioridades
            // 
            this.tabPrioridades.BackColor = System.Drawing.Color.White;
            this.tabPrioridades.Controls.Add(this.pnlPrioridadesBody);
            this.tabPrioridades.Location = new System.Drawing.Point(4, 34);
            this.tabPrioridades.Name = "tabPrioridades";
            this.tabPrioridades.Size = new System.Drawing.Size(860, 574);
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
            this.pnlPrioridadesBody.Size = new System.Drawing.Size(860, 574);
            this.pnlPrioridadesBody.TabIndex = 0;
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
            this.lvPrioridades.Size = new System.Drawing.Size(550, 1014);
            this.lvPrioridades.TabIndex = 1;
            this.lvPrioridades.UseCompatibleStateImageBehavior = false;
            this.lvPrioridades.View = System.Windows.Forms.View.Details;
            // 
            // colPrioId
            // 
            this.colPrioId.Text = "#";
            this.colPrioId.Width = 50;
            // 
            // colPrioNombre
            // 
            this.colPrioNombre.Text = "Nombre de prioridad";
            this.colPrioNombre.Width = 480;
            // 
            // pnlFormPrioridad
            // 
            this.pnlFormPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlFormPrioridad.Controls.Add(this.lblPrioNombreLbl);
            this.pnlFormPrioridad.Controls.Add(this.txtPrioNombre);
            this.pnlFormPrioridad.Controls.Add(this.btnPrioNuevo);
            this.pnlFormPrioridad.Controls.Add(this.btnPrioGuardar);
            this.pnlFormPrioridad.Controls.Add(this.btnPrioEliminar);
            this.pnlFormPrioridad.Location = new System.Drawing.Point(570, 0);
            this.pnlFormPrioridad.Name = "pnlFormPrioridad";
            this.pnlFormPrioridad.Size = new System.Drawing.Size(280, 540);
            this.pnlFormPrioridad.TabIndex = 0;
            // 
            // btnPrioEliminar
            // 
            this.btnPrioEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrioEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrioEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnPrioEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrioEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrioEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrioEliminar.Location = new System.Drawing.Point(186, 88);
            this.btnPrioEliminar.Name = "btnPrioEliminar";
            this.btnPrioEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnPrioEliminar.TabIndex = 4;
            this.btnPrioEliminar.Text = "Eliminar";
            this.btnPrioEliminar.UseVisualStyleBackColor = false;
            // 
            // btnPrioGuardar
            // 
            this.btnPrioGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnPrioGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrioGuardar.FlatAppearance.BorderSize = 0;
            this.btnPrioGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrioGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrioGuardar.ForeColor = System.Drawing.Color.White;
            this.btnPrioGuardar.Location = new System.Drawing.Point(98, 88);
            this.btnPrioGuardar.Name = "btnPrioGuardar";
            this.btnPrioGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnPrioGuardar.TabIndex = 3;
            this.btnPrioGuardar.Text = "Guardar";
            this.btnPrioGuardar.UseVisualStyleBackColor = false;
            // 
            // btnPrioNuevo
            // 
            this.btnPrioNuevo.BackColor = System.Drawing.Color.White;
            this.btnPrioNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrioNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnPrioNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrioNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrioNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnPrioNuevo.Location = new System.Drawing.Point(14, 88);
            this.btnPrioNuevo.Name = "btnPrioNuevo";
            this.btnPrioNuevo.Size = new System.Drawing.Size(76, 30);
            this.btnPrioNuevo.TabIndex = 2;
            this.btnPrioNuevo.Text = "Nuevo";
            this.btnPrioNuevo.UseVisualStyleBackColor = false;
            // 
            // txtPrioNombre
            // 
            this.txtPrioNombre.BackColor = System.Drawing.Color.White;
            this.txtPrioNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrioNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPrioNombre.Location = new System.Drawing.Point(14, 40);
            this.txtPrioNombre.Name = "txtPrioNombre";
            this.txtPrioNombre.Size = new System.Drawing.Size(250, 33);
            this.txtPrioNombre.TabIndex = 1;
            // 
            // lblPrioNombreLbl
            // 
            this.lblPrioNombreLbl.AutoSize = true;
            this.lblPrioNombreLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblPrioNombreLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPrioNombreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPrioNombreLbl.Location = new System.Drawing.Point(14, 20);
            this.lblPrioNombreLbl.Name = "lblPrioNombreLbl";
            this.lblPrioNombreLbl.Size = new System.Drawing.Size(201, 23);
            this.lblPrioNombreLbl.TabIndex = 0;
            this.lblPrioNombreLbl.Text = "Nombre de la prioridad";
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
            // pnlEstadosBody
            // 
            this.pnlEstadosBody.BackColor = System.Drawing.Color.White;
            this.pnlEstadosBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstadosBody.Location = new System.Drawing.Point(0, 0);
            this.pnlEstadosBody.Name = "pnlEstadosBody";
            this.pnlEstadosBody.Size = new System.Drawing.Size(860, 574);
            this.pnlEstadosBody.TabIndex = 0;
            // 
            // lvEstados
            // 
            this.lvEstados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEstados.BackColor = System.Drawing.Color.White;
            this.lvEstados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEstados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvEstados.FullRowSelect = true;
            this.lvEstados.HideSelection = false;
            this.lvEstados.Location = new System.Drawing.Point(0, 0);
            this.lvEstados.MultiSelect = false;
            this.lvEstados.Name = "lvEstados";
            this.lvEstados.Size = new System.Drawing.Size(550, 1014);
            this.lvEstados.TabIndex = 1;
            this.lvEstados.UseCompatibleStateImageBehavior = false;
            this.lvEstados.View = System.Windows.Forms.View.Details;
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
            this.txtEstadoNombre.Size = new System.Drawing.Size(250, 33);
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
            // tabEstados
            // 
            this.tabEstados.BackColor = System.Drawing.Color.White;
            this.tabEstados.Controls.Add(this.pnlEstadosBody);
            this.tabEstados.Location = new System.Drawing.Point(4, 34);
            this.tabEstados.Name = "tabEstados";
            this.tabEstados.Size = new System.Drawing.Size(860, 574);
            this.tabEstados.TabIndex = 0;
            this.tabEstados.Text = "  Estados  ";
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
            this.txtCatNombre.Size = new System.Drawing.Size(250, 33);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "FormConfiguracionSistema";
            this.Size = new System.Drawing.Size(900, 640);
            this.pnlBody.ResumeLayout(false);
            this.tabRoles.ResumeLayout(false);
            this.pnlRolesBody.ResumeLayout(false);
            this.pnlFormRol.ResumeLayout(false);
            this.pnlFormRol.PerformLayout();
            this.tabPrioridades.ResumeLayout(false);
            this.pnlPrioridadesBody.ResumeLayout(false);
            this.pnlFormPrioridad.ResumeLayout(false);
            this.pnlFormPrioridad.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabEstados.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtPrioNombre;
        private System.Windows.Forms.Button btnPrioNuevo;
        private System.Windows.Forms.Button btnPrioGuardar;
        private System.Windows.Forms.Button btnPrioEliminar;
        private System.Windows.Forms.ListView lvPrioridades;
        private System.Windows.Forms.ColumnHeader colPrioId;
        private System.Windows.Forms.ColumnHeader colPrioNombre;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.Panel pnlRolesBody;
        private System.Windows.Forms.Panel pnlFormRol;
        private System.Windows.Forms.Label lblRolNombreLbl;
        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.Label lblRolDescLbl;
        private System.Windows.Forms.TextBox txtRolDesc;
        private System.Windows.Forms.Button btnRolNuevo;
        private System.Windows.Forms.Button btnRolGuardar;
        private System.Windows.Forms.Button btnRolEliminar;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader colRolId;
        private System.Windows.Forms.ColumnHeader colRolNombre;
        private System.Windows.Forms.ColumnHeader colRolDesc;
        private System.Windows.Forms.ListView lvEstados;
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
    }
}