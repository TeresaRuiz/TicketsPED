namespace TicketsMDB
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bar_progres = new System.Windows.Forms.ProgressBar();
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.hide = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bar_progres
            // 
            this.bar_progres.BackColor = System.Drawing.Color.White;
            this.bar_progres.ForeColor = System.Drawing.Color.White;
            this.bar_progres.Location = new System.Drawing.Point(263, 504);
            this.bar_progres.Name = "bar_progres";
            this.bar_progres.Size = new System.Drawing.Size(542, 9);
            this.bar_progres.Step = 1;
            this.bar_progres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bar_progres.TabIndex = 1;
            // 
            // animation
            // 
            this.animation.Interval = 30;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // hide
            // 
            this.hide.Interval = 30;
            this.hide.Tick += new System.EventHandler(this.hide_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de tickets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar_progres);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar bar_progres;
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.Timer hide;
        private System.Windows.Forms.Label label1;
    }
}

