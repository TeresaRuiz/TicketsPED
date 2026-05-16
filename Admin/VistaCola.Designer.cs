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
            this.btnAtenderSiguiente = new System.Windows.Forms.Button();
            this.lblTituloCola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
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
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.btnAtenderSiguiente);
            this.pnlTopBar.Controls.Add(this.lblTituloCola);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlTopBar.Size = new System.Drawing.Size(1832, 100);
            this.pnlTopBar.TabIndex = 1;
            // 
            // btnAtenderSiguiente
            // 
            this.btnAtenderSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtenderSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.btnAtenderSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtenderSiguiente.FlatAppearance.BorderSize = 0;
            this.btnAtenderSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.btnAtenderSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtenderSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnAtenderSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnAtenderSiguiente.Location = new System.Drawing.Point(1550, 25);
            this.btnAtenderSiguiente.Name = "btnAtenderSiguiente";
            this.btnAtenderSiguiente.Size = new System.Drawing.Size(260, 50);
            this.btnAtenderSiguiente.TabIndex = 0;
            this.btnAtenderSiguiente.Text = "🚀 Atender Siguiente";
            this.btnAtenderSiguiente.UseVisualStyleBackColor = false;
            this.btnAtenderSiguiente.Click += new System.EventHandler(this.btnAtenderSiguiente_Click);
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
            this.label1.Location = new System.Drawing.Point(240, 14);
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
            this.pnlDerecho.Controls.Add(this.groupBox1);
            this.pnlDerecho.Location = new System.Drawing.Point(0, 660);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Padding = new System.Windows.Forms.Padding(14);
            this.pnlDerecho.Size = new System.Drawing.Size(1832, 278);
            this.pnlDerecho.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1804, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESUMEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 32);
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
            this.label6.Location = new System.Drawing.Point(1650, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 112);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
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
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlColaHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtenderSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTituloCola;
        private System.Windows.Forms.Panel pnlDerecho;
    }
}