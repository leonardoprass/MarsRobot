using MarsRobot.Application;
using System;
using Xunit;

namespace MarsRobot.Tests
{
    public class CreateGridTest
    {

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 4)]
        [InlineData(5, 5)]
        public void MatrixShouldHaveUserInputedSize(int rows, int columns)
        {
            int[,] matrix = Grid.CreateGrid(rows, columns);

            Assert.Equal(rows, matrix.GetLength(0));
            Assert.Equal(columns, matrix.GetLength(1));
        }

        [Fact]
        public void MatrixShouldBeAtleast1x1()
        {
            Action act = () => Grid.CreateGrid(0, 1);

            Assert.Throws<ArgumentException>(act);
        }
    }
}