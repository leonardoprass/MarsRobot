using Xunit;

namespace MarsRobot.Tests
{
    public class CreateGridTest
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(3,4)]
        [InlineData(5,5)]
        public void MatrixShouldHaveUserInputedSize(int rows, int columns)
        {
            int[,] matrix = CreateMatrix(rows, columns);

            Assert.Equal(matrix.GetLength(0), rows);
            Assert.Equal(matrix.GetLength(1), columns);
        }

        private int[,] CreateMatrix(int rows, int columns)
        {
            throw new System.NotImplementedException();
        }
    }
}