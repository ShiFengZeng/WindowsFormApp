using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redOval.FillStyle = FillStyle.Solid;
            yellowOval.FillStyle = FillStyle.Transparent;
            greenOval.FillStyle = FillStyle.Transparent;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            redOval.FillStyle = FillStyle.Transparent;
            yellowOval.FillStyle = FillStyle.Solid;
            greenOval.FillStyle = FillStyle.Transparent;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            redOval.FillStyle = FillStyle.Transparent;
            yellowOval.FillStyle = FillStyle.Transparent;
            greenOval.FillStyle = FillStyle.Solid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redOval.FillStyle = FillStyle.Transparent;
            yellowOval.FillStyle = FillStyle.Transparent;
            greenOval.FillStyle = FillStyle.Transparent;
            redOval.FillColor = Color.Red;
            yellowOval.FillColor = Color.Yellow;
            greenOval.FillColor = Color.Green;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(redOval.FillStyle == FillStyle.Solid)
            {
                greenOval.FillStyle = FillStyle.Solid;
                redOval.FillStyle = FillStyle.Transparent;
                yellowOval.FillStyle = FillStyle.Transparent;
                changeButton.Text = "綠燈";
            }
            else if (yellowOval.FillStyle == FillStyle.Solid)
            {
                redOval.FillStyle = FillStyle.Solid;
                yellowOval.FillStyle = FillStyle.Transparent;
                greenOval.FillStyle = FillStyle.Transparent;
                changeButton.Text = "紅燈";
            }
            else if (greenOval.FillStyle == FillStyle.Solid)
            {
                yellowOval.FillStyle = FillStyle.Solid;
                greenOval.FillStyle = FillStyle.Transparent;
                redOval.FillStyle = FillStyle.Transparent;
                changeButton.Text = "黃燈";
            }
            else
            {
                greenOval.FillStyle = FillStyle.Solid;
                changeButton.Text = "綠燈";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (redOval.FillStyle == FillStyle.Solid)
            {
                greenOval.FillStyle = FillStyle.Solid;
                redOval.FillStyle = FillStyle.Transparent;
                yellowOval.FillStyle = FillStyle.Transparent;
            }
            else if (yellowOval.FillStyle == FillStyle.Solid)
            {
                redOval.FillStyle = FillStyle.Solid;
                yellowOval.FillStyle = FillStyle.Transparent;
                greenOval.FillStyle = FillStyle.Transparent;
            }
            else if (greenOval.FillStyle == FillStyle.Solid)
            {
                yellowOval.FillStyle = FillStyle.Solid;
                greenOval.FillStyle = FillStyle.Transparent;
                redOval.FillStyle = FillStyle.Transparent;
            }
            else
                greenOval.FillStyle = FillStyle.Solid;
        }

        private void autoChangeButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                autoChangeButton.Text = "On";
            }
                
            else if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                autoChangeButton.Text = "Off";
            }
        }        
    }
}
