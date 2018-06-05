using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunnerSpace;

namespace TurtleAndRabbitRace
{
    public partial class Form1 : Form
    {
        private Turtle turtle;
        private Rabbit rabbit;
        
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
            this.turtle = new Turtle(4, 3);
            this.rabbit = new Rabbit(15, 5);
            turtleLabel.Left = 12;
            rabbitLabel.Left = 12;
            startButton.Enabled = true;
            turtleButton.Enabled = true;
            rabbitButton.Enabled = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            turtleLabel.Left += this.turtle.Step();
            rabbitLabel.Left += this.rabbit.Step();
            if (turtleLabel.Left > 320)
            {
                timer1.Stop();
                if (turtleButton.Checked == true)
                    MessageBox.Show("烏龜贏了！ 恭喜你猜對了！");
                else
                    MessageBox.Show("烏龜贏了！ 可惜你猜錯了！");
                Reset();
            }
            else if (rabbitLabel.Left > 320)
            {
                timer1.Stop();
                if (rabbitButton.Checked == true)
                    MessageBox.Show("兔子贏了！ 恭喜你猜對了！");
                else
                    MessageBox.Show("兔子贏了！ 可惜你猜錯了！");
                Reset();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            turtleButton.Enabled = false;
            rabbitButton.Enabled = false;
            timer1.Start();
        }

       
    }
}
