using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesianCoordinates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x0 = 150, y0 = 150;  //原點

            xLine.X1 = x0 - 100;
            xLine.Y1 = y0;
            xLine.X2 = x0 + 100;
            xLine.Y2 = y0;

            yLine.X1 = x0;
            yLine.Y1 = y0 + 100;
            yLine.X2 = x0;
            yLine.Y2 = y0 - 100;

            aLine.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int x0 = 150, y0 = 150; //原點
            int x1, x2, y1, y2;

            x1 = int.Parse(x1Text.Text);
            y1 = int.Parse(y1Text.Text);

            x2 = int.Parse(x2Text.Text);
            y2 = int.Parse(y2Text.Text);

            label1.Text = "(" + x1 + "," + y1 + ")";
            label2.Text = "(" + x2 + "," + y2 + ")";

            x1 = 10 * x1 + x0;
            y1 = -10 * y1 + y0;     // Y軸相反所以*-1  5是放大倍數
            x2 = 10 * x2 + x0;
            y2 = -10 * y2 + y0;

            aLine.X1 = x1;
            aLine.Y1 = y1;     
            aLine.X2 = x2;
            aLine.Y2 = y2;

            if (x1 == x2)
            {
                label1.Left = x1 + 1;
                label1.Top = y1;
                label2.Left = x2 + 1;
                label2.Top = y2;
            }            
            else if (y1 == y2)
            {
                label1.Left = x1;
                label1.Top = y1 + 1;
                label2.Left = x2;
                label2.Top = y2 - 15;
            }
            else
            {
                label1.Left = x1;
                label1.Top = y1;
                label2.Left = x2;
                label2.Top = y2;
            }

            label1.Visible = true;
            label2.Visible = true;
            aLine.Visible = true;
        }
    }
}
