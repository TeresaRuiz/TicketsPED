using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsMDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.FromArgb(116, 31, 137);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            bar_progres.Maximum = 100;
            bar_progres.Value = 0;
            animation.Start();
        }

        private void hide_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                hide.Stop();
                FormRegistro menu = new FormRegistro();
                menu.Show();
                this.Hide();
            }
        }

        private void animation_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1) this.Opacity += 0.05;

            if (bar_progres.Value < bar_progres.Maximum)
            {
                bar_progres.Increment(1);
            }

            if (bar_progres.Value == bar_progres.Maximum)
            {
                animation.Stop();
                hide.Start();
            }
        }
    }
}
