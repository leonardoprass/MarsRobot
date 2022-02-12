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
            int[,] matrix = CreateMatrix(rows, columns);

            Assert.Equal(matrix.GetLength(0), rows);
            Assert.Equal(matrix.GetLength(1), columns);
        }

        [Fact]
        public void MatrixShouldBeAtleast1x1()
        {
            Action act = () => CreateMatrix(0, 1);

            Assert.Throws<ArgumentException>(act);
        }

        private int[,] CreateMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Invalid plateau size.");

            return new int[rows, columns];
        }
    }
}