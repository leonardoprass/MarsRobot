namespace MarsRobot.Application
{
    public static class Grid
    {
        public static int[,] CreateGrid(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Invalid plateau size.");

            return new int[rows, columns];
        }
    }
}
