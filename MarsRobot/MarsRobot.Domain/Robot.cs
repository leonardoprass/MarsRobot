using MarsRobot.Domain.Enums;

namespace MarsRobot.Domain
{
    public class Robot
    {
        public int PositionX { get; set; } = 1;
        public int PositionY { get; set; } = 1;
        public Directions FacingDiretion { get; set; } = Directions.North;
    }
}