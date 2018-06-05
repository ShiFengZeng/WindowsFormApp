using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(xSquare.Text);
            int b = Convert.ToInt16(x.Text);
            int c = Convert.ToInt16(constant.Text);
            double key = Math.Pow(b, 2) - 4 * a * c;

            if (key < 0)
            {
                result.Text = ("此方程式無實數解！");
            }
            else if (key > 0)
            {
                double sol1 = (-b + Math.Sqrt(key)) / (2 * a);
                double sol2 = (-b - Math.Sqrt(key)) / (2 * a);
                result.Text = ("此方程式有兩實根" + sol1 + " 和 " + sol2);
            }
            else
            {
                double sol = -b / (2 * a);
                result.Text = ("此方程式有兩等根" + sol);
            }
        }

        private void xSquare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8 || e.KeyChar == 45)
                    e.Handled = false;
            }
        }

        private void x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8 || e.KeyChar == 45)
                    e.Handled = false;
            }
        }

        private void constant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8 || e.KeyChar == 45) 
                    e.Handled = false;
            }
        }
    }
}
