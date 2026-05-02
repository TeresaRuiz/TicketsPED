namespace TicketsMDB
{
    partial class FormPrincipalCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(279, 0);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1014, 811);
            this.panelContenido.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnHistorial);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Controls.Add(this.btnTickets);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(279, 811);
            this.panelMenu.TabIndex = 6;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 740);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(249, 55);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.Location = new System.Drawing.Point(9, 141);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(252, 75);
            this.btnHistorial.TabIndex = 14;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(21, 704);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(9, 8);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(252, 55);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerfil.Location = new System.Drawing.Point(9, 232);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(252, 55);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTickets.Location = new System.Drawing.Point(9, 74);
            this.btnTickets.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(252, 55);
            this.btnTickets.TabIndex = 1;
            this.btnTickets.Text = "Ticket";
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // FormPrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 811);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipalCliente";
            this.Text = "FormPrincipalCliente";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnTickets;
    }
}