namespace Devoteam_Robot
{
    internal class Robot
    {
        private int roomWidth;
        private int roomHeight;

        private int x { get; set; }
        private int y { get; set; }

        private Direction direction { get; set; }


        public Robot(int roomWidth, int roomHeight, int startX, int startY, char direction)
        {
            this.roomWidth = roomWidth;
            this.roomHeight = roomHeight;
            x = startX; 
            y = startY;

            this.direction  = charToDirection(direction);
        }

        /// <summary>
        /// Executes the movements of the robots
        /// </summary>
        /// <param name="navigation">char array of navigation prompts</param>
        public void executeNavigation(char[] navigation)
        {
            foreach (char c in navigation)
            {
                switch (c)
                {
                    case 'L':
                        direction = leftMap[direction];
                        break;
                    case 'R':
                        direction = rightMap[direction];
                        break;
                    case 'F':
                        move();
                        break;
                    default:
                        throw new Exception("Wrong input, only 'L','R' or 'F' is allowed");
                }

                if (checkOutOfBounds())
                    throw new InvalidOperationException($"ERROR: Out of bounds at {x} {y}");
            }

            Console.WriteLine($"Current position (X, Y, Dir): {x} {y} {direction}");
        }

        /// <summary>
        /// Checks if the robot is out of bounds or not
        /// </summary>
        /// <returns>true if out of bounds, false otherwise</returns>
        private bool checkOutOfBounds()
        {
            if (x < 0 || x >= roomWidth)
                return true;
            if (y < 0 || y >= roomHeight)
                return true;
            return false;
        }

        /// <summary>
        /// Moves the robot if given the F command
        /// </summary>
        private void move()
        {
            (int deltaX, int deltaY) = moveMap[direction];
            x += deltaX;
            y += deltaY;
        }

        /// <summary>
        /// Fetches the correct direction from the Direction-enum from the given char-direction
        /// </summary>
        /// <param name="direction">direction to fetch enum for</param>
        /// <returns>The corresponding Direction for the given char-direction</returns>
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
