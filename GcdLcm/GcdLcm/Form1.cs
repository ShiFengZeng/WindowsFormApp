﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcdLcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            int integer1 = Convert.ToInt32(integerText1.Text);
            int integer2 = Convert.ToInt32(integerText2.Text);
            int remainder = integer1 % integer2;

            while (remainder != 0)
            {
                integer1 = integer2;
                integer2 = remainder;
                remainder = integer1 % integer2;
            }
            int gcd = integer2;
            gcdText.Text = gcd.ToString();

            int lcm = Convert.ToInt32(integerText1.Text) * Convert.ToInt32(integerText2.Text) / gcd;
            lcmText.Text = lcm.ToString();
        }

        private void integerText1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            }
        }

        private void integerText2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            }
        }
    }
}
