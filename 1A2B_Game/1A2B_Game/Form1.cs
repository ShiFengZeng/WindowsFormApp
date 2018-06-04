using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B_Game
{
    public partial class Form1 : Form
    {

        int[] ansArray = new int[4];
        TextBox[] guessText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guessText = new TextBox[4] { numText1, numText2, numText3, numText4 };
            Reset();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            logList.Items.Clear();
            Random rnd = new Random();
            for(int i = 0; i < 4; ++i)
            {
                guessText[i].Text = "";
                bool repect = false;
                do
                {
                    ansArray[i] = rnd.Next(0, 10);
                    for (int j = 0; j < i; ++j)
                        if (ansArray[i] == ansArray[j])
                            repect = true;
                } while (repect);
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                Check();
                int a = 0, b = 0;
                for (int i = 0; i < 4; ++i)
                {
                    int num = int.Parse(guessText[i].Text);
                    for (int j = 0; j < 4; ++j)
                        if (num == ansArray[j])
                            if (i == j)
                                a++;
                            else
                                b++;
                }
                if (a == 4)
                {
                    MessageBox.Show("恭喜您猜對了！");
                    Reset();
                }
                else
                {
                    string log = "";
                    for (int i = 0; i < 4; ++i)
                        log += guessText[i].Text;
                    logList.Items.Add(log + " -> " + a + "A" + b + "B");
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("您輸入的數字範圍有誤");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("您輸入的數字有重複");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Check()
        {
            for (int i = 0; i < 4; ++i)
            {
                int num = int.Parse(guessText[i].Text);
                if (num < 0 || num > 10)
                    throw new ArgumentOutOfRangeException();

                for (int j = 0; j < i; ++j)
                    if (guessText[i].Text == guessText[j].Text)
                        throw new ArgumentException();
            }
        }

        private void numText1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
                if (e.KeyChar == 08)
                    e.Handled = false;
            }
        }
    }
}
