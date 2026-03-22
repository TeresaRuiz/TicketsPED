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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnEstadoPedido = new System.Windows.Forms.Button();
            this.btnTipoPago = new System.Windows.Forms.Button();
            this.btnProductoProveedores = new System.Windows.Forms.Button();
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
            this.panelContenido.Location = new System.Drawing.Point(248, 0);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1071, 750);
            this.panelContenido.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnPedido);
            this.panelMenu.Controls.Add(this.btnEstadoPedido);
            this.panelMenu.Controls.Add(this.btnTipoPago);
            this.panelMenu.Controls.Add(this.btnProductoProveedores);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.btnMarca);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 750);
            this.panelMenu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 686);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPedido.Location = new System.Drawing.Point(8, 113);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(224, 60);
            this.btnPedido.TabIndex = 14;
            this.btnPedido.Text = "Busqueda Avanzada";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnEstadoPedido
            // 
            this.btnEstadoPedido.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEstadoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstadoPedido.Location = new System.Drawing.Point(8, 394);
            this.btnEstadoPedido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEstadoPedido.Name = "btnEstadoPedido";
            this.btnEstadoPedido.Size = new System.Drawing.Size(224, 60);
            this.btnEstadoPedido.TabIndex = 13;
            this.btnEstadoPedido.Text = "Gestión de estado pedido";
            this.btnEstadoPedido.UseVisualStyleBackColor = false;
            // 
            // btnTipoPago
            // 
            this.btnTipoPago.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoPago.Location = new System.Drawing.Point(8, 327);
            this.btnTipoPago.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTipoPago.Name = "btnTipoPago";
            this.btnTipoPago.Size = new System.Drawing.Size(224, 60);
            this.btnTipoPago.TabIndex = 12;
            this.btnTipoPago.Text = "Gestion de tipos de pago";
            this.btnTipoPago.UseVisualStyleBackColor = false;
            // 
            // btnProductoProveedores
            // 
            this.btnProductoProveedores.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProductoProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductoProveedores.Location = new System.Drawing.Point(8, 246);
            this.btnProductoProveedores.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnProductoProveedores.Name = "btnProductoProveedores";
            this.btnProductoProveedores.Size = new System.Drawing.Size(224, 79);
            this.btnProductoProveedores.TabIndex = 11;
            this.btnProductoProveedores.Text = "Gestión de proveedores y productos";
            this.btnProductoProveedores.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(14, 652);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(8, 6);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(224, 44);
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
            this.btnMarca.Location = new System.Drawing.Point(8, 186);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(224, 44);
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
            this.btnProductos.Location = new System.Drawing.Point(8, 59);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(224, 44);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Cola de Atención";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FormPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 750);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnEstadoPedido;
        private System.Windows.Forms.Button btnTipoPago;
        private System.Windows.Forms.Button btnProductoProveedores;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnProductos;
    }
}