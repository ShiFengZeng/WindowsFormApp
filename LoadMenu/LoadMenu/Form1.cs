using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] price;

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.Default);

                menuList.Items.Clear();
                price = new int[int.Parse(sr.ReadLine())];

                for (int i = 0; !sr.EndOfStream; ++i) 
                {
                    string dish = "";
                    char ch = Convert.ToChar(sr.Read());
                    for (; ch != ','; ch = Convert.ToChar(sr.Read()))
                        dish += ch;
                    menuList.Items.Add(dish);
                    price[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
        }

        private void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceText.Text = price[menuList.SelectedIndex].ToString();
        }
    }
}
