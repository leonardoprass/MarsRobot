using MarsRobot.Application.Grid;
using System;

namespace MarsRobot.Tests
{
    internal class Board
    {
        private const char ForwardCommand = 'F';
        private const char TurnRightCommand = 'R';
        private const char TurnLeftCommand = 'L';

        public Board(int rows, int columns)
        {
            Matrix = Grid.CreateMatrix(rows, columns);
            Robot = new Robot();
        }

        private Robot Robot { get; set; }
        private int[,] Matrix { get; set; }

        internal void Navigate(string instructions)
        {
            foreach (var command in instructions)
            {
                if (command == ForwardCommand)
                    Move();
                else ChangeDirection(command);
            }
        }

        private void ChangeDirection(char command)
        {
            if (command == TurnLeftCommand)
                Robot.FacingDiretion--;
            else if (command == TurnRightCommand)
                Robot.FacingDiretion++;
        }

        private void Move()
        {
            switch (Robot.FacingDiretion)
            {
                case Directions.North:
                    if (Robot.PositionX > 1)
                        Robot.PositionX--;
                    break;
                case Directions.South:
                    if (Robot.PositionX < Matrix.GetLength(0))
                        Robot.PositionX++;
                    break;
                case Directions.East:
                    if (Robot.PositionY < Matrix.GetLength(1))
                        Robot.PositionY++;
                    break;
                case Directions.West:
                    if (Robot.PositionY > 1)
                        Robot.PositionY--;
                    break;
            }
        }

        internal string GetResult()
        {
            return $"{Robot.PositionX},{Robot.PositionY},{Robot.FacingDiretion}";
        }
    }
}