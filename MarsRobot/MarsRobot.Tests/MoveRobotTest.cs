using MarsRobot.Application;
using MarsRobot.Domain;
using MarsRobot.Domain.Enums;
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
            var board = new Board(4, 4);

            board.Navigate("L");

            Assert.NotEqual("North", board.GetResult().Substring(5));
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 4)]
        [InlineData(5, 5)]
        public void RobotShouldMoveBetweenGridLimits(int rows, int columns)
        {
            var board = new Board(rows, columns);

            board.Navigate("RFFFFFFFFFF");

            Assert.Equal(columns.ToString(), board.GetResult().Substring(2, 1));
        }

        [Fact]
        public void RobotShouldDisplayFinalPosition()
        {
            var board = new Board(5, 5);

            board.Navigate("FFRFLFLF");

            Assert.NotEqual("1,4,West", board.GetResult());
        }
    }
}