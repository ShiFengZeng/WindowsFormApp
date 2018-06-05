using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace gameItems
{
    class Ball
    {
        private Rectangle position;
        private Color color;
        private int Vx, Vy;

        public Ball(Rectangle r,Color c,int x,int y)
        {
            this.position = r;
            this.color = c;
            this.Vx = x;
            this.Vy = y;
        }

        public void Step()
        {
            this.position.X += this.Vx;
            this.position.Y += this.Vy;
        }

        public Rectangle getPosition()
        {
            return this.position;
        }

        public Color getColor()
        {
            return this.color;
        }

        public void setColor(Color c)
        {
            this.color = c;
        }

        public void IncreaseVx(int i)
        {
            this.Vx += i;
        }

        public void IncreaseVy(int i)
        {
            this.Vy += i;
        }

        public void CollisionVx()
        {
            this.Vx *= -1;
        }

        public void CollisionVy()
        {
            this.Vy *= -1;
        }
    }
}
