namespace TicketsMDB.SuperAdmin
{
    partial class   Inicio
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
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.pnlFilaInferior = new System.Windows.Forms.Panel();
            this.pnlActividad = new System.Windows.Forms.Panel();
            this.lblSecActividad = new System.Windows.Forms.Label();
            this.lvActividad = new System.Windows.Forms.ListView();
            this.colActFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlEstadisticas = new System.Windows.Forms.Panel();
            this.lblSecEstadisticas = new System.Windows.Forms.Label();
            this.lblEstSubEstado = new System.Windows.Forms.Label();
            this.pnlDivEstado = new System.Windows.Forms.Panel();
            this.lblEstAbiertosLbl = new System.Windows.Forms.Label();
            this.lblEstAbiertosVal = new System.Windows.Forms.Label();
            this.pnlDivEA = new System.Windows.Forms.Panel();
            this.lblEstProcesoLbl = new System.Windows.Forms.Label();
            this.lblEstProcesoVal = new System.Windows.Forms.Label();
            this.pnlDivEP = new System.Windows.Forms.Panel();
            this.lblEstCerradosLbl = new System.Windows.Forms.Label();
            this.lblEstCerradosVal = new System.Windows.Forms.Label();
            this.pnlDivEC = new System.Windows.Forms.Panel();
            this.lblEstSubPrioridad = new System.Windows.Forms.Label();
            this.pnlDivPrioridad = new System.Windows.Forms.Panel();
            this.lblEstAltaLbl = new System.Windows.Forms.Label();
            this.lblEstAltaVal = new System.Windows.Forms.Label();
            this.pnlDivPA = new System.Windows.Forms.Panel();
            this.lblEstMediaLbl = new System.Windows.Forms.Label();
            this.lblEstMediaVal = new System.Windows.Forms.Label();
            this.pnlDivPM = new System.Windows.Forms.Panel();
            this.lblEstBajaLbl = new System.Windows.Forms.Label();
            this.lblEstBajaVal = new System.Windows.Forms.Label();
            this.pnlUltUsuarios = new System.Windows.Forms.Panel();
            this.lblSecUltUsuarios = new System.Windows.Forms.Label();
            this.lvUltUsuarios = new System.Windows.Forms.ListView();
            this.colUUNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUURol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUUFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTarjetas = new System.Windows.Forms.Panel();
            this.pnlCardUsuarios = new System.Windows.Forms.Panel();
            this.lblCardUsuariosLbl = new System.Windows.Forms.Label();
            this.lblCardUsuariosNum = new System.Windows.Forms.Label();
            this.pnlBarUsuarios = new System.Windows.Forms.Panel();
            this.pnlCardAdmins = new System.Windows.Forms.Panel();
            this.lblCardAdminsLbl = new System.Windows.Forms.Label();
            this.lblCardAdminsNum = new System.Windows.Forms.Label();
            this.pnlBarAdmins = new System.Windows.Forms.Panel();
            this.pnlCardTickets = new System.Windows.Forms.Panel();
            this.lblCardTicketsLbl = new System.Windows.Forms.Label();
            this.lblCardTicketsNum = new System.Windows.Forms.Label();
            this.pnlBarTickets = new System.Windows.Forms.Panel();
            this.pnlCardAlta = new System.Windows.Forms.Panel();
            this.lblCardAltaLbl = new System.Windows.Forms.Label();
            this.lblCardAltaNum = new System.Windows.Forms.Label();
            this.pnlBarAlta = new System.Windows.Forms.Panel();
            this.pnlCardPendientes = new System.Windows.Forms.Panel();
            this.lblCardPendientesLbl = new System.Windows.Forms.Label();
            this.lblCardPendientesNum = new System.Windows.Forms.Label();
            this.pnlBarPendientes = new System.Windows.Forms.Panel();
            this.lblSecResumen = new System.Windows.Forms.Label();
            this.pnlScroll.SuspendLayout();
            this.pnlFilaInferior.SuspendLayout();
            this.pnlActividad.SuspendLayout();
            this.pnlEstadisticas.SuspendLayout();
            this.pnlUltUsuarios.SuspendLayout();
            this.pnlTarjetas.SuspendLayout();
            this.pnlCardUsuarios.SuspendLayout();
            this.pnlCardAdmins.SuspendLayout();
            this.pnlCardTickets.SuspendLayout();
            this.pnlCardAlta.SuspendLayout();
            this.pnlCardPendientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.BackColor = System.Drawing.Color.White;
            this.pnlScroll.Controls.Add(this.pnlFilaInferior);
            this.pnlScroll.Controls.Add(this.pnlTarjetas);
            this.pnlScroll.Controls.Add(this.lblSecResumen);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 0);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Padding = new System.Windows.Forms.Padding(28, 22, 28, 22);
            this.pnlScroll.Size = new System.Drawing.Size(1200, 780);
            this.pnlScroll.TabIndex = 0;
            // 
            // pnlFilaInferior
            // 
            this.pnlFilaInferior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilaInferior.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilaInferior.Controls.Add(this.pnlActividad);
            this.pnlFilaInferior.Controls.Add(this.pnlEstadisticas);
            this.pnlFilaInferior.Controls.Add(this.pnlUltUsuarios);
            this.pnlFilaInferior.Location = new System.Drawing.Point(0, 148);
            this.pnlFilaInferior.Name = "pnlFilaInferior";
            this.pnlFilaInferior.Size = new System.Drawing.Size(2166, 560);
            this.pnlFilaInferior.TabIndex = 0;
            // 
            // pnlActividad
            // 
            this.pnlActividad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlActividad.BackColor = System.Drawing.Color.White;
            this.pnlActividad.Controls.Add(this.lblSecActividad);
            this.pnlActividad.Controls.Add(this.lvActividad);
            this.pnlActividad.Location = new System.Drawing.Point(0, 0);
            this.pnlActividad.Name = "pnlActividad";
            this.pnlActividad.Size = new System.Drawing.Size(430, 540);
            this.pnlActividad.TabIndex = 0;
            // 
            // lblSecActividad
            // 
            this.lblSecActividad.AutoSize = true;
            this.lblSecActividad.BackColor = System.Drawing.Color.Transparent;
            this.lblSecActividad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSecActividad.Location = new System.Drawing.Point(0, 0);
            this.lblSecActividad.Name = "lblSecActividad";
            this.lblSecActividad.Size = new System.Drawing.Size(174, 21);
            this.lblSecActividad.TabIndex = 0;
            this.lblSecActividad.Text = "ACTIVIDAD RECIENTE";
            // 
            // lvActividad
            // 
            this.lvActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvActividad.BackColor = System.Drawing.Color.White;
            this.lvActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActividad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colActFecha,
            this.colActDescripcion});
            this.lvActividad.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lvActividad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvActividad.FullRowSelect = true;
            this.lvActividad.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvActividad.HideSelection = false;
            this.lvActividad.Location = new System.Drawing.Point(14, 21);
            this.lvActividad.MultiSelect = false;
            this.lvActividad.Name = "lvActividad";
            this.lvActividad.Size = new System.Drawing.Size(402, 516);
            this.lvActividad.TabIndex = 1;
            this.lvActividad.UseCompatibleStateImageBehavior = false;
            this.lvActividad.View = System.Windows.Forms.View.Details;
            // 
            // colActFecha
            // 
            this.colActFecha.Text = "Fecha";
            this.colActFecha.Width = 120;
            // 
            // colActDescripcion
            // 
            this.colActDescripcion.Text = "Actividad";
            this.colActDescripcion.Width = 296;
            // 
            // pnlEstadisticas
            // 
            this.pnlEstadisticas.BackColor = System.Drawing.Color.White;
            this.pnlEstadisticas.Controls.Add(this.lblSecEstadisticas);
            this.pnlEstadisticas.Controls.Add(this.lblEstSubEstado);
            this.pnlEstadisticas.Controls.Add(this.pnlDivEstado);
            this.pnlEstadisticas.Controls.Add(this.lblEstAbiertosLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstAbiertosVal);
            this.pnlEstadisticas.Controls.Add(this.pnlDivEA);
            this.pnlEstadisticas.Controls.Add(this.lblEstProcesoLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstProcesoVal);
            this.pnlEstadisticas.Controls.Add(this.pnlDivEP);
            this.pnlEstadisticas.Controls.Add(this.lblEstCerradosLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstCerradosVal);
            this.pnlEstadisticas.Controls.Add(this.pnlDivEC);
            this.pnlEstadisticas.Controls.Add(this.lblEstSubPrioridad);
            this.pnlEstadisticas.Controls.Add(this.pnlDivPrioridad);
            this.pnlEstadisticas.Controls.Add(this.lblEstAltaLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstAltaVal);
            this.pnlEstadisticas.Controls.Add(this.pnlDivPA);
            this.pnlEstadisticas.Controls.Add(this.lblEstMediaLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstMediaVal);
            this.pnlEstadisticas.Controls.Add(this.pnlDivPM);
            this.pnlEstadisticas.Controls.Add(this.lblEstBajaLbl);
            this.pnlEstadisticas.Controls.Add(this.lblEstBajaVal);
            this.pnlEstadisticas.Location = new System.Drawing.Point(446, 21);
            this.pnlEstadisticas.Name = "pnlEstadisticas";
            this.pnlEstadisticas.Size = new System.Drawing.Size(260, 502);
            this.pnlEstadisticas.TabIndex = 1;
            // 
            // lblSecEstadisticas
            // 
            this.lblSecEstadisticas.AutoSize = true;
            this.lblSecEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.lblSecEstadisticas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSecEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.lblSecEstadisticas.Name = "lblSecEstadisticas";
            this.lblSecEstadisticas.Size = new System.Drawing.Size(117, 21);
            this.lblSecEstadisticas.TabIndex = 0;
            this.lblSecEstadisticas.Text = "ESTADÍSTICAS";
            // 
            // lblEstSubEstado
            // 
            this.lblEstSubEstado.AutoSize = true;
            this.lblEstSubEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstSubEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstSubEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblEstSubEstado.Location = new System.Drawing.Point(0, 24);
            this.lblEstSubEstado.Name = "lblEstSubEstado";
            this.lblEstSubEstado.Size = new System.Drawing.Size(102, 25);
            this.lblEstSubEstado.TabIndex = 1;
            this.lblEstSubEstado.Text = "Por estado";
            // 
            // pnlDivEstado
            // 
            this.pnlDivEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivEstado.Location = new System.Drawing.Point(0, 44);
            this.pnlDivEstado.Name = "pnlDivEstado";
            this.pnlDivEstado.Size = new System.Drawing.Size(260, 1);
            this.pnlDivEstado.TabIndex = 2;
            // 
            // lblEstAbiertosLbl
            // 
            this.lblEstAbiertosLbl.AutoSize = true;
            this.lblEstAbiertosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstAbiertosLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstAbiertosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblEstAbiertosLbl.Location = new System.Drawing.Point(0, 56);
            this.lblEstAbiertosLbl.Name = "lblEstAbiertosLbl";
            this.lblEstAbiertosLbl.Size = new System.Drawing.Size(82, 25);
            this.lblEstAbiertosLbl.TabIndex = 3;
            this.lblEstAbiertosLbl.Text = "Abiertos";
            // 
            // lblEstAbiertosVal
            // 
            this.lblEstAbiertosVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstAbiertosVal.AutoSize = true;
            this.lblEstAbiertosVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstAbiertosVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstAbiertosVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblEstAbiertosVal.Location = new System.Drawing.Point(210, 56);
            this.lblEstAbiertosVal.Name = "lblEstAbiertosVal";
            this.lblEstAbiertosVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstAbiertosVal.TabIndex = 4;
            this.lblEstAbiertosVal.Text = "0";
            // 
            // pnlDivEA
            // 
            this.pnlDivEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivEA.Location = new System.Drawing.Point(0, 76);
            this.pnlDivEA.Name = "pnlDivEA";
            this.pnlDivEA.Size = new System.Drawing.Size(260, 1);
            this.pnlDivEA.TabIndex = 5;
            // 
            // lblEstProcesoLbl
            // 
            this.lblEstProcesoLbl.AutoSize = true;
            this.lblEstProcesoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstProcesoLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstProcesoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblEstProcesoLbl.Location = new System.Drawing.Point(0, 88);
            this.lblEstProcesoLbl.Name = "lblEstProcesoLbl";
            this.lblEstProcesoLbl.Size = new System.Drawing.Size(105, 25);
            this.lblEstProcesoLbl.TabIndex = 6;
            this.lblEstProcesoLbl.Text = "En proceso";
            // 
            // lblEstProcesoVal
            // 
            this.lblEstProcesoVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstProcesoVal.AutoSize = true;
            this.lblEstProcesoVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstProcesoVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstProcesoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblEstProcesoVal.Location = new System.Drawing.Point(210, 88);
            this.lblEstProcesoVal.Name = "lblEstProcesoVal";
            this.lblEstProcesoVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstProcesoVal.TabIndex = 7;
            this.lblEstProcesoVal.Text = "0";
            // 
            // pnlDivEP
            // 
            this.pnlDivEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivEP.Location = new System.Drawing.Point(0, 108);
            this.pnlDivEP.Name = "pnlDivEP";
            this.pnlDivEP.Size = new System.Drawing.Size(260, 1);
            this.pnlDivEP.TabIndex = 8;
            // 
            // lblEstCerradosLbl
            // 
            this.lblEstCerradosLbl.AutoSize = true;
            this.lblEstCerradosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstCerradosLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstCerradosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblEstCerradosLbl.Location = new System.Drawing.Point(0, 120);
            this.lblEstCerradosLbl.Name = "lblEstCerradosLbl";
            this.lblEstCerradosLbl.Size = new System.Drawing.Size(88, 25);
            this.lblEstCerradosLbl.TabIndex = 9;
            this.lblEstCerradosLbl.Text = "Cerrados";
            // 
            // lblEstCerradosVal
            // 
            this.lblEstCerradosVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstCerradosVal.AutoSize = true;
            this.lblEstCerradosVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstCerradosVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstCerradosVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblEstCerradosVal.Location = new System.Drawing.Point(210, 120);
            this.lblEstCerradosVal.Name = "lblEstCerradosVal";
            this.lblEstCerradosVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstCerradosVal.TabIndex = 10;
            this.lblEstCerradosVal.Text = "0";
            // 
            // pnlDivEC
            // 
            this.pnlDivEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivEC.Location = new System.Drawing.Point(0, 140);
            this.pnlDivEC.Name = "pnlDivEC";
            this.pnlDivEC.Size = new System.Drawing.Size(260, 1);
            this.pnlDivEC.TabIndex = 11;
            // 
            // lblEstSubPrioridad
            // 
            this.lblEstSubPrioridad.AutoSize = true;
            this.lblEstSubPrioridad.BackColor = System.Drawing.Color.Transparent;
            this.lblEstSubPrioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstSubPrioridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblEstSubPrioridad.Location = new System.Drawing.Point(0, 158);
            this.lblEstSubPrioridad.Name = "lblEstSubPrioridad";
            this.lblEstSubPrioridad.Size = new System.Drawing.Size(123, 25);
            this.lblEstSubPrioridad.TabIndex = 12;
            this.lblEstSubPrioridad.Text = "Por prioridad";
            // 
            // pnlDivPrioridad
            // 
            this.pnlDivPrioridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivPrioridad.Location = new System.Drawing.Point(0, 178);
            this.pnlDivPrioridad.Name = "pnlDivPrioridad";
            this.pnlDivPrioridad.Size = new System.Drawing.Size(260, 1);
            this.pnlDivPrioridad.TabIndex = 13;
            // 
            // lblEstAltaLbl
            // 
            this.lblEstAltaLbl.AutoSize = true;
            this.lblEstAltaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstAltaLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstAltaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEstAltaLbl.Location = new System.Drawing.Point(0, 190);
            this.lblEstAltaLbl.Name = "lblEstAltaLbl";
            this.lblEstAltaLbl.Size = new System.Drawing.Size(45, 25);
            this.lblEstAltaLbl.TabIndex = 14;
            this.lblEstAltaLbl.Text = "Alta";
            // 
            // lblEstAltaVal
            // 
            this.lblEstAltaVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstAltaVal.AutoSize = true;
            this.lblEstAltaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstAltaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstAltaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEstAltaVal.Location = new System.Drawing.Point(210, 190);
            this.lblEstAltaVal.Name = "lblEstAltaVal";
            this.lblEstAltaVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstAltaVal.TabIndex = 15;
            this.lblEstAltaVal.Text = "0";
            // 
            // pnlDivPA
            // 
            this.pnlDivPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivPA.Location = new System.Drawing.Point(0, 210);
            this.pnlDivPA.Name = "pnlDivPA";
            this.pnlDivPA.Size = new System.Drawing.Size(260, 1);
            this.pnlDivPA.TabIndex = 16;
            // 
            // lblEstMediaLbl
            // 
            this.lblEstMediaLbl.AutoSize = true;
            this.lblEstMediaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstMediaLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstMediaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblEstMediaLbl.Location = new System.Drawing.Point(0, 222);
            this.lblEstMediaLbl.Name = "lblEstMediaLbl";
            this.lblEstMediaLbl.Size = new System.Drawing.Size(65, 25);
            this.lblEstMediaLbl.TabIndex = 17;
            this.lblEstMediaLbl.Text = "Media";
            // 
            // lblEstMediaVal
            // 
            this.lblEstMediaVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstMediaVal.AutoSize = true;
            this.lblEstMediaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstMediaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstMediaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblEstMediaVal.Location = new System.Drawing.Point(210, 222);
            this.lblEstMediaVal.Name = "lblEstMediaVal";
            this.lblEstMediaVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstMediaVal.TabIndex = 18;
            this.lblEstMediaVal.Text = "0";
            // 
            // pnlDivPM
            // 
            this.pnlDivPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivPM.Location = new System.Drawing.Point(0, 242);
            this.pnlDivPM.Name = "pnlDivPM";
            this.pnlDivPM.Size = new System.Drawing.Size(260, 1);
            this.pnlDivPM.TabIndex = 19;
            // 
            // lblEstBajaLbl
            // 
            this.lblEstBajaLbl.AutoSize = true;
            this.lblEstBajaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstBajaLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstBajaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblEstBajaLbl.Location = new System.Drawing.Point(0, 254);
            this.lblEstBajaLbl.Name = "lblEstBajaLbl";
            this.lblEstBajaLbl.Size = new System.Drawing.Size(48, 25);
            this.lblEstBajaLbl.TabIndex = 20;
            this.lblEstBajaLbl.Text = "Baja";
            // 
            // lblEstBajaVal
            // 
            this.lblEstBajaVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstBajaVal.AutoSize = true;
            this.lblEstBajaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEstBajaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstBajaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblEstBajaVal.Location = new System.Drawing.Point(210, 254);
            this.lblEstBajaVal.Name = "lblEstBajaVal";
            this.lblEstBajaVal.Size = new System.Drawing.Size(23, 28);
            this.lblEstBajaVal.TabIndex = 21;
            this.lblEstBajaVal.Text = "0";
            // 
            // pnlUltUsuarios
            // 
            this.pnlUltUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUltUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlUltUsuarios.Controls.Add(this.lblSecUltUsuarios);
            this.pnlUltUsuarios.Controls.Add(this.lvUltUsuarios);
            this.pnlUltUsuarios.Location = new System.Drawing.Point(712, 17);
            this.pnlUltUsuarios.Name = "pnlUltUsuarios";
            this.pnlUltUsuarios.Size = new System.Drawing.Size(475, 540);
            this.pnlUltUsuarios.TabIndex = 2;
            // 
            // lblSecUltUsuarios
            // 
            this.lblSecUltUsuarios.AutoSize = true;
            this.lblSecUltUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblSecUltUsuarios.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecUltUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSecUltUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblSecUltUsuarios.Name = "lblSecUltUsuarios";
            this.lblSecUltUsuarios.Size = new System.Drawing.Size(274, 21);
            this.lblSecUltUsuarios.TabIndex = 0;
            this.lblSecUltUsuarios.Text = "ÚLTIMOS USUARIOS REGISTRADOS";
            // 
            // lvUltUsuarios
            // 
            this.lvUltUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUltUsuarios.BackColor = System.Drawing.Color.White;
            this.lvUltUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUltUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUUNombre,
            this.colUURol,
            this.colUUFecha});
            this.lvUltUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvUltUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvUltUsuarios.FullRowSelect = true;
            this.lvUltUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUltUsuarios.HideSelection = false;
            this.lvUltUsuarios.Location = new System.Drawing.Point(12, 21);
            this.lvUltUsuarios.MultiSelect = false;
            this.lvUltUsuarios.Name = "lvUltUsuarios";
            this.lvUltUsuarios.Size = new System.Drawing.Size(445, 516);
            this.lvUltUsuarios.TabIndex = 1;
            this.lvUltUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUltUsuarios.View = System.Windows.Forms.View.Details;
            this.lvUltUsuarios.SelectedIndexChanged += new System.EventHandler(this.lvUltUsuarios_SelectedIndexChanged);
            // 
            // colUUNombre
            // 
            this.colUUNombre.Text = "Nombre completo";
            this.colUUNombre.Width = 180;
            // 
            // colUURol
            // 
            this.colUURol.Text = "Rol";
            this.colUURol.Width = 90;
            // 
            // colUUFecha
            // 
            this.colUUFecha.Text = "Fecha registro";
            this.colUUFecha.Width = 130;
            // 
            // pnlTarjetas
            // 
            this.pnlTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTarjetas.BackColor = System.Drawing.Color.Transparent;
            this.pnlTarjetas.Controls.Add(this.pnlCardUsuarios);
            this.pnlTarjetas.Controls.Add(this.pnlCardAdmins);
            this.pnlTarjetas.Controls.Add(this.pnlCardTickets);
            this.pnlTarjetas.Controls.Add(this.pnlCardAlta);
            this.pnlTarjetas.Controls.Add(this.pnlCardPendientes);
            this.pnlTarjetas.Location = new System.Drawing.Point(0, 20);
            this.pnlTarjetas.Name = "pnlTarjetas";
            this.pnlTarjetas.Size = new System.Drawing.Size(2166, 110);
            this.pnlTarjetas.TabIndex = 1;
            // 
            // pnlCardUsuarios
            // 
            this.pnlCardUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlCardUsuarios.Controls.Add(this.lblCardUsuariosLbl);
            this.pnlCardUsuarios.Controls.Add(this.lblCardUsuariosNum);
            this.pnlCardUsuarios.Controls.Add(this.pnlBarUsuarios);
            this.pnlCardUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlCardUsuarios.Name = "pnlCardUsuarios";
            this.pnlCardUsuarios.Size = new System.Drawing.Size(214, 108);
            this.pnlCardUsuarios.TabIndex = 0;
            // 
            // lblCardUsuariosLbl
            // 
            this.lblCardUsuariosLbl.AutoSize = true;
            this.lblCardUsuariosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCardUsuariosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardUsuariosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCardUsuariosLbl.Location = new System.Drawing.Point(14, 12);
            this.lblCardUsuariosLbl.Name = "lblCardUsuariosLbl";
            this.lblCardUsuariosLbl.Size = new System.Drawing.Size(140, 21);
            this.lblCardUsuariosLbl.TabIndex = 0;
            this.lblCardUsuariosLbl.Text = "TOTAL USUARIOS";
            // 
            // lblCardUsuariosNum
            // 
            this.lblCardUsuariosNum.AutoSize = true;
            this.lblCardUsuariosNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardUsuariosNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCardUsuariosNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardUsuariosNum.Location = new System.Drawing.Point(12, 30);
            this.lblCardUsuariosNum.Name = "lblCardUsuariosNum";
            this.lblCardUsuariosNum.Size = new System.Drawing.Size(63, 74);
            this.lblCardUsuariosNum.TabIndex = 1;
            this.lblCardUsuariosNum.Text = "0";
            // 
            // pnlBarUsuarios
            // 
            this.pnlBarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlBarUsuarios.Location = new System.Drawing.Point(14, 94);
            this.pnlBarUsuarios.Name = "pnlBarUsuarios";
            this.pnlBarUsuarios.Size = new System.Drawing.Size(186, 4);
            this.pnlBarUsuarios.TabIndex = 2;
            // 
            // pnlCardAdmins
            // 
            this.pnlCardAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlCardAdmins.Controls.Add(this.lblCardAdminsLbl);
            this.pnlCardAdmins.Controls.Add(this.lblCardAdminsNum);
            this.pnlCardAdmins.Controls.Add(this.pnlBarAdmins);
            this.pnlCardAdmins.Location = new System.Drawing.Point(222, 0);
            this.pnlCardAdmins.Name = "pnlCardAdmins";
            this.pnlCardAdmins.Size = new System.Drawing.Size(214, 108);
            this.pnlCardAdmins.TabIndex = 1;
            // 
            // lblCardAdminsLbl
            // 
            this.lblCardAdminsLbl.AutoSize = true;
            this.lblCardAdminsLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAdminsLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardAdminsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblCardAdminsLbl.Location = new System.Drawing.Point(14, 12);
            this.lblCardAdminsLbl.Name = "lblCardAdminsLbl";
            this.lblCardAdminsLbl.Size = new System.Drawing.Size(125, 21);
            this.lblCardAdminsLbl.TabIndex = 0;
            this.lblCardAdminsLbl.Text = "TOTAL ADMINS";
            // 
            // lblCardAdminsNum
            // 
            this.lblCardAdminsNum.AutoSize = true;
            this.lblCardAdminsNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAdminsNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCardAdminsNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardAdminsNum.Location = new System.Drawing.Point(12, 30);
            this.lblCardAdminsNum.Name = "lblCardAdminsNum";
            this.lblCardAdminsNum.Size = new System.Drawing.Size(63, 74);
            this.lblCardAdminsNum.TabIndex = 1;
            this.lblCardAdminsNum.Text = "0";
            // 
            // pnlBarAdmins
            // 
            this.pnlBarAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlBarAdmins.Location = new System.Drawing.Point(14, 94);
            this.pnlBarAdmins.Name = "pnlBarAdmins";
            this.pnlBarAdmins.Size = new System.Drawing.Size(186, 4);
            this.pnlBarAdmins.TabIndex = 2;
            // 
            // pnlCardTickets
            // 
            this.pnlCardTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlCardTickets.Controls.Add(this.lblCardTicketsLbl);
            this.pnlCardTickets.Controls.Add(this.lblCardTicketsNum);
            this.pnlCardTickets.Controls.Add(this.pnlBarTickets);
            this.pnlCardTickets.Location = new System.Drawing.Point(444, 0);
            this.pnlCardTickets.Name = "pnlCardTickets";
            this.pnlCardTickets.Size = new System.Drawing.Size(214, 108);
            this.pnlCardTickets.TabIndex = 2;
            // 
            // lblCardTicketsLbl
            // 
            this.lblCardTicketsLbl.AutoSize = true;
            this.lblCardTicketsLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCardTicketsLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardTicketsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblCardTicketsLbl.Location = new System.Drawing.Point(14, 12);
            this.lblCardTicketsLbl.Name = "lblCardTicketsLbl";
            this.lblCardTicketsLbl.Size = new System.Drawing.Size(121, 21);
            this.lblCardTicketsLbl.TabIndex = 0;
            this.lblCardTicketsLbl.Text = "TOTAL TICKETS";
            // 
            // lblCardTicketsNum
            // 
            this.lblCardTicketsNum.AutoSize = true;
            this.lblCardTicketsNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardTicketsNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCardTicketsNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardTicketsNum.Location = new System.Drawing.Point(12, 30);
            this.lblCardTicketsNum.Name = "lblCardTicketsNum";
            this.lblCardTicketsNum.Size = new System.Drawing.Size(63, 74);
            this.lblCardTicketsNum.TabIndex = 1;
            this.lblCardTicketsNum.Text = "0";
            // 
            // pnlBarTickets
            // 
            this.pnlBarTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlBarTickets.Location = new System.Drawing.Point(14, 94);
            this.pnlBarTickets.Name = "pnlBarTickets";
            this.pnlBarTickets.Size = new System.Drawing.Size(186, 4);
            this.pnlBarTickets.TabIndex = 2;
            // 
            // pnlCardAlta
            // 
            this.pnlCardAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlCardAlta.Controls.Add(this.lblCardAltaLbl);
            this.pnlCardAlta.Controls.Add(this.lblCardAltaNum);
            this.pnlCardAlta.Controls.Add(this.pnlBarAlta);
            this.pnlCardAlta.Location = new System.Drawing.Point(666, 0);
            this.pnlCardAlta.Name = "pnlCardAlta";
            this.pnlCardAlta.Size = new System.Drawing.Size(214, 108);
            this.pnlCardAlta.TabIndex = 3;
            // 
            // lblCardAltaLbl
            // 
            this.lblCardAltaLbl.AutoSize = true;
            this.lblCardAltaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAltaLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardAltaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCardAltaLbl.Location = new System.Drawing.Point(14, 12);
            this.lblCardAltaLbl.Name = "lblCardAltaLbl";
            this.lblCardAltaLbl.Size = new System.Drawing.Size(138, 21);
            this.lblCardAltaLbl.TabIndex = 0;
            this.lblCardAltaLbl.Text = "ALTA PRIORIDAD";
            // 
            // lblCardAltaNum
            // 
            this.lblCardAltaNum.AutoSize = true;
            this.lblCardAltaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAltaNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCardAltaNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardAltaNum.Location = new System.Drawing.Point(12, 30);
            this.lblCardAltaNum.Name = "lblCardAltaNum";
            this.lblCardAltaNum.Size = new System.Drawing.Size(63, 74);
            this.lblCardAltaNum.TabIndex = 1;
            this.lblCardAltaNum.Text = "0";
            // 
            // pnlBarAlta
            // 
            this.pnlBarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlBarAlta.Location = new System.Drawing.Point(14, 94);
            this.pnlBarAlta.Name = "pnlBarAlta";
            this.pnlBarAlta.Size = new System.Drawing.Size(186, 4);
            this.pnlBarAlta.TabIndex = 2;
            // 
            // pnlCardPendientes
            // 
            this.pnlCardPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlCardPendientes.Controls.Add(this.lblCardPendientesLbl);
            this.pnlCardPendientes.Controls.Add(this.lblCardPendientesNum);
            this.pnlCardPendientes.Controls.Add(this.pnlBarPendientes);
            this.pnlCardPendientes.Location = new System.Drawing.Point(888, 0);
            this.pnlCardPendientes.Name = "pnlCardPendientes";
            this.pnlCardPendientes.Size = new System.Drawing.Size(214, 108);
            this.pnlCardPendientes.TabIndex = 4;
            // 
            // lblCardPendientesLbl
            // 
            this.lblCardPendientesLbl.AutoSize = true;
            this.lblCardPendientesLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCardPendientesLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardPendientesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblCardPendientesLbl.Location = new System.Drawing.Point(14, 12);
            this.lblCardPendientesLbl.Name = "lblCardPendientesLbl";
            this.lblCardPendientesLbl.Size = new System.Drawing.Size(108, 21);
            this.lblCardPendientesLbl.TabIndex = 0;
            this.lblCardPendientesLbl.Text = "PENDIENTES";
            // 
            // lblCardPendientesNum
            // 
            this.lblCardPendientesNum.AutoSize = true;
            this.lblCardPendientesNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCardPendientesNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCardPendientesNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCardPendientesNum.Location = new System.Drawing.Point(12, 30);
            this.lblCardPendientesNum.Name = "lblCardPendientesNum";
            this.lblCardPendientesNum.Size = new System.Drawing.Size(63, 74);
            this.lblCardPendientesNum.TabIndex = 1;
            this.lblCardPendientesNum.Text = "0";
            // 
            // pnlBarPendientes
            // 
            this.pnlBarPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlBarPendientes.Location = new System.Drawing.Point(14, 94);
            this.pnlBarPendientes.Name = "pnlBarPendientes";
            this.pnlBarPendientes.Size = new System.Drawing.Size(186, 4);
            this.pnlBarPendientes.TabIndex = 2;
            // 
            // lblSecResumen
            // 
            this.lblSecResumen.AutoSize = true;
            this.lblSecResumen.BackColor = System.Drawing.Color.Transparent;
            this.lblSecResumen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSecResumen.Location = new System.Drawing.Point(0, 0);
            this.lblSecResumen.Name = "lblSecResumen";
            this.lblSecResumen.Size = new System.Drawing.Size(162, 21);
            this.lblSecResumen.TabIndex = 2;
            this.lblSecResumen.Text = "RESUMEN GENERAL";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlScroll);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(1000, 660);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1200, 780);
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.pnlFilaInferior.ResumeLayout(false);
            this.pnlActividad.ResumeLayout(false);
            this.pnlActividad.PerformLayout();
            this.pnlEstadisticas.ResumeLayout(false);
            this.pnlEstadisticas.PerformLayout();
            this.pnlUltUsuarios.ResumeLayout(false);
            this.pnlUltUsuarios.PerformLayout();
            this.pnlTarjetas.ResumeLayout(false);
            this.pnlCardUsuarios.ResumeLayout(false);
            this.pnlCardUsuarios.PerformLayout();
            this.pnlCardAdmins.ResumeLayout(false);
            this.pnlCardAdmins.PerformLayout();
            this.pnlCardTickets.ResumeLayout(false);
            this.pnlCardTickets.PerformLayout();
            this.pnlCardAlta.ResumeLayout(false);
            this.pnlCardAlta.PerformLayout();
            this.pnlCardPendientes.ResumeLayout(false);
            this.pnlCardPendientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label lblSecResumen;

        private System.Windows.Forms.Panel pnlTarjetas;
        private System.Windows.Forms.Panel pnlCardUsuarios;
        private System.Windows.Forms.Label lblCardUsuariosNum;
        private System.Windows.Forms.Label lblCardUsuariosLbl;
        private System.Windows.Forms.Panel pnlBarUsuarios;
        private System.Windows.Forms.Panel pnlCardAdmins;
        private System.Windows.Forms.Label lblCardAdminsNum;
        private System.Windows.Forms.Label lblCardAdminsLbl;
        private System.Windows.Forms.Panel pnlBarAdmins;
        private System.Windows.Forms.Panel pnlCardTickets;
        private System.Windows.Forms.Label lblCardTicketsNum;
        private System.Windows.Forms.Label lblCardTicketsLbl;
        private System.Windows.Forms.Panel pnlBarTickets;
        private System.Windows.Forms.Panel pnlCardAlta;
        private System.Windows.Forms.Label lblCardAltaNum;
        private System.Windows.Forms.Label lblCardAltaLbl;
        private System.Windows.Forms.Panel pnlBarAlta;
        private System.Windows.Forms.Panel pnlCardPendientes;
        private System.Windows.Forms.Label lblCardPendientesNum;
        private System.Windows.Forms.Label lblCardPendientesLbl;
        private System.Windows.Forms.Panel pnlBarPendientes;

        private System.Windows.Forms.Panel pnlFilaInferior;

        private System.Windows.Forms.Panel pnlActividad;
        private System.Windows.Forms.Label lblSecActividad;
        private System.Windows.Forms.ListView lvActividad;
        private System.Windows.Forms.ColumnHeader colActFecha;
        private System.Windows.Forms.ColumnHeader colActDescripcion;

        private System.Windows.Forms.Panel pnlEstadisticas;
        private System.Windows.Forms.Label lblSecEstadisticas;
        private System.Windows.Forms.Label lblEstSubEstado;
        private System.Windows.Forms.Panel pnlDivEstado;
        private System.Windows.Forms.Label lblEstAbiertosLbl;
        private System.Windows.Forms.Label lblEstAbiertosVal;
        private System.Windows.Forms.Panel pnlDivEA;
        private System.Windows.Forms.Label lblEstProcesoLbl;
        private System.Windows.Forms.Label lblEstProcesoVal;
        private System.Windows.Forms.Panel pnlDivEP;
        private System.Windows.Forms.Label lblEstCerradosLbl;
        private System.Windows.Forms.Label lblEstCerradosVal;
        private System.Windows.Forms.Panel pnlDivEC;
        private System.Windows.Forms.Label lblEstSubPrioridad;
        private System.Windows.Forms.Panel pnlDivPrioridad;
        private System.Windows.Forms.Label lblEstAltaLbl;
        private System.Windows.Forms.Label lblEstAltaVal;
        private System.Windows.Forms.Panel pnlDivPA;
        private System.Windows.Forms.Label lblEstMediaLbl;
        private System.Windows.Forms.Label lblEstMediaVal;
        private System.Windows.Forms.Panel pnlDivPM;
        private System.Windows.Forms.Label lblEstBajaLbl;
        private System.Windows.Forms.Label lblEstBajaVal;

        private System.Windows.Forms.Panel pnlUltUsuarios;
        private System.Windows.Forms.Label lblSecUltUsuarios;
        private System.Windows.Forms.ListView lvUltUsuarios;
        private System.Windows.Forms.ColumnHeader colUUNombre;
        private System.Windows.Forms.ColumnHeader colUURol;
        private System.Windows.Forms.ColumnHeader colUUFecha;
    }
}