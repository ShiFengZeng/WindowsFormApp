using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {

        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = (DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + DateTime.Now.Second);
            this.Text = t.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h, m, s;
            t = (t + 1) % (24 * 60 * 60);
            this.Text = t.ToString();
            s = t % 60;
            m = (t / 60) % 60;
            h = t / 60 / 60;
            secLabel.Text = s.ToString();
            minLabel.Text = m.ToString();
            hourLabel.Text = h.ToString();
        }
    }
}
