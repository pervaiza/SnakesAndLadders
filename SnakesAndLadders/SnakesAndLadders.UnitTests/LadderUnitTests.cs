using SnakesAndLadders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SnakesAndLadders.UnitTests
{
    public class LadderUnitTests
    {

        [Theory]
        [InlineData(3, 23)]
        [InlineData(48, 68)]
        [InlineData(31, 71)]
        [InlineData(60, 90)]
        public void Ladder_GetPositions(int startPosition, int expectedPosition)
        {
            var ladder = new Ladder();

            var result = ladder.GetPosition(startPosition);

            Assert.Equal(expectedPosition, result);
        }

    }
}
