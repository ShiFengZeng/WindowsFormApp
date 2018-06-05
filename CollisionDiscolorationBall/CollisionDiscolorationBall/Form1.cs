using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameItems;

namespace CollisionDiscolorationBall
{
    public partial class Form1 : Form
    {
        private Pen p;
        private Rectangle[] walls;
        private Block[] blocks;
        private Ball ball;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.p = new Pen(Color.Black);
            this.ball = new Ball(new Rectangle(25, 25, 15, 15), Color.Blue, 2, 2);
            this.walls = new Rectangle[4]
            {
                new Rectangle(10,10,10,240),
                new Rectangle(360,10,10,240),
                new Rectangle(20,10,340,10),
                new Rectangle(20,240,340,10)
            };
            this.blocks = new Block[3]
            {
                new Block(new Rectangle(90,70,20,20),Color.Red),
                new Block(new Rectangle(180,180,20,20),Color.Green),
                new Block(new Rectangle(270,70,20,20),Color.Blue)
            };
            timer1.Enabled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangles(this.p, this.walls);
            g.FillEllipse(new SolidBrush(this.ball.getColor()), this.ball.getPosition());
            for(int i = 0; i < this.blocks.Length; ++i)
            {
                Brush b = new SolidBrush(this.blocks[i].getColor());
                g.FillRectangle(b, this.blocks[i].getPosition());
            }

            g.Dispose();
            base.OnPaint(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                this.ball.IncreaseVx(-1);
            if (e.KeyCode == Keys.Right)
                this.ball.IncreaseVx(1);
            if (e.KeyCode == Keys.Up)
                this.ball.IncreaseVy(-1);
            if (e.KeyCode == Keys.Down)
                this.ball.IncreaseVy(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ball.Step();

            bool left_Collision = this.ball.getPosition().X <= this.walls[0].X + this.walls[0].Width;
            bool right_Collision = this.ball.getPosition().X + this.ball.getPosition().Width >= this.walls[1].X;
            bool top_Collision = this.ball.getPosition().Y <= this.walls[2].Y + this.walls[2].Height;
            bool bottom_Collision = this.ball.getPosition().Y + this.ball.getPosition().Height >= this.walls[3].Y;

            if (left_Collision || right_Collision)
                this.ball.CollisionVx();
            if (top_Collision || bottom_Collision)
                this.ball.CollisionVy();

            for(int i = 0; i < this.blocks.Length; ++i)
            {
                bool x_Inside1 = this.ball.getPosition().X + this.ball.getPosition().Width / 2 >= this.blocks[i].getPosition().X;
                bool x_Inside2 = this.ball.getPosition().X + this.ball.getPosition().Width / 2 <= this.blocks[i].getPosition().X + this.blocks[i].getPosition().Width;
                bool y_Inside1= this.ball.getPosition().Y + this.ball.getPosition().Height / 2 >= this.blocks[i].getPosition().Y;
                bool y_Inside2 = this.ball.getPosition().Y + this.ball.getPosition().Height / 2 <= this.blocks[i].getPosition().Y + this.blocks[i].getPosition().Height;

                if (x_Inside1 && x_Inside2 && y_Inside1 && y_Inside2)
                    this.ball.setColor(this.blocks[i].getColor());
            }
            this.Refresh();
        }
    }
}
