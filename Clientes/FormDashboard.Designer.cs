namespace TicketsMDB
{
    partial class FormDashboard
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblSeccionResumen = new System.Windows.Forms.Label();
            this.pnlStatsGrid = new System.Windows.Forms.Panel();
            this.pnlAbiertos = new System.Windows.Forms.Panel();
            this.lblAbiertosLbl = new System.Windows.Forms.Label();
            this.lblAbiertosNum = new System.Windows.Forms.Label();
            this.lblAbiertosDesc = new System.Windows.Forms.Label();
            this.pnlBarAbiertos = new System.Windows.Forms.Panel();
            this.pnlFillAbiertos = new System.Windows.Forms.Panel();
            this.pnlProceso = new System.Windows.Forms.Panel();
            this.lblProcesoLbl = new System.Windows.Forms.Label();
            this.lblProcesoNum = new System.Windows.Forms.Label();
            this.lblProcesoDesc = new System.Windows.Forms.Label();
            this.pnlBarProceso = new System.Windows.Forms.Panel();
            this.pnlFillProceso = new System.Windows.Forms.Panel();
            this.pnlCerrados = new System.Windows.Forms.Panel();
            this.lblCerradosLbl = new System.Windows.Forms.Label();
            this.lblCerradosNum = new System.Windows.Forms.Label();
            this.lblCerradosDesc = new System.Windows.Forms.Label();
            this.pnlBarCerrados = new System.Windows.Forms.Panel();
            this.pnlFillCerrados = new System.Windows.Forms.Panel();
            this.lblSeccionTickets = new System.Windows.Forms.Label();
            this.btnNuevoTicket = new System.Windows.Forms.Button();
            this.lvTickets = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioridad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlContent.SuspendLayout();
            this.pnlHint.SuspendLayout();
            this.pnlStatsGrid.SuspendLayout();
            this.pnlAbiertos.SuspendLayout();
            this.pnlBarAbiertos.SuspendLayout();
            this.pnlProceso.SuspendLayout();
            this.pnlBarProceso.SuspendLayout();
            this.pnlCerrados.SuspendLayout();
            this.pnlBarCerrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblSaludo);
            this.pnlContent.Controls.Add(this.lblInformacion);
            this.pnlContent.Controls.Add(this.pnlHint);
            this.pnlContent.Controls.Add(this.lblSeccionResumen);
            this.pnlContent.Controls.Add(this.pnlStatsGrid);
            this.pnlContent.Controls.Add(this.lblSeccionTickets);
            this.pnlContent.Controls.Add(this.btnNuevoTicket);
            this.pnlContent.Controls.Add(this.lvTickets);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(28, 24, 28, 20);
            this.pnlContent.Size = new System.Drawing.Size(1016, 660);
            this.pnlContent.TabIndex = 0;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSaludo.Location = new System.Drawing.Point(0, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(281, 41);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Bienvenido usuario";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblInformacion.Location = new System.Drawing.Point(12, 35);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(348, 25);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Este es el estado de tus tickets de soporte.";
            // 
            // pnlHint
            // 
            this.pnlHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlHint.Controls.Add(this.lblTexto);
            this.pnlHint.Location = new System.Drawing.Point(0, 60);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(1616, 36);
            this.pnlHint.TabIndex = 2;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.lblTexto.Location = new System.Drawing.Point(0, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTexto.Size = new System.Drawing.Size(1616, 36);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "ℹ  Solo puedes ver y gestionar tus propios tickets. Para crear uno nuevo usa el b" +
    "otón correspondiente.";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeccionResumen
            // 
            this.lblSeccionResumen.AutoSize = true;
            this.lblSeccionResumen.BackColor = System.Drawing.Color.Transparent;
            this.lblSeccionResumen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSeccionResumen.Location = new System.Drawing.Point(0, 112);
            this.lblSeccionResumen.Name = "lblSeccionResumen";
            this.lblSeccionResumen.Size = new System.Drawing.Size(104, 21);
            this.lblSeccionResumen.TabIndex = 3;
            this.lblSeccionResumen.Text = "MIS TICKETS";
            // 
            // pnlStatsGrid
            // 
            this.pnlStatsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsGrid.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatsGrid.Controls.Add(this.pnlAbiertos);
            this.pnlStatsGrid.Controls.Add(this.pnlProceso);
            this.pnlStatsGrid.Controls.Add(this.pnlCerrados);
            this.pnlStatsGrid.Location = new System.Drawing.Point(7, 136);
            this.pnlStatsGrid.Name = "pnlStatsGrid";
            this.pnlStatsGrid.Size = new System.Drawing.Size(988, 120);
            this.pnlStatsGrid.TabIndex = 4;
            // 
            // pnlAbiertos
            // 
            this.pnlAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlAbiertos.Controls.Add(this.lblAbiertosLbl);
            this.pnlAbiertos.Controls.Add(this.lblAbiertosNum);
            this.pnlAbiertos.Controls.Add(this.lblAbiertosDesc);
            this.pnlAbiertos.Controls.Add(this.pnlBarAbiertos);
            this.pnlAbiertos.Location = new System.Drawing.Point(49, 2);
            this.pnlAbiertos.Name = "pnlAbiertos";
            this.pnlAbiertos.Size = new System.Drawing.Size(258, 106);
            this.pnlAbiertos.TabIndex = 0;
            // 
            // lblAbiertosLbl
            // 
            this.lblAbiertosLbl.AutoSize = true;
            this.lblAbiertosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblAbiertosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAbiertosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAbiertosLbl.Location = new System.Drawing.Point(16, 12);
            this.lblAbiertosLbl.Name = "lblAbiertosLbl";
            this.lblAbiertosLbl.Size = new System.Drawing.Size(84, 21);
            this.lblAbiertosLbl.TabIndex = 0;
            this.lblAbiertosLbl.Text = "ABIERTOS";
            // 
            // lblAbiertosNum
            // 
            this.lblAbiertosNum.AutoSize = true;
            this.lblAbiertosNum.BackColor = System.Drawing.Color.Transparent;
            this.lblAbiertosNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblAbiertosNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblAbiertosNum.Location = new System.Drawing.Point(14, 30);
            this.lblAbiertosNum.Name = "lblAbiertosNum";
            this.lblAbiertosNum.Size = new System.Drawing.Size(63, 74);
            this.lblAbiertosNum.TabIndex = 1;
            this.lblAbiertosNum.Text = "3";
            // 
            // lblAbiertosDesc
            // 
            this.lblAbiertosDesc.AutoSize = true;
            this.lblAbiertosDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblAbiertosDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAbiertosDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAbiertosDesc.Location = new System.Drawing.Point(83, 49);
            this.lblAbiertosDesc.Name = "lblAbiertosDesc";
            this.lblAbiertosDesc.Size = new System.Drawing.Size(146, 21);
            this.lblAbiertosDesc.TabIndex = 2;
            this.lblAbiertosDesc.Text = "Esperando atención";
            // 
            // pnlBarAbiertos
            // 
            this.pnlBarAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.pnlBarAbiertos.Controls.Add(this.pnlFillAbiertos);
            this.pnlBarAbiertos.Location = new System.Drawing.Point(16, 90);
            this.pnlBarAbiertos.Name = "pnlBarAbiertos";
            this.pnlBarAbiertos.Size = new System.Drawing.Size(226, 4);
            this.pnlBarAbiertos.TabIndex = 3;
            // 
            // pnlFillAbiertos
            // 
            this.pnlFillAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlFillAbiertos.Location = new System.Drawing.Point(0, 0);
            this.pnlFillAbiertos.Name = "pnlFillAbiertos";
            this.pnlFillAbiertos.Size = new System.Drawing.Size(113, 4);
            this.pnlFillAbiertos.TabIndex = 0;
            // 
            // pnlProceso
            // 
            this.pnlProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnlProceso.Controls.Add(this.lblProcesoLbl);
            this.pnlProceso.Controls.Add(this.lblProcesoNum);
            this.pnlProceso.Controls.Add(this.lblProcesoDesc);
            this.pnlProceso.Controls.Add(this.pnlBarProceso);
            this.pnlProceso.Location = new System.Drawing.Point(353, 0);
            this.pnlProceso.Name = "pnlProceso";
            this.pnlProceso.Size = new System.Drawing.Size(258, 106);
            this.pnlProceso.TabIndex = 1;
            // 
            // lblProcesoLbl
            // 
            this.lblProcesoLbl.AutoSize = true;
            this.lblProcesoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblProcesoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblProcesoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblProcesoLbl.Location = new System.Drawing.Point(16, 12);
            this.lblProcesoLbl.Name = "lblProcesoLbl";
            this.lblProcesoLbl.Size = new System.Drawing.Size(108, 21);
            this.lblProcesoLbl.TabIndex = 0;
            this.lblProcesoLbl.Text = "EN PROCESO";
            // 
            // lblProcesoNum
            // 
            this.lblProcesoNum.AutoSize = true;
            this.lblProcesoNum.BackColor = System.Drawing.Color.Transparent;
            this.lblProcesoNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblProcesoNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblProcesoNum.Location = new System.Drawing.Point(14, 30);
            this.lblProcesoNum.Name = "lblProcesoNum";
            this.lblProcesoNum.Size = new System.Drawing.Size(63, 74);
            this.lblProcesoNum.TabIndex = 1;
            this.lblProcesoNum.Text = "2";
            // 
            // lblProcesoDesc
            // 
            this.lblProcesoDesc.AutoSize = true;
            this.lblProcesoDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblProcesoDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProcesoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblProcesoDesc.Location = new System.Drawing.Point(97, 51);
            this.lblProcesoDesc.Name = "lblProcesoDesc";
            this.lblProcesoDesc.Size = new System.Drawing.Size(130, 21);
            this.lblProcesoDesc.TabIndex = 2;
            this.lblProcesoDesc.Text = "Siendo atendidos";
            // 
            // pnlBarProceso
            // 
            this.pnlBarProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.pnlBarProceso.Controls.Add(this.pnlFillProceso);
            this.pnlBarProceso.Location = new System.Drawing.Point(16, 90);
            this.pnlBarProceso.Name = "pnlBarProceso";
            this.pnlBarProceso.Size = new System.Drawing.Size(226, 4);
            this.pnlBarProceso.TabIndex = 3;
            // 
            // pnlFillProceso
            // 
            this.pnlFillProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlFillProceso.Location = new System.Drawing.Point(0, 0);
            this.pnlFillProceso.Name = "pnlFillProceso";
            this.pnlFillProceso.Size = new System.Drawing.Size(75, 4);
            this.pnlFillProceso.TabIndex = 0;
            // 
            // pnlCerrados
            // 
            this.pnlCerrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlCerrados.Controls.Add(this.lblCerradosLbl);
            this.pnlCerrados.Controls.Add(this.lblCerradosNum);
            this.pnlCerrados.Controls.Add(this.lblCerradosDesc);
            this.pnlCerrados.Controls.Add(this.pnlBarCerrados);
            this.pnlCerrados.Location = new System.Drawing.Point(681, 0);
            this.pnlCerrados.Name = "pnlCerrados";
            this.pnlCerrados.Size = new System.Drawing.Size(258, 106);
            this.pnlCerrados.TabIndex = 2;
            // 
            // lblCerradosLbl
            // 
            this.lblCerradosLbl.AutoSize = true;
            this.lblCerradosLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblCerradosLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCerradosLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.lblCerradosLbl.Location = new System.Drawing.Point(16, 12);
            this.lblCerradosLbl.Name = "lblCerradosLbl";
            this.lblCerradosLbl.Size = new System.Drawing.Size(93, 21);
            this.lblCerradosLbl.TabIndex = 0;
            this.lblCerradosLbl.Text = "CERRADOS";
            // 
            // lblCerradosNum
            // 
            this.lblCerradosNum.AutoSize = true;
            this.lblCerradosNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCerradosNum.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblCerradosNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCerradosNum.Location = new System.Drawing.Point(14, 30);
            this.lblCerradosNum.Name = "lblCerradosNum";
            this.lblCerradosNum.Size = new System.Drawing.Size(55, 74);
            this.lblCerradosNum.TabIndex = 1;
            this.lblCerradosNum.Text = "1";
            // 
            // lblCerradosDesc
            // 
            this.lblCerradosDesc.AutoSize = true;
            this.lblCerradosDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCerradosDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCerradosDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCerradosDesc.Location = new System.Drawing.Point(98, 51);
            this.lblCerradosDesc.Name = "lblCerradosDesc";
            this.lblCerradosDesc.Size = new System.Drawing.Size(77, 21);
            this.lblCerradosDesc.TabIndex = 2;
            this.lblCerradosDesc.Text = "Resueltos";
            // 
            // pnlBarCerrados
            // 
            this.pnlBarCerrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.pnlBarCerrados.Controls.Add(this.pnlFillCerrados);
            this.pnlBarCerrados.Location = new System.Drawing.Point(16, 90);
            this.pnlBarCerrados.Name = "pnlBarCerrados";
            this.pnlBarCerrados.Size = new System.Drawing.Size(226, 4);
            this.pnlBarCerrados.TabIndex = 3;
            // 
            // pnlFillCerrados
            // 
            this.pnlFillCerrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlFillCerrados.Location = new System.Drawing.Point(0, 0);
            this.pnlFillCerrados.Name = "pnlFillCerrados";
            this.pnlFillCerrados.Size = new System.Drawing.Size(38, 4);
            this.pnlFillCerrados.TabIndex = 0;
            // 
            // lblSeccionTickets
            // 
            this.lblSeccionTickets.AutoSize = true;
            this.lblSeccionTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblSeccionTickets.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSeccionTickets.Location = new System.Drawing.Point(16, 259);
            this.lblSeccionTickets.Name = "lblSeccionTickets";
            this.lblSeccionTickets.Size = new System.Drawing.Size(177, 21);
            this.lblSeccionTickets.TabIndex = 5;
            this.lblSeccionTickets.Text = "MIS ÚLTIMOS TICKETS";
            // 
            // btnNuevoTicket
            // 
            this.btnNuevoTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNuevoTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTicket.FlatAppearance.BorderSize = 0;
            this.btnNuevoTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnNuevoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevoTicket.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTicket.Location = new System.Drawing.Point(1508, 252);
            this.btnNuevoTicket.Name = "btnNuevoTicket";
            this.btnNuevoTicket.Size = new System.Drawing.Size(108, 28);
            this.btnNuevoTicket.TabIndex = 6;
            this.btnNuevoTicket.Text = "+ Nuevo ticket";
            this.btnNuevoTicket.UseVisualStyleBackColor = false;
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
            this.colPrioridad,
            this.colFecha});
            this.lvTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTickets.HideSelection = false;
            this.lvTickets.Location = new System.Drawing.Point(7, 294);
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(988, 347);
            this.lvTickets.TabIndex = 7;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "#";
            this.colId.Width = 54;
            // 
            // colTitulo
            // 
            this.colTitulo.Text = "Título";
            this.colTitulo.Width = 370;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 110;
            // 
            // colPrioridad
            // 
            this.colPrioridad.Text = "Prioridad";
            this.colPrioridad.Width = 100;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 150;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.MinimumSize = new System.Drawing.Size(760, 580);
            this.Name = "FormDashboard";
            this.Size = new System.Drawing.Size(1016, 660);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlHint.ResumeLayout(false);
            this.pnlStatsGrid.ResumeLayout(false);
            this.pnlAbiertos.ResumeLayout(false);
            this.pnlAbiertos.PerformLayout();
            this.pnlBarAbiertos.ResumeLayout(false);
            this.pnlProceso.ResumeLayout(false);
            this.pnlProceso.PerformLayout();
            this.pnlBarProceso.ResumeLayout(false);
            this.pnlCerrados.ResumeLayout(false);
            this.pnlCerrados.PerformLayout();
            this.pnlBarCerrados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblInformacion;

        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Label lblTexto;

        private System.Windows.Forms.Label lblSeccionResumen;
        private System.Windows.Forms.Panel pnlStatsGrid;

        private System.Windows.Forms.Panel pnlAbiertos;
        private System.Windows.Forms.Label lblAbiertosLbl;
        private System.Windows.Forms.Label lblAbiertosNum;
        private System.Windows.Forms.Label lblAbiertosDesc;
        private System.Windows.Forms.Panel pnlBarAbiertos;
        private System.Windows.Forms.Panel pnlFillAbiertos;

        private System.Windows.Forms.Panel pnlProceso;
        private System.Windows.Forms.Label lblProcesoLbl;
        private System.Windows.Forms.Label lblProcesoNum;
        private System.Windows.Forms.Label lblProcesoDesc;
        private System.Windows.Forms.Panel pnlBarProceso;
        private System.Windows.Forms.Panel pnlFillProceso;

        private System.Windows.Forms.Panel pnlCerrados;
        private System.Windows.Forms.Label lblCerradosLbl;
        private System.Windows.Forms.Label lblCerradosNum;
        private System.Windows.Forms.Label lblCerradosDesc;
        private System.Windows.Forms.Panel pnlBarCerrados;
        private System.Windows.Forms.Panel pnlFillCerrados;

        private System.Windows.Forms.Label lblSeccionTickets;
        private System.Windows.Forms.Button btnNuevoTicket;
        private System.Windows.Forms.ListView lvTickets;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitulo;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ColumnHeader colPrioridad;
        private System.Windows.Forms.ColumnHeader colFecha;
    }
}