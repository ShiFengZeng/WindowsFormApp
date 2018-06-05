using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleAreaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aText.Text);
            double b = double.Parse(bText.Text);
            double c = double.Parse(cText.Text);

            double t, d;
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (b > c)
            {
                t = b;
                b = c;
                c = t;
            }
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }

            if (a + b <= c)
            {
                styleLabel.Text = "無法構成三角形";
                areaLabel.Text = "";
                return;
            }

            if ((Math.Pow(a, 2) + Math.Pow(b, 2)) > Math.Pow(c, 2))
            {
                styleLabel.Text = "銳角三角形";
            }
            else
            {
                if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                    styleLabel.Text = "直角三角形";
                else
                    styleLabel.Text = "頓角三角形";
            }
            d = (a + b + c) / 2;
            areaLabel.Text = "其面積為：" + (Math.Sqrt(d * (d - a) * (d - b) * (d - c))).ToString();
        }
    }
}
