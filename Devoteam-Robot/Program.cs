using Devoteam_Robot;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter room size as 'width height'");
        string roomSizeInput = Console.ReadLine();

        string[] roomSizes = roomSizeInput.Split();
        int width = int.Parse(roomSizes[0]);
        int height = int.Parse(roomSizes[1]);  

        Robot robot = new Robot(width, height, 2, 3, Direction.N);
    }
}