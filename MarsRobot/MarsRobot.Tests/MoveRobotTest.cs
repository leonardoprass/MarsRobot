using MarsRobot.Application.Grid;
using Xunit;

namespace MarsRobot.Tests
{
    public class MoveRobotTest
    {

        [Fact]
        public void RobotShouldHaveAStartStatus()
        {
            var robot = new Robot();

            Assert.Equal(1, robot.PositionX);
            Assert.Equal(1, robot.PositionY);
            Assert.Equal(Directions.North, robot.FacingDiretion);
        }

        [Fact]
        public void WhenMovingLeftRobotShouldChangeFacingDirection()
        {
            int[,] matrix = Grid.CreateMatrix(4, 4);
            var robot = new Robot();
            var board = new Board
            {
                Robot = robot,
                Matrix = matrix
            };

            var oldDirection = robot.FacingDiretion;
            board.MoveRobot("L");

            Assert.NotEqual(oldDirection, robot.FacingDiretion);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 4)]
        [InlineData(5, 5)]
        public void RobotShouldMoveBetweenGridLimits(int rows, int columns)
        {
            int[,] matrix = Grid.CreateMatrix(rows, columns);
            var robot = new Robot();
            var board = new Board
            {
                Robot = robot,
                Matrix = matrix
            };

            board.MoveRobot("LFFFFFFFFFF");

            Assert.Equal(columns, matrix.GetLength(1));
        }

        [Fact]
        public void RobotShouldDisplayFinalPosition()
        {
            int[,] matrix = Grid.CreateMatrix(5, 5);
            var robot = new Robot();
            var board = new Board
            {
                Robot = robot,
                Matrix = matrix
            };

            board.MoveRobot("FFRFLFLF");

            Assert.NotEqual("1,4,West", board.GetResult());
        }
    }
}