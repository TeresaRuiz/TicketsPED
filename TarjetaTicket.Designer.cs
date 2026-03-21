namespace TicketsMDB
{
    partial class TarjetaTicket
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.Tarjetatickets = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tarjetatickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(17, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "id";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(19, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "usuario";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(17, 106);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(248, 60);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "descripcion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(17, 178);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "estado";
            // 
            // Tarjetatickets
            // 
            this.Tarjetatickets.Controls.Add(this.lblUsuario);
            this.Tarjetatickets.Controls.Add(this.lblEstado);
            this.Tarjetatickets.Controls.Add(this.lblID);
            this.Tarjetatickets.Controls.Add(this.lblDetalle);
            this.Tarjetatickets.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarjetatickets.Location = new System.Drawing.Point(3, 3);
            this.Tarjetatickets.Margin = new System.Windows.Forms.Padding(15);
            this.Tarjetatickets.Name = "Tarjetatickets";
            this.Tarjetatickets.Size = new System.Drawing.Size(262, 194);
            this.Tarjetatickets.TabIndex = 4;
            this.Tarjetatickets.TabStop = false;
            this.Tarjetatickets.Text = "Ticket";
            this.Tarjetatickets.Enter += new System.EventHandler(this.Tarjetatickets_Enter);
            // 
            // TarjetaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tarjetatickets);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "TarjetaTicket";
            this.Size = new System.Drawing.Size(270, 212);
            this.Tarjetatickets.ResumeLayout(false);
            this.Tarjetatickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox Tarjetatickets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
