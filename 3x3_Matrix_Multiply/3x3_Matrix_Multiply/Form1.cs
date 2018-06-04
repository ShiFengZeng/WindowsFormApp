using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3x3_Matrix_Multiply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            int[,] m1 = new int[3, 3];
            m1[0, 0] = int.Parse(m1Text1.Text);
            m1[0, 1] = int.Parse(m1Text2.Text);
            m1[0, 2] = int.Parse(m1Text3.Text);
            m1[1, 0] = int.Parse(m1Text4.Text);
            m1[1, 1] = int.Parse(m1Text5.Text);
            m1[1, 2] = int.Parse(m1Text6.Text);
            m1[2, 0] = int.Parse(m1Text7.Text);
            m1[2, 1] = int.Parse(m1Text8.Text);
            m1[2, 2] = int.Parse(m1Text9.Text);

            int[,] m2 = new int[3, 3];
            m2[0, 0] = int.Parse(m2Text1.Text);
            m2[0, 1] = int.Parse(m2Text2.Text);
            m2[0, 2] = int.Parse(m2Text3.Text);
            m2[1, 0] = int.Parse(m2Text4.Text);
            m2[1, 1] = int.Parse(m2Text5.Text);
            m2[1, 2] = int.Parse(m2Text6.Text);
            m2[2, 0] = int.Parse(m2Text7.Text);
            m2[2, 1] = int.Parse(m2Text8.Text);
            m2[2, 2] = int.Parse(m2Text9.Text);

            int[,] mr = new int[3, 3];
            for(int i = 0; i < 3; ++i)
            {
                for(int j = 0; j < 3; ++j)
                {
                    mr[i, j] += m1[i, 0] * m2[0, j];
                    mr[i, j] += m1[i, 1] * m2[1, j];
                    mr[i, j] += m1[i, 2] * m2[2, j];
                }
            }
            mrText1.Text = mr[0, 0].ToString();
            mrText2.Text = mr[0, 1].ToString();
            mrText3.Text = mr[0, 2].ToString();
            mrText4.Text = mr[1, 0].ToString();
            mrText5.Text = mr[1, 1].ToString();
            mrText6.Text = mr[1, 2].ToString();
            mrText7.Text = mr[2, 0].ToString();
            mrText8.Text = mr[2, 1].ToString();
            mrText9.Text = mr[2, 2].ToString();
        }

        private void m1Text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 08)
                    e.Handled = false;
            }
        }

        private void m1Text1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calButton_Click(sender, e);
        }
    }
}
