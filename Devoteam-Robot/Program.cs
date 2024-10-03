using Devoteam_Robot;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter room size as 'width height'");
            string roomSizeInput = Console.ReadLine();

            string[] roomSizes = roomSizeInput.Split();
            int width = int.Parse(roomSizes[0]);
            int height = int.Parse(roomSizes[1]);

            Console.WriteLine("Enter robot starting position and direction as '23N'");
            char[] positionInput = Console.ReadLine().ToCharArray();
            int x = int.Parse(positionInput[0].ToString());
            int y = int.Parse(positionInput[1].ToString());
            char direction = positionInput[2];


            Robot robot = new Robot(width, height, x, y, direction);
        }

        catch (Exception ex) { 
            Console.WriteLine(ex.Message);
        }
    }
}