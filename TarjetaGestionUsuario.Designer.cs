namespace TicketsMDB
{
    partial class TarjetaGestionUsuario
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
            this.pnlGestionUsuarios = new System.Windows.Forms.Panel();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblIniciales = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.pnlGestionUsuarios.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGestionUsuarios
            // 
            this.pnlGestionUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGestionUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlGestionUsuarios.Controls.Add(this.pnlBarra);
            this.pnlGestionUsuarios.Controls.Add(this.pnlAvatar);
            this.pnlGestionUsuarios.Controls.Add(this.lblNombre);
            this.pnlGestionUsuarios.Controls.Add(this.lblUsuario);
            this.pnlGestionUsuarios.Controls.Add(this.pnlDivider);
            this.pnlGestionUsuarios.Controls.Add(this.label1);
            this.pnlGestionUsuarios.Controls.Add(this.lblCorreo);
            this.pnlGestionUsuarios.Controls.Add(this.label2);
            this.pnlGestionUsuarios.Controls.Add(this.lblRol);
            this.pnlGestionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionUsuarios.Name = "pnlGestionUsuarios";
            this.pnlGestionUsuarios.Size = new System.Drawing.Size(722, 98);
            this.pnlGestionUsuarios.TabIndex = 1;
            this.pnlGestionUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // pnlBarra
            // 
            this.pnlBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(4, 98);
            this.pnlBarra.TabIndex = 0;
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlAvatar.Controls.Add(this.lblIniciales);
            this.pnlAvatar.Location = new System.Drawing.Point(18, 18);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(52, 52);
            this.pnlAvatar.TabIndex = 1;
            // 
            // lblIniciales
            // 
            this.lblIniciales.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIniciales.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblIniciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblIniciales.Location = new System.Drawing.Point(0, 0);
            this.lblIniciales.Name = "lblIniciales";
            this.lblIniciales.Size = new System.Drawing.Size(52, 52);
            this.lblIniciales.TabIndex = 0;
            this.lblIniciales.Text = "JD";
            this.lblIniciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(84, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(211, 30);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUsuario.Location = new System.Drawing.Point(84, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "@usuario";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlDivider.Location = new System.Drawing.Point(340, 16);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1, 66);
            this.pnlDivider.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(358, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CORREO";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCorreo.Location = new System.Drawing.Point(358, 36);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(193, 25);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "correo@ejemplo.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(358, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ROL";
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblRol.Location = new System.Drawing.Point(358, 76);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(70, 20);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Cliente";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TarjetaGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGestionUsuarios);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Name = "TarjetaGestionUsuario";
            this.Size = new System.Drawing.Size(725, 100);
            this.pnlGestionUsuarios.ResumeLayout(false);
            this.pnlGestionUsuarios.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Nombres EXACTOS que usa TarjetaGestionUsuario.cs ─────────────
        private System.Windows.Forms.Panel pnlGestionUsuarios;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label1;   // "CORREO"
        private System.Windows.Forms.Label label2;   // "ROL"
        private System.Windows.Forms.Label lblRol;

        // ── Nuevos controles ─────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblIniciales;
        private System.Windows.Forms.Panel pnlDivider;
    }
}