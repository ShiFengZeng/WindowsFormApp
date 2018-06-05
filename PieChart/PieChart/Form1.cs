using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        private int c1, c2, c3;
        private Brush yellow_B, green_B, red_B;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.yellow_B = new SolidBrush(Color.Yellow);
            this.green_B = new SolidBrush(Color.Green);
            this.red_B = new SolidBrush(Color.Red);
        }


        private void candidateButton1_Click(object sender, EventArgs e)
        {
            ++this.c1;
            candidateText1.Text = this.c1.ToString();
            Refresh();
        }

        
        private void candidateButton2_Click(object sender, EventArgs e)
        {
            ++this.c2;
            candidateText2.Text = this.c2.ToString();
            Refresh();
        }

        private void candidateButton3_Click(object sender, EventArgs e)
        {
            ++this.c3;
            candidateText3.Text = this.c3.ToString();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(40, 10, 220, 220);
            if (this.c1 != 0)
                g.FillPie(yellow_B, r, 0.0f, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3));
            if (this.c2 != 0)
                g.FillPie(green_B, r, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3), 360.0f * this.c2 / (this.c1 + this.c2 + this.c3));
            if (this.c3 != 0)
                g.FillPie(red_B, r, 360.0f * (this.c1 + this.c2) / (this.c1 + this.c2 + this.c3), 360.0f * this.c3 / (this.c1 + this.c2 + this.c3));

            Pen p = new Pen(Color.Black);
            if (this.c1 >= this.c2 && this.c1 >= this.c3 && this.c1 != 0)
            {
                if (this.c2 == 0 && this.c3 == 0)
                    g.DrawArc(p, r, 0.0f, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3));
                else
                    g.DrawPie(p, r, 0.0f, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3));
            }

            else if (this.c2 >= this.c3 && this.c2 != 0)
            {
                if (this.c1 == 0 && this.c3 == 0)
                    g.DrawArc(p, r, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3), 360.0f * this.c2 / (this.c1 + this.c2 + this.c3));
                else
                    g.DrawPie(p, r, 360.0f * this.c1 / (this.c1 + this.c2 + this.c3), 360.0f * this.c2 / (this.c1 + this.c2 + this.c3));
            }
                
            else if (this.c3 != 0)
            {
                if (this.c1 == 0 && this.c2 == 0)
                    g.DrawArc(p, r, 360.0f * (this.c1 + this.c2) / (this.c1 + this.c2 + this.c3), 360.0f * this.c3 / (this.c1 + this.c2 + this.c3));
                else
                    g.DrawPie(p, r, 360.0f * (this.c1 + this.c2) / (this.c1 + this.c2 + this.c3), 360.0f * this.c3 / (this.c1 + this.c2 + this.c3));
            }
                
            g.Dispose();
            base.OnPaint(e);
        }


        private void candidateText1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            }
        }
        private void candidateText1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setNum(Convert.ToInt16(candidateText1.Text), Convert.ToInt16(candidateText2.Text), Convert.ToInt16(candidateText3.Text));
            }
        }
        private void setNum(int c1,int c2,int c3)
        {
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            Refresh();
        }
    }
}
