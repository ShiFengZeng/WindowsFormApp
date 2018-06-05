using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOXX
{
    public partial class Form1 : Form
    {
        private Pen black_Pen, red_Pen, blue_Pen;
        private bool[] isCircle, isCross;
        private int step;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            black_Pen = new Pen(Color.Black);
            red_Pen = new Pen(Color.Red);
            blue_Pen = new Pen(Color.Blue);
            Reset();
        }
                
        private void Reset()
        {
            this.isCircle = new bool[9];
            this.isCross = new bool[9];
            this.step = 0;
            for(int i = 0; i < 9; ++i)
            {
                this.isCircle[i] = false;
                this.isCross[i] = false;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || step == 9)
                Reset();
            else if (e.Button == MouseButtons.Left)
            {
                int num = e.X / 100 + 3 * (e.Y / 100);
                if (!this.isCircle[num] && !this.isCross[num])
                {
                    if (this.step % 2 == 0)
                        this.isCircle[num] = true;
                    else
                        this.isCross[num] = true;
                    ++step;                    
                }                
            }
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(this.black_Pen, 0, 100, 300, 100);
            g.DrawLine(this.black_Pen, 0, 200, 300, 200);
            g.DrawLine(this.black_Pen, 100, 0, 100, 300);
            g.DrawLine(this.black_Pen, 200, 0, 200, 300);

            for(int i = 0; i < 9; ++i)
            {
                int x = i % 3;
                int y = i / 3;
                if (this.isCircle[i])
                {
                    g.DrawEllipse(this.red_Pen, x * 100 + 5, y * 100 + 5, 90, 90);
                }
                else if (isCross[i])
                {
                    g.DrawLine(this.blue_Pen, x * 100 + 5, y * 100 + 5, (x + 1) * 100 - 5, (y + 1) * 100 - 5);
                    g.DrawLine(this.blue_Pen, (x + 1) * 100 - 5, y * 100 + 5, x * 100 + 5, (y + 1) * 100 - 5);
                }
                
            }
            
            g.Dispose();
            base.OnPaint(e);
        }
    }
}
