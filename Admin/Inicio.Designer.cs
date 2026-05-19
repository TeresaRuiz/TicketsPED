namespace TicketsMDB
{
    partial class Inicio
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
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.pnlContenedorTickets = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlUltimoTicket = new System.Windows.Forms.Panel();
            this.lblUltimoTitulo = new System.Windows.Forms.Label();
            this.pnlDivUltimo = new System.Windows.Forms.Panel();
            this.lblUltimoId = new System.Windows.Forms.Label();
            this.lblUltimoUsuario = new System.Windows.Forms.Label();
            this.lblUltimoEstado = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDivResumen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlDivTotal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDivAbiertos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDivProceso = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDivResueltos = new System.Windows.Forms.Panel();
            this.lblAltaLbl = new System.Windows.Forms.Label();
            this.lblAltaVal = new System.Windows.Forms.Label();
            this.pnlDivAlta = new System.Windows.Forms.Panel();
            this.lblAsignadosVal = new System.Windows.Forms.Label();
            this.lblResumenTitulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTopBar.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlUltimoTicket.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblTituloPanel);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1228, 48);
            this.pnlTopBar.TabIndex = 2;
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloPanel.Location = new System.Drawing.Point(16, 12);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(199, 36);
            this.lblTituloPanel.TabIndex = 0;
            this.lblTituloPanel.Text = "Panel de tickets";
            // 
            // pnlContenedorTickets
            // 
            this.pnlContenedorTickets.AutoScroll = true;
            this.pnlContenedorTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContenedorTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContenedorTickets.Location = new System.Drawing.Point(0, 48);
            this.pnlContenedorTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContenedorTickets.Name = "pnlContenedorTickets";
            this.pnlContenedorTickets.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContenedorTickets.Size = new System.Drawing.Size(740, 890);
            this.pnlContenedorTickets.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlRight.Controls.Add(this.pnlUltimoTicket);
            this.pnlRight.Controls.Add(this.pnlResumen);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(740, 48);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlRight.Size = new System.Drawing.Size(488, 890);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlUltimoTicket
            // 
            this.pnlUltimoTicket.BackColor = System.Drawing.Color.White;
            this.pnlUltimoTicket.Controls.Add(this.lblUltimoTitulo);
            this.pnlUltimoTicket.Controls.Add(this.pnlDivUltimo);
            this.pnlUltimoTicket.Controls.Add(this.lblUltimoId);
            this.pnlUltimoTicket.Controls.Add(this.lblUltimoUsuario);
            this.pnlUltimoTicket.Controls.Add(this.lblUltimoEstado);
            this.pnlUltimoTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUltimoTicket.Location = new System.Drawing.Point(16, 324);
            this.pnlUltimoTicket.Name = "pnlUltimoTicket";
            this.pnlUltimoTicket.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlUltimoTicket.Size = new System.Drawing.Size(456, 148);
            this.pnlUltimoTicket.TabIndex = 0;
            // 
            // lblUltimoTitulo
            // 
            this.lblUltimoTitulo.AutoSize = true;
            this.lblUltimoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUltimoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUltimoTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblUltimoTitulo.Name = "lblUltimoTitulo";
            this.lblUltimoTitulo.Size = new System.Drawing.Size(203, 21);
            this.lblUltimoTitulo.TabIndex = 0;
            this.lblUltimoTitulo.Text = "ÚLTIMO TICKET RECIBIDO";
            // 
            // pnlDivUltimo
            // 
            this.pnlDivUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivUltimo.Location = new System.Drawing.Point(16, 34);
            this.pnlDivUltimo.Name = "pnlDivUltimo";
            this.pnlDivUltimo.Size = new System.Drawing.Size(636, 1);
            this.pnlDivUltimo.TabIndex = 1;
            // 
            // lblUltimoId
            // 
            this.lblUltimoId.AutoSize = true;
            this.lblUltimoId.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoId.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUltimoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblUltimoId.Location = new System.Drawing.Point(16, 46);
            this.lblUltimoId.Name = "lblUltimoId";
            this.lblUltimoId.Size = new System.Drawing.Size(48, 30);
            this.lblUltimoId.TabIndex = 2;
            this.lblUltimoId.Text = "#—";
            // 
            // lblUltimoUsuario
            // 
            this.lblUltimoUsuario.AutoSize = true;
            this.lblUltimoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUltimoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblUltimoUsuario.Location = new System.Drawing.Point(16, 70);
            this.lblUltimoUsuario.Name = "lblUltimoUsuario";
            this.lblUltimoUsuario.Size = new System.Drawing.Size(99, 25);
            this.lblUltimoUsuario.TabIndex = 3;
            this.lblUltimoUsuario.Text = "Usuario: —";
            // 
            // lblUltimoEstado
            // 
            this.lblUltimoEstado.AutoSize = true;
            this.lblUltimoEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUltimoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblUltimoEstado.Location = new System.Drawing.Point(16, 90);
            this.lblUltimoEstado.Name = "lblUltimoEstado";
            this.lblUltimoEstado.Size = new System.Drawing.Size(97, 25);
            this.lblUltimoEstado.TabIndex = 4;
            this.lblUltimoEstado.Text = "Estado: —";
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.White;
            this.pnlResumen.Controls.Add(this.label1);
            this.pnlResumen.Controls.Add(this.pnlDivResumen);
            this.pnlResumen.Controls.Add(this.label2);
            this.pnlResumen.Controls.Add(this.label9);
            this.pnlResumen.Controls.Add(this.pnlDivTotal);
            this.pnlResumen.Controls.Add(this.label4);
            this.pnlResumen.Controls.Add(this.label7);
            this.pnlResumen.Controls.Add(this.pnlDivAbiertos);
            this.pnlResumen.Controls.Add(this.label3);
            this.pnlResumen.Controls.Add(this.label8);
            this.pnlResumen.Controls.Add(this.pnlDivProceso);
            this.pnlResumen.Controls.Add(this.label5);
            this.pnlResumen.Controls.Add(this.label6);
            this.pnlResumen.Controls.Add(this.pnlDivResueltos);
            this.pnlResumen.Controls.Add(this.lblAltaLbl);
            this.pnlResumen.Controls.Add(this.lblAltaVal);
            this.pnlResumen.Controls.Add(this.pnlDivAlta);
            this.pnlResumen.Controls.Add(this.lblAsignadosVal);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResumen.Location = new System.Drawing.Point(16, 14);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlResumen.Size = new System.Drawing.Size(456, 310);
            this.pnlResumen.TabIndex = 1;
            this.pnlResumen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResumen_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESUMEN DE TICKETS";
            // 
            // pnlDivResumen
            // 
            this.pnlDivResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivResumen.Location = new System.Drawing.Point(16, 34);
            this.pnlDivResumen.Name = "pnlDivResumen";
            this.pnlDivResumen.Size = new System.Drawing.Size(636, 1);
            this.pnlDivResumen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label9.Location = new System.Drawing.Point(586, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "0";
            // 
            // pnlDivTotal
            // 
            this.pnlDivTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivTotal.Location = new System.Drawing.Point(16, 68);
            this.pnlDivTotal.Name = "pnlDivTotal";
            this.pnlDivTotal.Size = new System.Drawing.Size(636, 1);
            this.pnlDivTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Abiertos";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(586, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "0";
            // 
            // pnlDivAbiertos
            // 
            this.pnlDivAbiertos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivAbiertos.Location = new System.Drawing.Point(16, 100);
            this.pnlDivAbiertos.Name = "pnlDivAbiertos";
            this.pnlDivAbiertos.Size = new System.Drawing.Size(636, 1);
            this.pnlDivAbiertos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "En proceso";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.label8.Location = new System.Drawing.Point(586, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "0";
            // 
            // pnlDivProceso
            // 
            this.pnlDivProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivProceso.Location = new System.Drawing.Point(16, 132);
            this.pnlDivProceso.Name = "pnlDivProceso";
            this.pnlDivProceso.Size = new System.Drawing.Size(636, 1);
            this.pnlDivProceso.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resueltos";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(586, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // pnlDivResueltos
            // 
            this.pnlDivResueltos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivResueltos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivResueltos.Location = new System.Drawing.Point(16, 164);
            this.pnlDivResueltos.Name = "pnlDivResueltos";
            this.pnlDivResueltos.Size = new System.Drawing.Size(636, 1);
            this.pnlDivResueltos.TabIndex = 10;
            // 
            // lblAltaLbl
            // 
            this.lblAltaLbl.AutoSize = true;
            this.lblAltaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaLbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAltaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAltaLbl.Location = new System.Drawing.Point(16, 176);
            this.lblAltaLbl.Name = "lblAltaLbl";
            this.lblAltaLbl.Size = new System.Drawing.Size(128, 25);
            this.lblAltaLbl.TabIndex = 11;
            this.lblAltaLbl.Text = "Alta prioridad";
            // 
            // lblAltaVal
            // 
            this.lblAltaVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltaVal.AutoSize = true;
            this.lblAltaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblAltaVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAltaVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAltaVal.Location = new System.Drawing.Point(586, 176);
            this.lblAltaVal.Name = "lblAltaVal";
            this.lblAltaVal.Size = new System.Drawing.Size(23, 28);
            this.lblAltaVal.TabIndex = 12;
            this.lblAltaVal.Text = "0";
            // 
            // pnlDivAlta
            // 
            this.pnlDivAlta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivAlta.Location = new System.Drawing.Point(16, 196);
            this.pnlDivAlta.Name = "pnlDivAlta";
            this.pnlDivAlta.Size = new System.Drawing.Size(636, 1);
            this.pnlDivAlta.TabIndex = 13;
            // 
            // lblAsignadosVal
            // 
            this.lblAsignadosVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAsignadosVal.AutoSize = true;
            this.lblAsignadosVal.BackColor = System.Drawing.Color.Transparent;
            this.lblAsignadosVal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAsignadosVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblAsignadosVal.Location = new System.Drawing.Point(586, 208);
            this.lblAsignadosVal.Name = "lblAsignadosVal";
            this.lblAsignadosVal.Size = new System.Drawing.Size(23, 28);
            this.lblAsignadosVal.TabIndex = 15;
            this.lblAsignadosVal.Text = "0";
            // 
            // lblResumenTitulo
            // 
            this.lblResumenTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblResumenTitulo.Name = "lblResumenTitulo";
            this.lblResumenTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblResumenTitulo.TabIndex = 0;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlContenedorTickets);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1228, 938);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlUltimoTicket.ResumeLayout(false);
            this.pnlUltimoTicket.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Nombres EXACTOS que usa Inicio.cs — NO renombrar ─────────────
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel pnlContenedorTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        // ── Nuevos controles ─────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblResumenTitulo;
        private System.Windows.Forms.Panel pnlDivResumen;
        private System.Windows.Forms.Panel pnlDivTotal;
        private System.Windows.Forms.Panel pnlDivAbiertos;
        private System.Windows.Forms.Panel pnlDivProceso;
        private System.Windows.Forms.Panel pnlDivResueltos;
        private System.Windows.Forms.Label lblAltaLbl;
        private System.Windows.Forms.Label lblAltaVal;
        private System.Windows.Forms.Panel pnlDivAlta;
        private System.Windows.Forms.Label lblAsignadosVal;
        private System.Windows.Forms.Panel pnlUltimoTicket;
        private System.Windows.Forms.Label lblUltimoTitulo;
        private System.Windows.Forms.Panel pnlDivUltimo;
        private System.Windows.Forms.Label lblUltimoId;
        private System.Windows.Forms.Label lblUltimoUsuario;
        private System.Windows.Forms.Label lblUltimoEstado;
    }
}