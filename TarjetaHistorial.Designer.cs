namespace TicketsMDB
{
    partial class TarjetaHistorial
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.pnlDot = new System.Windows.Forms.Panel();

            this.lblFechaLbl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlDiv1 = new System.Windows.Forms.Panel();

            this.lblEstadoLbl = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlDiv2 = new System.Windows.Forms.Panel();

            this.lblResponsableLbl = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();

            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            // USERCONTROL
            // ════════════════════════════════════════════════════════
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Size = new System.Drawing.Size(500, 100);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlLinea, this.pnlDot, this.pnlCard
            });

            // ── Línea vertical de timeline ────────────────────────────
            this.pnlLinea.Location = new System.Drawing.Point(10, 0);
            this.pnlLinea.Size = new System.Drawing.Size(2, 100);
            this.pnlLinea.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlLinea.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;

            // ── Dot del timeline ──────────────────────────────────────
            this.pnlDot.Location = new System.Drawing.Point(4, 20);
            this.pnlDot.Size = new System.Drawing.Size(14, 14);
            this.pnlDot.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);

            // ════════════════════════════════════════════════════════
            // CARD
            // ════════════════════════════════════════════════════════
            this.pnlCard.Location = new System.Drawing.Point(30, 4);
            this.pnlCard.Size = new System.Drawing.Size(468, 88);
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.pnlCard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFechaLbl,      this.lblFecha,      this.pnlDiv1,
                this.lblEstadoLbl,     this.lblEstado,     this.pnlDiv2,
                this.lblResponsableLbl,this.lblResponsable
            });

            // ── Fila 1: Fecha ─────────────────────────────────────────
            this.lblFechaLbl.Text = "FECHA";
            this.lblFechaLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFechaLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFechaLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaLbl.AutoSize = true;
            this.lblFechaLbl.Location = new System.Drawing.Point(12, 10);

            this.lblFecha.Text = "—";
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(80, 10);

            this.pnlDiv1.Location = new System.Drawing.Point(12, 28);
            this.pnlDiv1.Size = new System.Drawing.Size(444, 1);
            this.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlDiv1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;

            // ── Fila 2: Estado ────────────────────────────────────────
            this.lblEstadoLbl.Text = "ESTADO";
            this.lblEstadoLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblEstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoLbl.AutoSize = true;
            this.lblEstadoLbl.Location = new System.Drawing.Point(12, 36);

            this.lblEstado.Text = "—";
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(80, 36);

            this.pnlDiv2.Location = new System.Drawing.Point(12, 54);
            this.pnlDiv2.Size = new System.Drawing.Size(444, 1);
            this.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlDiv2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;

            // ── Fila 3: Responsable ───────────────────────────────────
            this.lblResponsableLbl.Text = "ENCARGADO";
            this.lblResponsableLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblResponsableLbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblResponsableLbl.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsableLbl.AutoSize = true;
            this.lblResponsableLbl.Location = new System.Drawing.Point(12, 62);

            this.lblResponsable.Text = "—";
            this.lblResponsable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResponsable.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblResponsable.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(80, 62);

            // ── Resume ─────────────────────────────────────────────────
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Panel pnlDot;
        private System.Windows.Forms.Label lblFechaLbl;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlDiv1;
        private System.Windows.Forms.Label lblEstadoLbl;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel pnlDiv2;
        private System.Windows.Forms.Label lblResponsableLbl;
        private System.Windows.Forms.Label lblResponsable;
    }
}