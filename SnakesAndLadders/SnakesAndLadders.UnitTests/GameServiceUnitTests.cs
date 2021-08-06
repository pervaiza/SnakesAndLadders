using Moq;
using SnakesAndLadders.Domain;
using SnakesAndLadders.Services;
using System;
using Xunit;


namespace SnakesAndLadders.UnitTests
{
    public class GameServiceUnitTests
    {
        [Fact]
        public void Move()
        {
            //Arrange
            int diceValue = 1;
            var diceRoller = new Mock<IDiceRoller>();
            var gameFactory = new Mock<IGameFactory>();
            gameFactory.Setup(x => x.ApplyLadder(It.IsAny<int>())).Returns(diceValue);
            gameFactory.Setup(x => x.SnakeBite(It.IsAny<int>())).Returns(diceValue);

            //Act
            var gameService = new GameService(diceRoller.Object, gameFactory.Object);
            var result = gameService.Move(diceValue);


            //Assert
            Assert.Equal(diceValue, result.Position);

        }
    }
}
