using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Season
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int month;
            month = int.Parse(monthText.Text);

            if (month < 1 || month > 12)
            {
                seasonText.Text = "無法判斷";
            }
            else
            {
                switch (month%3)
                {
                    case 1:
                        seasonText.Text = "孟";
                        break;
                    case 2:
                        seasonText.Text = "仲";
                        break;
                    case 0:
                        seasonText.Text = "季";
                        break;                        
                }
                switch ((month - 1) / 3)
                {
                    case 0:
                        seasonText.Text += "春";
                        break;
                    case 1:
                        seasonText.Text += "夏";
                        break;
                    case 2:
                        seasonText.Text += "秋";
                        break;
                    case 3:
                        seasonText.Text += "冬";
                        break;
                }
            }
        }

        private void monthText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 8)
                    e.Handled = false;
            }
        }

        private void seasonText_KeyPress(object sender, KeyPressEventArgs e)
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
