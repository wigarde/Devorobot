using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam_Robot
{
    internal class Robot
    {
        private int roomWidth;
        private int roomHeight;
        private char direction;

        public int x { get; private set; }
        public int y { get; private set; }

        public Direction Direction { get; private set; }


        public Robot(int roomWidth, int roomHeight, int startX, int startY, char direction)
        {
            this.roomWidth = roomWidth;
            this.roomHeight = roomHeight;
            x = startX; 
            y = startY;

            this.direction = direction;
        }
    }
}
