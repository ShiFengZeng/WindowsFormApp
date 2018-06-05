using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            for (int i = 0; i < 12; ++i)
                g.DrawArc(p, 10, 10, 280, 280, 360 * i / 12 - 5, 10f);
            float hour = DateTime.Now.Hour % 12 + DateTime.Now.Minute / 60f;
            g.DrawPie(p, 80, 80, 140, 140, 360 * (hour - 3) / 12, 2f);
            float minute = DateTime.Now.Minute + DateTime.Now.Second / 60;
            g.DrawPie(p, 60, 60, 180, 180, 360 * (minute - 15) / 60, 1f);
            float second = DateTime.Now.Second;
            g.DrawPie(p, 30, 30, 240, 240, 360 * (second - 15) / 60, 0.1f);
                
            g.Dispose();
            base.OnPaint(e);
        }
    }
}
