using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            textBox3.Text = (Math.Sqrt(a * a + b * b)).ToString();
            textBox4.Text = (Math.Round(Math.Atan(b / a) * 180 / Math.PI, 2)).ToString();
        }
    }
}
