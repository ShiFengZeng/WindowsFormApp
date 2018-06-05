using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigLottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            TextBox[] textArray = new TextBox[] { nunText1, nunText2, nunText3, nunText4, nunText5, nunText6 };
            int[] numArray = new int[6];

            Random rnd = new Random();
            for(int i = 0; i < 6; ++i)
            {
                int num = rnd.Next(1, 50);
                while (!Check(ref numArray, num, i))
                    num = rnd.Next(1, 50);
                numArray[i] = num;
                textArray[i].Text = num.ToString();
            }
        }

        bool Check(ref int[] arr,int num,int pos)
        {
            for(int i = 0; i < pos; ++i)
            {
                if (num == arr[i])
                    return false;
                if (!continuousCheck.Checked)
                    if (num == arr[i] - 1 || num == arr[i] + 1)
                        return false;
            }
            return true;
        }
    }
}
