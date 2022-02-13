using MarsRobot.Domain;
using MarsRobot.Domain.Enums;

namespace MarsRobot.Application
{
    public class Board
    {
        private const char ForwardCommand = 'F';
        private const char TurnRightCommand = 'R';
        private const char TurnLeftCommand = 'L';

        private Robot _robot { get; set; }
        private int[,] _grid { get; set; }

        public Board(int rows, int columns)
        {
            _robot = new Robot();
            _grid = Grid.CreateGrid(rows, columns);
        }

        public void Navigate(string instructions)
        {
            foreach (var command in instructions)
            {
                if (command == ForwardCommand)
                    Move();
                else ChangeDirection(command);
            }
        }

        public string GetResult()
        {
            return $"{_robot.PositionX},{_robot.PositionY},{_robot.FacingDiretion}";
        }

        private void ChangeDirection(char command)
        {
            var currentDirection = _robot.FacingDiretion;
            if (command == TurnLeftCommand)
            {
                var newDirection = ((int)currentDirection + 3) % 4;
                _robot.FacingDiretion = (Directions)newDirection;
            }
            else if (command == TurnRightCommand)
            {
                var newDirection = ((int)currentDirection + 1) % 4;
                _robot.FacingDiretion = (Directions)newDirection;
            } 
        }

        private void Move()
        {
            switch (_robot.FacingDiretion)
            {
                case Directions.North:
                    if (_robot.PositionX > 1)
                        _robot.PositionX--;
                    break;
                case Directions.South:
                    if (_robot.PositionX < _grid.GetLength(0))
                        _robot.PositionX++;
                    break;
                case Directions.East:
                    if (_robot.PositionY < _grid.GetLength(1))
                        _robot.PositionY++;
                    break;
                case Directions.West:
                    if (_robot.PositionY > 1)
                        _robot.PositionY--;
                    break;
            }
        }

    }
}