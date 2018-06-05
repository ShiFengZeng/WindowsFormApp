using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        int min, max, answer, chances;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void guessText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guessButton_Click(sender, e);
            }
        }

        void Restart()
        {
            guessText.Text = "";
            min = 0;
            minText.Text = "0";
            max = 1000;
            maxText.Text = "1000";
            chances = 10;
            chanceLabel.Text = "還有10次機會";
            Random rnd = new Random();
            answer = rnd.Next(1, 1000);
        }
        
        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                int x = int.Parse(guessText.Text);
                if (Guess(x))
                {
                    result = MessageBox.Show("恭喜你猜中了！\n是否重新開始遊戲？", "訊息", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        Restart();
                    if (result == DialogResult.No)
                        this.Close();
                }
                else if (chances - 1 == 0) 
                {
                    result = MessageBox.Show("你已經用完所有機會了！\n是否重新開始遊戲？", "訊息", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        Restart();
                    if (result == DialogResult.No)
                        this.Close();
                }
                else
                    chanceLabel.Text = "還有" + --chances + "次機會";
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("您的猜測範圍不合理！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            guessText.Text = "";
        }
        bool Guess(int x)
        {
            if (x <= min || x >= max)
                throw new ArgumentOutOfRangeException();
            else if (x == answer)
                return true;
            else
            {
                if (x > answer)
                {
                    max = x;
                    maxText.Text = x.ToString();
                }
                else
                {
                    min = x;
                    minText.Text = x.ToString();
                }
                return false;
            }
        }
    }
}
