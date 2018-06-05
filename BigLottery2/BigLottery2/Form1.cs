using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigLottery2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[8];
        private void Form1_Load(object sender, EventArgs e)
        {
            int i, t, d;
            int[] c = new int[50]; //49個號碼 加上第0個索引不使用 共50個
            Random r = new Random();

            for (i = 1; i <= 49; ++i)
                c[i] = i;

            for (i = 1; i <= 49; ++i)
            {
                d = r.Next(1, 50);
                t = c[d];
                c[d] = c[i];
                c[i] = t;
            }

            for (i = 1; i <= 7; ++i)
                a[i] = c[i];
            label1.Text = a[1].ToString();
            label2.Text = a[2].ToString();
            label3.Text = a[3].ToString();
            label4.Text = a[4].ToString();
            label5.Text = a[5].ToString();
            label6.Text = a[6].ToString();
            label7.Text = a[7].ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int[] b = new int[7];
            int i, j;
            string s = "";
            bool special = false;
            int f = 0;  //中獎個數

            b[1] = int.Parse(textBox1.Text);
            b[2] = int.Parse(textBox2.Text);
            b[3] = int.Parse(textBox3.Text);
            b[4] = int.Parse(textBox4.Text);
            b[5] = int.Parse(textBox5.Text);
            b[6] = int.Parse(textBox6.Text);

            for (i = 1; i <= 6; ++i)            
                for (j = 1; j <= 6; ++j)                
                    if (a[i] == b[j])
                        f++;

            if (f == 5)
                for (i = 1; i <= 6; ++i)
                    if (b[i] == a[7])
                        special = true;

            switch (f)
            {
                case 6:
                    s = "頭獎";
                    break;
                case 5:
                    if (special)
                        s = "二獎";
                    else
                        s = "三獎";
                    break;
                case 4:
                    s = "四獎";
                    break;
                case 3:
                    s = "五獎";
                    break;
                case 2:
                case 1:
                case 0:
                    s = "槓龜";
                    break;
            }
            prizeLabel.Text = s;
        }
    }
}
