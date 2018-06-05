using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BentoStatistics
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            removeButton.Enabled = false;
            clearButton.Enabled = false;
            resultButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            orderList.Items.Add(menuCombo.Text);
            if (!removeButton.Enabled || !clearButton.Enabled || !resultButton.Enabled)
            {
                removeButton.Enabled = true;
                clearButton.Enabled = true;
                resultButton.Enabled = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedIndex != -1)
                orderList.Items.RemoveAt(orderList.SelectedIndex);

            if (orderList.Items.Count == 0)
            {
                removeButton.Enabled = false;
                clearButton.Enabled = false;
                resultButton.Enabled = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();
            removeButton.Enabled = false;
            clearButton.Enabled = false;
            resultButton.Enabled = false;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            int food1 = 0, food2 = 0, food3 = 0, food4 = 0, food5 = 0, food6 = 0, food7 = 0, food8 = 0;

            for (int i = 0; i < orderList.Items.Count; ++i)
            {
                if (orderList.Items[i].ToString() == "排骨飯")
                    ++food1;
                if (orderList.Items[i].ToString() == "雞腿飯")
                    ++food2;
                if (orderList.Items[i].ToString() == "控肉飯")
                    ++food3;
                if (orderList.Items[i].ToString() == "鱈魚飯")
                    ++food4;
                if (orderList.Items[i].ToString() == "豬腳飯")
                    ++food5;
                if (orderList.Items[i].ToString() == "滷肉飯")
                    ++food6;
                if (orderList.Items[i].ToString() == "肉燥飯")
                    ++food7;
                if (orderList.Items[i].ToString() == "燒肉飯")
                    ++food8;
            }
            resultLabel.Text = "排骨飯共" + food1 + "個" + Environment.NewLine;
            resultLabel.Text += "雞腿飯共" + food2 + "個" + Environment.NewLine;
            resultLabel.Text += "控肉飯共" + food3 + "個" + Environment.NewLine;
            resultLabel.Text += "鱈魚飯共" + food4 + "個" + Environment.NewLine;
            resultLabel.Text += "豬腳飯共" + food5 + "個" + Environment.NewLine;
            resultLabel.Text += "滷肉飯共" + food6 + "個" + Environment.NewLine;
            resultLabel.Text += "肉燥飯共" + food7 + "個" + Environment.NewLine;
            resultLabel.Text += "燒肉飯共" + food8 + "個";
        }        
    }
}
