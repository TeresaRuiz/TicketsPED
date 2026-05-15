namespace TicketsMDB
{
    partial class VistaCola
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.pnlColaHorizontal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTituloCola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtenderSiguiente = new System.Windows.Forms.Button();
            this.btnPriorizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTomarTicket = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.btnMarcarUrgente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColaHorizontal
            // 
            this.pnlColaHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColaHorizontal.AutoScroll = true;
            this.pnlColaHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlColaHorizontal.Location = new System.Drawing.Point(0, 100);
            this.pnlColaHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlColaHorizontal.Name = "pnlColaHorizontal";
            this.pnlColaHorizontal.Padding = new System.Windows.Forms.Padding(20);
            this.pnlColaHorizontal.Size = new System.Drawing.Size(1832, 552);
            this.pnlColaHorizontal.TabIndex = 0;
            this.pnlColaHorizontal.WrapContents = false;
            this.pnlColaHorizontal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColaHorizontal_Paint);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnVerDetalle);
            this.pnlTopBar.Controls.Add(this.lblTituloCola);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlTopBar.Size = new System.Drawing.Size(1832, 100);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblTituloCola
            // 
            this.lblTituloCola.AutoSize = true;
            this.lblTituloCola.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCola.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloCola.Location = new System.Drawing.Point(20, 12);
            this.lblTituloCola.Name = "lblTituloCola";
            this.lblTituloCola.Size = new System.Drawing.Size(214, 36);
            this.lblTituloCola.TabIndex = 0;
            this.lblTituloCola.Text = "Cola de atención";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "➡  SIGUIENTE EN ATENDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDerecho.AutoScroll = true;
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDerecho.Controls.Add(this.groupBox2);
            this.pnlDerecho.Controls.Add(this.groupBox1);
            this.pnlDerecho.Location = new System.Drawing.Point(0, 660);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(14);
            this.pnlDerecho.Size = new System.Drawing.Size(1832, 278);
            this.pnlDerecho.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAtenderSiguiente);
            this.groupBox2.Controls.Add(this.btnPriorizar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnTomarTicket);
            this.groupBox2.Controls.Add(this.btnCerrarTicket);
            this.groupBox2.Controls.Add(this.btnMarcarUrgente);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.groupBox2.Location = new System.Drawing.Point(14, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1778, 480);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "PANEL DE CONTROL";
            // 
            // btnAtenderSiguiente
            // 
            this.btnAtenderSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtenderSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnAtenderSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtenderSiguiente.FlatAppearance.BorderSize = 0;
            this.btnAtenderSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnAtenderSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtenderSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnAtenderSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnAtenderSiguiente.Location = new System.Drawing.Point(20, 52);
            this.btnAtenderSiguiente.Name = "btnAtenderSiguiente";
            this.btnAtenderSiguiente.Size = new System.Drawing.Size(1728, 70);
            this.btnAtenderSiguiente.TabIndex = 0;
            this.btnAtenderSiguiente.Text = "Atender siguiente";
            this.btnAtenderSiguiente.UseVisualStyleBackColor = false;
            this.btnAtenderSiguiente.Click += new System.EventHandler(this.btnAtenderSiguiente_Click);
            // 
            // btnPriorizar
            // 
            this.btnPriorizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPriorizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnPriorizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriorizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.btnPriorizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnPriorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriorizar.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPriorizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPriorizar.Location = new System.Drawing.Point(21, 131);
            this.btnPriorizar.Name = "btnPriorizar";
            this.btnPriorizar.Size = new System.Drawing.Size(1727, 70);
            this.btnPriorizar.TabIndex = 7;
            this.btnPriorizar.Text = "Priorizar ticket";
            this.btnPriorizar.UseVisualStyleBackColor = false;
            this.btnPriorizar.Click += new System.EventHandler(this.btnPriorizar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(16, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(490, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mueve el ticket seleccionado al inicio de la cola";
            // 
            // btnTomarTicket
            // 
            this.btnTomarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTomarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.btnTomarTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTomarTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.btnTomarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.btnTomarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTomarTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(85)))));
            this.btnTomarTicket.Location = new System.Drawing.Point(21, 239);
            this.btnTomarTicket.Name = "btnTomarTicket";
            this.btnTomarTicket.Size = new System.Drawing.Size(1727, 60);
            this.btnTomarTicket.TabIndex = 9;
            this.btnTomarTicket.Text = "Tomar ticket";
            this.btnTomarTicket.UseVisualStyleBackColor = false;
            this.btnTomarTicket.Click += new System.EventHandler(this.btnTomarTicket_Click);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrarTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btnCerrarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnCerrarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCerrarTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCerrarTicket.Location = new System.Drawing.Point(21, 314);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(1727, 60);
            this.btnCerrarTicket.TabIndex = 10;
            this.btnCerrarTicket.Text = "Cerrar ticket";
            this.btnCerrarTicket.UseVisualStyleBackColor = false;
            this.btnCerrarTicket.Click += new System.EventHandler(this.btnCerrarTicket_Click);
            // 
            // btnMarcarUrgente
            // 
            this.btnMarcarUrgente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcarUrgente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.btnMarcarUrgente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarUrgente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.btnMarcarUrgente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.btnMarcarUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarUrgente.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnMarcarUrgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnMarcarUrgente.Location = new System.Drawing.Point(21, 391);
            this.btnMarcarUrgente.Name = "btnMarcarUrgente";
            this.btnMarcarUrgente.Size = new System.Drawing.Size(1727, 60);
            this.btnMarcarUrgente.TabIndex = 11;
            this.btnMarcarUrgente.Text = "⚡  Marcar urgente";
            this.btnMarcarUrgente.UseVisualStyleBackColor = false;
            this.btnMarcarUrgente.Click += new System.EventHandler(this.btnMarcarUrgente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1778, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESUMEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(16, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tickets en espera";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(1918, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 112);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 860);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "⬛  FINAL DE LA COLA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(406, 50);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(135, 35);
            this.btnVerDetalle.TabIndex = 2;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // VistaCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlColaHorizontal);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VistaCola";
            this.Size = new System.Drawing.Size(1832, 938);
            this.Load += new System.EventHandler(this.VistaCola_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.FlowLayoutPanel pnlColaHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtenderSiguiente;
        private System.Windows.Forms.Button btnPriorizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTituloCola;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Button btnTomarTicket;
        private System.Windows.Forms.Button btnCerrarTicket;
        private System.Windows.Forms.Button btnMarcarUrgente;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}