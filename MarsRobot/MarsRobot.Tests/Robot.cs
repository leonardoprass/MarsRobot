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
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Directions FacingDiretion { get; set; }

        internal void Move(string v)
        {
            throw new NotImplementedException();
        }
    }
}