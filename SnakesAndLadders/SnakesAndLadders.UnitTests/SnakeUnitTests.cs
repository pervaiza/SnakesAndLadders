using SnakesAndLadders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SnakesAndLadders.UnitTests
{
    public class SnakeUnitTests
    {

        [Theory]
        [InlineData(50, 10)]
        [InlineData(25, 1)]
        [InlineData(37, 5)]
        [InlineData(55, 11)]
        [InlineData(98, 20)]
        public void Snake_GetPositions(int startPosition, int expectedPosition)
        {
            var ladder = new Snake();

            var result = ladder.GetPosition(startPosition);

            Assert.Equal(expectedPosition, result);
        }

    }
}
