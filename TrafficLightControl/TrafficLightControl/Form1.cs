using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            greenLabel.Visible = true;
            yellowLabel.Visible = false;
            redLabel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = i.ToString();

            switch (i)
            {
                case 0:
                case 1:
                case 2:
                    greenLabel.Visible = true;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    break;
                case 3:
                case 5:
                    greenLabel.Visible = false;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    break;
                case 4:
                case 6:
                    greenLabel.Visible = true;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    break;
                case 7:
                case 9:
                    greenLabel.Visible = false;
                    yellowLabel.Visible = true;
                    redLabel.Visible = false;
                    break;
                case 8:
                case 10:
                    greenLabel.Visible = false;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    greenLabel.Visible = false;
                    yellowLabel.Visible = false;
                    redLabel.Visible = true;
                    break;
            }

            i = (i + 1) % 15;
        }

        
    }
}
