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

        private Dictionary<Direction, Direction> leftMap = new Dictionary<Direction, Direction>
        {
            { Direction.N, Direction.W},
            { Direction.W, Direction.S},
            { Direction.S, Direction.E},
            { Direction.E, Direction.N}
        };

        private Dictionary<Direction, Direction> rightMap = new Dictionary<Direction, Direction>
        {
            { Direction.N, Direction.E},
            { Direction.E, Direction.S},
            { Direction.S, Direction.W},
            { Direction.W, Direction.N}
        };

        private Dictionary<Direction, (int deltaX, int deltaY)> moveMap = new Dictionary<Direction, (int deltaX, int deltaY)>
        {
            { Direction.N, (0, 1) },
            { Direction.E, (1, 0) },
            { Direction.S, (0, -1) },
            { Direction.W, (-1, 0) }
        };
    }
}
