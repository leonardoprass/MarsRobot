using MarsRobot.Application.Grid;
using System;

namespace MarsRobot.Tests
{
    internal class Board
    {
        public Robot Robot { get; set; }
        public int[,] Matrix { get; set; }

        internal void MoveRobot(string instructions)
        {
            throw new NotImplementedException();
        }

        internal string GetResult()
        {
            throw new NotImplementedException();
        }
    }
}