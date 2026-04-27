namespace TicketsMDB.SuperAdmin
{
    partial class FormAuditoria
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFiltrosTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioFiltLbl = new System.Windows.Forms.Label();
            this.cmbUsuarioFiltro = new System.Windows.Forms.ComboBox();
            this.lblFechaIniLbl = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinLbl = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblTipoLbl = new System.Windows.Forms.Label();
            this.cmbTipoCambio = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lvAuditoria = new System.Windows.Forms.ListView();
            this.colAudId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudEntidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAudDetalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFiltros.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Controls.Add(this.lblFiltrosTitulo);
            this.pnlFiltros.Controls.Add(this.lblUsuarioFiltLbl);
            this.pnlFiltros.Controls.Add(this.cmbUsuarioFiltro);
            this.pnlFiltros.Controls.Add(this.lblFechaIniLbl);
            this.pnlFiltros.Controls.Add(this.dtpFechaInicio);
            this.pnlFiltros.Controls.Add(this.lblFechaFinLbl);
            this.pnlFiltros.Controls.Add(this.dtpFechaFin);
            this.pnlFiltros.Controls.Add(this.lblTipoLbl);
            this.pnlFiltros.Controls.Add(this.cmbTipoCambio);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.btnLimpiarFiltro);
            this.pnlFiltros.Controls.Add(this.lblTotalReg);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlFiltros.Size = new System.Drawing.Size(1100, 96);
            this.pnlFiltros.TabIndex = 1;
            // 
            // lblFiltrosTitulo
            // 
            this.lblFiltrosTitulo.AutoSize = true;
            this.lblFiltrosTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrosTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFiltrosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFiltrosTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblFiltrosTitulo.Name = "lblFiltrosTitulo";
            this.lblFiltrosTitulo.Size = new System.Drawing.Size(70, 21);
            this.lblFiltrosTitulo.TabIndex = 0;
            this.lblFiltrosTitulo.Text = "FILTROS";
            // 
            // lblUsuarioFiltLbl
            // 
            this.lblUsuarioFiltLbl.AutoSize = true;
            this.lblUsuarioFiltLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioFiltLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioFiltLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblUsuarioFiltLbl.Location = new System.Drawing.Point(16, 30);
            this.lblUsuarioFiltLbl.Name = "lblUsuarioFiltLbl";
            this.lblUsuarioFiltLbl.Size = new System.Drawing.Size(70, 23);
            this.lblUsuarioFiltLbl.TabIndex = 1;
            this.lblUsuarioFiltLbl.Text = "Usuario";
            // 
            // cmbUsuarioFiltro
            // 
            this.cmbUsuarioFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbUsuarioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuarioFiltro.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbUsuarioFiltro.Location = new System.Drawing.Point(16, 50);
            this.cmbUsuarioFiltro.Name = "cmbUsuarioFiltro";
            this.cmbUsuarioFiltro.Size = new System.Drawing.Size(180, 33);
            this.cmbUsuarioFiltro.TabIndex = 2;
            // 
            // lblFechaIniLbl
            // 
            this.lblFechaIniLbl.AutoSize = true;
            this.lblFechaIniLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIniLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFechaIniLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFechaIniLbl.Location = new System.Drawing.Point(210, 30);
            this.lblFechaIniLbl.Name = "lblFechaIniLbl";
            this.lblFechaIniLbl.Size = new System.Drawing.Size(59, 23);
            this.lblFechaIniLbl.TabIndex = 3;
            this.lblFechaIniLbl.Text = "Desde";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(210, 50);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(160, 33);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // lblFechaFinLbl
            // 
            this.lblFechaFinLbl.AutoSize = true;
            this.lblFechaFinLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFechaFinLbl.Location = new System.Drawing.Point(382, 30);
            this.lblFechaFinLbl.Name = "lblFechaFinLbl";
            this.lblFechaFinLbl.Size = new System.Drawing.Size(55, 23);
            this.lblFechaFinLbl.TabIndex = 5;
            this.lblFechaFinLbl.Text = "Hasta";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(382, 50);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(160, 33);
            this.dtpFechaFin.TabIndex = 6;
            // 
            // lblTipoLbl
            // 
            this.lblTipoLbl.AutoSize = true;
            this.lblTipoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTipoLbl.Location = new System.Drawing.Point(556, 30);
            this.lblTipoLbl.Name = "lblTipoLbl";
            this.lblTipoLbl.Size = new System.Drawing.Size(135, 23);
            this.lblTipoLbl.TabIndex = 7;
            this.lblTipoLbl.Text = "Tipo de cambio";
            // 
            // cmbTipoCambio
            // 
            this.cmbTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbTipoCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoCambio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipoCambio.Location = new System.Drawing.Point(556, 50);
            this.cmbTipoCambio.Name = "cmbTipoCambio";
            this.cmbTipoCambio.Size = new System.Drawing.Size(170, 33);
            this.cmbTipoCambio.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(740, 50);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 30);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnLimpiarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(838, 50);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(76, 30);
            this.btnLimpiarFiltro.TabIndex = 10;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReg.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTotalReg.Location = new System.Drawing.Point(1830, 57);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(134, 23);
            this.lblTotalReg.TabIndex = 11;
            this.lblTotalReg.Text = "Total: 0 registros";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lvAuditoria);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 96);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1100, 604);
            this.pnlBody.TabIndex = 0;
            // 
            // lvAuditoria
            // 
            this.lvAuditoria.BackColor = System.Drawing.Color.White;
            this.lvAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAuditoria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAudId,
            this.colAudFecha,
            this.colAudUsuario,
            this.colAudTipo,
            this.colAudEntidad,
            this.colAudDetalle});
            this.lvAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAuditoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvAuditoria.FullRowSelect = true;
            this.lvAuditoria.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAuditoria.HideSelection = false;
            this.lvAuditoria.Location = new System.Drawing.Point(0, 0);
            this.lvAuditoria.MultiSelect = false;
            this.lvAuditoria.Name = "lvAuditoria";
            this.lvAuditoria.Size = new System.Drawing.Size(1100, 604);
            this.lvAuditoria.TabIndex = 0;
            this.lvAuditoria.UseCompatibleStateImageBehavior = false;
            this.lvAuditoria.View = System.Windows.Forms.View.Details;
            // 
            // colAudId
            // 
            this.colAudId.Text = "#";
            this.colAudId.Width = 44;
            // 
            // colAudFecha
            // 
            this.colAudFecha.Text = "Fecha y hora";
            this.colAudFecha.Width = 150;
            // 
            // colAudUsuario
            // 
            this.colAudUsuario.Text = "Usuario";
            this.colAudUsuario.Width = 160;
            // 
            // colAudTipo
            // 
            this.colAudTipo.Text = "Tipo";
            this.colAudTipo.Width = 120;
            // 
            // colAudEntidad
            // 
            this.colAudEntidad.Text = "Entidad";
            this.colAudEntidad.Width = 120;
            // 
            // colAudDetalle
            // 
            this.colAudDetalle.Text = "Detalle";
            this.colAudDetalle.Width = 480;
            // 
            // FormAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFiltros);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "FormAuditoria";
            this.Text = "Auditoría Global — Superadmin";
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFiltrosTitulo;
        private System.Windows.Forms.Label lblUsuarioFiltLbl;
        private System.Windows.Forms.ComboBox cmbUsuarioFiltro;
        private System.Windows.Forms.Label lblFechaIniLbl;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFinLbl;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblTipoLbl;
        private System.Windows.Forms.ComboBox cmbTipoCambio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ListView lvAuditoria;
        private System.Windows.Forms.ColumnHeader colAudId;
        private System.Windows.Forms.ColumnHeader colAudFecha;
        private System.Windows.Forms.ColumnHeader colAudUsuario;
        private System.Windows.Forms.ColumnHeader colAudTipo;
        private System.Windows.Forms.ColumnHeader colAudEntidad;
        private System.Windows.Forms.ColumnHeader colAudDetalle;
    }
}