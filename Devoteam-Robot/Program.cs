using Devoteam_Robot;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter room size as '15 7'");
            string[] roomSizes = Console.ReadLine().Split();
            int width = int.Parse(roomSizes[0]);
            int height = int.Parse(roomSizes[1]);

            Console.WriteLine("Enter robot starting position and direction as '12 3 N'");
            string[] positionInput = Console.ReadLine().Split();
            int x = int.Parse(positionInput[0]);
            int y = int.Parse(positionInput[1]);
            char direction = char.Parse(positionInput[2]);

            Robot robot = new Robot(width, height, x, y, direction);

            Console.WriteLine("Enter navigation coommands as 'LRLRFFRLFRL'");
            char[] navigationCommands = Console.ReadLine().ToCharArray();

            robot.executeNavigation(navigationCommands);

        }

        catch (Exception ex) { 
            Console.WriteLine(ex.Message);
        }
    }
}