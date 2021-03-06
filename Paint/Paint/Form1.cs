﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private int x1, x2, y1, y2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.x1 = e.X;
                this.y1 = e.Y;
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.x2 = e.X;
                this.y2 = e.Y;
            }                
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p;
            if (redButton.Checked)
                p = new Pen(Color.Red);
            else if (greenButton.Checked)
                p = new Pen(Color.Green);
            else
                p = new Pen(Color.Blue);
          
            g.DrawLine(p, this.x1, this.y1, this.x2, this.y2);
            this.x1 = this.x2;
            this.y1 = this.y2;

            g.Dispose();
            base.OnPaint(e);
        }

    }
}
