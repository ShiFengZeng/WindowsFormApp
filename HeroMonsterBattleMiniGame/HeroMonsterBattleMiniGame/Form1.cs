using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterSpace;

namespace HeroMonsterBattleMiniGame
{
    public partial class Form1 : Form
    {
        private Monster monster;
        private Hero hero;
        private bool Attack_Mode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.hero = new Hero("勇者", 100, 20, 12, 20);
            this.monster = new Monster("怪物", 200, 25, 10, 10);
            this.Attack_Mode = false;
            logList.Items.Clear();
            Refresh_Mode();
        }

        private void Refresh_Mode()
        {
            if (this.hero.getHealth() <= 0)
            {
                MessageBox.Show("勇者輸了 請重新來過");
                Reset();
            }
            else if (this.monster.getHealth() <= 0)
            {
                MessageBox.Show("勇者成功打敗了怪物！");
                Reset();
            }

            this.Attack_Mode = !this.Attack_Mode;
            heroLabel.Text = "勇者狀態：\n" + this.hero.Print();
            monsterLabel.Text= "怪物狀態：\n" + this.monster.Print();
            attackButton.Enabled = this.Attack_Mode;
            powerButton.Enabled = this.Attack_Mode;
            defenseButton.Enabled = !this.Attack_Mode;
            dodgeButton.Enabled = !this.Attack_Mode;
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            logList.Items.Add(this.hero.Attack(this.monster));
            Refresh_Mode();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            logList.Items.Add(this.hero.Power_Attack(this.monster));
            Refresh_Mode();
        }

        private void defenseButton_Click(object sender, EventArgs e)
        {
            logList.Items.Add(this.monster.Attack(this.hero));
            Refresh_Mode();
        }

        private void dodgeButton_Click(object sender, EventArgs e)
        {
            this.hero.Double_Dodge();
            logList.Items.Add(this.monster.Attack(this.hero));
            this.hero.Half_Dodge();
            Refresh_Mode();
        }
    }
}
