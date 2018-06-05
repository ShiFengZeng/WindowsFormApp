using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gameItems
{
    class Block
    {
        private Rectangle position;
        private Color color;

        public Block(Rectangle r,Color c)
        {
            this.position = r;
            this.color = c;
        }

        public Rectangle getPosition()
        {
            return this.position;
        }

        public Color getColor()
        {
            return this.color;
        }
    }
}
