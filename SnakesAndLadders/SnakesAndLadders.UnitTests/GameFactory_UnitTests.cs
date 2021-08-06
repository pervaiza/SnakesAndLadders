using Moq;
using SnakesAndLadders.Domain;
using SnakesAndLadders.Services;
using System;
using Xunit;

namespace SnakesAndLadders.UnitTests
{
    public class GameFactory_UnitTests
    {

        [Fact]
        public void GameFactory_ApplyLadder()
        {
            var _ladder = new Mock<ILadder>();
            var _snake = new Mock<ISnake>();

            _ladder.Setup(x => x.GetPosition(3)).Returns(23);

            var gameFactory = new GameFactory(_ladder.Object,_snake.Object);

            var result =gameFactory.ApplyLadder(3);

            Assert.True(result == 23, "User position 3 moved to 23 using ladder");
        }

        [Fact]
        public void GameFactory_SnakeBites()
        {
            var _ladder = new Mock<ILadder>();
            var _snake = new Mock<ISnake>();

            _snake.Setup(x => x.GetPosition(50)).Returns(10);

            var gameFactory = new GameFactory(_ladder.Object, _snake.Object);

            var result = gameFactory.SnakeBite(50);

            Assert.True(result == 10, "User position 50 moved to 10 because of snake bite");
        }

    }
}
