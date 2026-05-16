using System.Drawing;

namespace TicketsMDB
{
    partial class VistaHistorialPila
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlDivDetalle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDivId = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDivEstado = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.pnlDivReciente = new System.Windows.Forms.Panel();
            this.pnlContenedorPila = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeshaer = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblTituloPanel);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1000, 45);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloPanel.Location = new System.Drawing.Point(12, 10);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(157, 21);
            this.lblTituloPanel.TabIndex = 0;
            this.lblTituloPanel.Text = "Historial de cambios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.pnlDivDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlDivId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnlDivEstado);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panel1.Size = new System.Drawing.Size(320, 180); // Reducido ancho y alto
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label29.Location = new System.Drawing.Point(12, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "PANEL DE DETALLE";
            // 
            // pnlDivDetalle
            // 
            this.pnlDivDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivDetalle.Location = new System.Drawing.Point(12, 26);
            this.pnlDivDetalle.Name = "pnlDivDetalle";
            this.pnlDivDetalle.Size = new System.Drawing.Size(296, 1);
            this.pnlDivDetalle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "#1";
            // 
            // pnlDivId
            // 
            this.pnlDivId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlDivId.Location = new System.Drawing.Point(12, 75);
            this.pnlDivId.Name = "pnlDivId";
            this.pnlDivId.Size = new Size(296, 1);
            this.pnlDivId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "ABIERTO";
            // 
            // pnlDivEstado
            // 
            this.pnlDivEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivEstado.Location = new System.Drawing.Point(12, 128);
            this.pnlDivEstado.Name = "pnlDivEstado";
            this.pnlDivEstado.Size = new System.Drawing.Size(296, 1);
            this.pnlDivEstado.TabIndex = 7;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label30.Location = new System.Drawing.Point(345, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "CAMBIO MÁS RECIENTE";
            // 
            // pnlDivReciente
            // 
            this.pnlDivReciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivReciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivReciente.Location = new System.Drawing.Point(345, 71);
            this.pnlDivReciente.Name = "pnlDivReciente";
            this.pnlDivReciente.Size = new Size(643, 1);
            this.pnlDivReciente.TabIndex = 15;
            // 
            // pnlContenedorPila
            // 
            this.pnlContenedorPila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorPila.AutoScroll = true;
            this.pnlContenedorPila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContenedorPila.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContenedorPila.Location = new System.Drawing.Point(345, 80);
            this.pnlContenedorPila.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContenedorPila.Name = "pnlContenedorPila";
            this.pnlContenedorPila.Padding = new System.Windows.Forms.Padding(6);
            this.pnlContenedorPila.Size = new Size(643, 470);
            this.pnlContenedorPila.TabIndex = 14;
            this.pnlContenedorPila.WrapContents = false;
            // 
            // btnDeshaer
            // 
            this.btnDeshaer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeshaer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDeshaer.FlatAppearance.BorderSize = 0;
            this.btnDeshaer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshaer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeshaer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDeshaer.Location = new System.Drawing.Point(12, 565); // Movido hacia arriba para evitar desborde
            this.btnDeshaer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeshaer.Name = "btnDeshaer";
            this.btnDeshaer.Size = new System.Drawing.Size(320, 40);
            this.btnDeshaer.TabIndex = 8;
            this.btnDeshaer.Text = "↩  Deshacer último cambio";
            this.btnDeshaer.UseVisualStyleBackColor = false;
            this.btnDeshaer.Click += new System.EventHandler(this.btnDeshaer_Click);
            // 
            // VistaHistorialPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlContenedorPila);
            this.Controls.Add(this.pnlDivReciente);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnDeshaer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VistaHistorialPila";
            this.Size = new System.Drawing.Size(1000, 630); // Ajustado a la escala para laptops
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeshaer;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.FlowLayoutPanel pnlContenedorPila;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Panel pnlDivDetalle;
        private System.Windows.Forms.Panel pnlDivId;
        private System.Windows.Forms.Panel pnlDivEstado;
        private System.Windows.Forms.Panel pnlDivReciente;
    }
}