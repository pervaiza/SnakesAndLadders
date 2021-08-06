using Moq;
using SnakesAndLadders.Domain;
using SnakesAndLadders.Services;
using System;
using Xunit;

namespace SnakesAndLadders.UnitTests
{
    public class DiceRoller_UnitTests
    {

        [Fact]
        public void DiceRoller_Should_Return_Maximum_Value()
        {
            //Arrange
            var diceRoller = new Mock<IDiceRoller>();
            var gameFactory = new GameFactory(new Ladder(), new Snake());
            diceRoller.Setup(aa => aa.RollDice()).Returns(6);

            //Act
            var gameService = new GameService(diceRoller.Object, gameFactory);
            var result = gameService.RollDice();

            //Assert
            Assert.True(result.Position == 6);
        }

        [Fact]
        public void DiceRoller_Should_Return_Minimum_Value()
        {
            //Arrange
            var diceRoller = new Mock<IDiceRoller>();
            var gameFactory = new GameFactory(new Ladder(), new Snake());
            diceRoller.Setup(aa => aa.RollDice()).Returns(1);

            //Act
            var gameService = new GameService(diceRoller.Object,gameFactory);
            var result = gameService.RollDice();

            //Assert
            Assert.True(result.Position == 1);
        }

       
    }
}
