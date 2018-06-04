using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*private void addButton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            opLabel.Text = "+";
            ansLabel.Text = (a + b).ToString();
            }

        private void subButton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            opLabel.Text = "-";
            ansLabel.Text = (a - b).ToString();
        }

        private void MulButon_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            opLabel.Text = "*";
            ansLabel.Text = (a * b).ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            opLabel.Text = "/";
            ansLabel.Text = (a / b).ToString();
        }*/

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 08)
                    e.Handled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            char n;
            int a, b, c = 0;
            n = char.Parse((sender as Button).Text);
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            switch (n)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            opLabel.Text = (sender as Button).Text;
            label2.Text = c.ToString();
        }
    }
}
