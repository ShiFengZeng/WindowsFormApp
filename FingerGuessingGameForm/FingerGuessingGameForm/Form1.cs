using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerGuessingGameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playWin, computerWin, computerguessing;
        string player = "", computer="",result = "";        

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            player = "剪刀";
            Comparison(player);
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            player = "石頭";
            Comparison(player);
        }

        private void papperBUtton_Click(object sender, EventArgs e)
        {
            player = "布";
            Comparison(player);
        }

        private void Comparison(string a)
        {
            
            Random rnd = new Random();
            computerguessing = rnd.Next(0, 3);

            switch (a)
            {
                case "剪刀":                    
                    switch (computerguessing)
                    {
                        case 0:
                            computer = "剪刀";
                            result = "平手";
                            break;
                        case 1:
                            computer = "石頭";
                            result = "電腦贏";
                            ++computerWin;
                            break;
                        case 2:
                            computer = "布";
                            result = "玩家贏";
                            ++playWin;
                            break;
                    }
                    break;
                case "石頭":                    
                    switch (computerguessing)
                    {
                        case 0:
                            computer = "剪刀";
                            result = "玩家贏";
                            ++playWin;
                            break;
                        case 1:
                            computer = "石頭";
                            result = "平手";
                            break;
                        case 2:
                            computer = "布";
                            result = "電腦贏";
                            ++computerWin;
                            break;
                    }
                    break;
                case "布":
                    switch (computerguessing)
                    {
                        case 0:
                            computer = "剪刀";
                            result = "電腦贏";
                            ++computerWin;
                            break;
                        case 1:
                            computer = "石頭";
                            result = "玩家贏";
                            ++playWin;
                            break;
                        case 2:
                            computer = "布";
                            result = "平手";
                            break;
                    }
                    break;
            }
            playerWinLabel.Text = playWin.ToString();
            computerWinLabel.Text = computerWin.ToString();
            MessageBox.Show("玩家出："+player+"\n電腦出："+computer+"\n結果："+result);
        }


        
            
    }
}
