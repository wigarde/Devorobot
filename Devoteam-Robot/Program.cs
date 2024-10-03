using Devoteam_Robot;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter room size as 'width height'");
        string roomSizeInput = Console.ReadLine();

        string[] roomSizes = roomSizeInput.Split();
        int width = int.Parse(roomSizes[0]);
        int height = int.Parse(roomSizes[1]);

        Console.WriteLine("Enter robot starting position and direction as '23N'");
        string positionInput = Console.ReadLine();
        string[] robotPosition = positionInput.Split();
        int x = int.Parse(robotPosition[0]);
        int y = int.Parse(robotPosition[1]);
        char direction = char.Parse(robotPosition[2]);


        Robot robot = new Robot(width, height, x, y, direction);
    }
}