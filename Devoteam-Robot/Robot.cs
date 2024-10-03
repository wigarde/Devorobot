using System.Data;

namespace Devoteam_Robot
{
    internal class Robot
    {
        private int roomWidth;
        private int roomHeight;

        public int x { get; private set; }
        public int y { get; private set; }

        public Direction direction { get; private set; }


        public Robot(int roomWidth, int roomHeight, int startX, int startY, char direction)
        {
            this.roomWidth = roomWidth;
            this.roomHeight = roomHeight;
            x = startX; 
            y = startY;

            this.direction  = charToDirection(direction);
        }

        public void executeNavigation(char[] navigation)
        {
            foreach (char c in navigation)
            {
                switch (c)
                {
                    case 'L':
                        break;
                    case 'R':
                        break;
                    case 'F':
                        break;
                    default:
                        throw new Exception("Wrong input, only LRF is allowed");
                }
            }
        }

        private Direction charToDirection(char direction)
        {
            return direction switch
            {
                'N' => Direction.N,
                'E' => Direction.E,
                'S' => Direction.S,
                'W' => Direction.W,
                _ => throw new ArgumentException("Invalid direction")
            };
        }
    }
}
