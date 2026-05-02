namespace TicketsMDB
{
    partial class FormPrincipalAdmin
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
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(279, 0);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1205, 938);
            this.panelContenido.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnPedido);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.btnMarca);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(279, 938);
            this.panelMenu.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 858);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(249, 55);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPedido.Location = new System.Drawing.Point(9, 141);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(252, 75);
            this.btnPedido.TabIndex = 14;
            this.btnPedido.Text = "Busqueda Avanzada";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(16, 815);
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
            // btnMarca
            // 
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMarca.Location = new System.Drawing.Point(9, 232);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(252, 55);
            this.btnMarca.TabIndex = 2;
            this.btnMarca.Text = "Tranzabilidad";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Location = new System.Drawing.Point(9, 74);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(252, 55);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Cola de Atención";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FormPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 938);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalAdmin";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnProductos;
    }
}