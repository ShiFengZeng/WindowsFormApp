using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void surfaceButton_Click(object sender, EventArgs e)
        {
            double r2 = Math.Pow(double.Parse(radiusText.Text) , 2);
            resultText.Text = (4 * Math.PI * r2).ToString();
        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            double r3 = Math.Pow(double.Parse(radiusText.Text), 3);
            resultText.Text = (4 / 3 * Math.PI * r3).ToString();
        }

        private void radiusText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57 )
            {
                e.Handled = true;
                if (e.KeyChar == 08)
                    e.Handled = false;
            }
        }
    }
}
