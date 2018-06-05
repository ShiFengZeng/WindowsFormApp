using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarChart
{
    public partial class Form1 : Form
    {
        double l = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = lineShape1.X2 - lineShape1.X1;
        }

        private void startButton_Click(object sender, EventArgs e)
        {            
            double a = double.Parse(textBox1.Text);
            lineShape1.X2 = (int)(a / 100 * l) + lineShape1.X1;
        }       
    }
}
