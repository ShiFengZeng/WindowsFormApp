using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = (float.Parse(Val1.Text) + float.Parse(Val2.Text)).ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = (float.Parse(Val1.Text) - float.Parse(Val2.Text)).ToString();
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = (float.Parse(Val1.Text) * float.Parse(Val2.Text)).ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = (float.Parse(Val1.Text) / float.Parse(Val2.Text)).ToString();
        }

        private void eqlButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = float.Parse(Val1.Text) == float.Parse(Val2.Text) ? "是，兩值相等" : "否，兩值不相等";
        }

        private void noteqlButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = float.Parse(Val1.Text) != float.Parse(Val2.Text) ? "是，兩值不相等" : "否，兩值相等";
        }

        private void biggerButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = float.Parse(Val1.Text) > float.Parse(Val2.Text) ? "是，" + Val1.Text + "大於" + Val2.Text : "否，" + Val1.Text + "不大於" + Val2.Text;
        }

        private void smallerButton_Click(object sender, EventArgs e)
        {
            resultVal.Text = float.Parse(Val1.Text) < float.Parse(Val2.Text) ? "是，" + Val1.Text + "小於" + Val2.Text : "否，" + Val1.Text + "不小於" + Val2.Text;
        }
    }
}
