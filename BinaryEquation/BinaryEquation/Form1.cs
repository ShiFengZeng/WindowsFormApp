using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(a1Text.Text);
            double b1 = double.Parse(b1Text.Text);
            double c1 = double.Parse(c1Text.Text);
            double a2 = double.Parse(a2Text.Text);
            double b2 = double.Parse(b2Text.Text);
            double c2 = double.Parse(c2Text.Text);

            double d = a1 * b2 - a2 * b1;
            double d2 = b1 * c2 - b2 * c1;
            double x, y;

            if (d == 0)
            {
                ansLabel.Text = "無解";
                if (d2 == 0)
                {
                    ansLabel.Text = "無限多組解";
                }
            }
            else
            {
                x = (c1 * b2 - c2 * b1) / d;
                y = (a1 * c2 - a2 * c1) / d;
                ansLabel.Text = string.Format("x = {0} \ny = {1}", x, y);
            }
        }
    }
}
