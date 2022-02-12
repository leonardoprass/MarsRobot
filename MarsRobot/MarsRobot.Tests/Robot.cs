using System;

namespace MarsRobot.Tests
{
    internal enum Directions
    {
        North,
        East,
        South,
        West
    }

    internal class Robot
    {
        public int PositionX { get; set; } = 1;
        public int PositionY { get; set; } = 1;
        public Directions FacingDiretion { get; set; } = Directions.North;
    }
}