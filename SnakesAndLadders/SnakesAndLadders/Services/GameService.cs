using SnakesAndLadders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakesAndLadders.Services
{
    public class GameService : IGameService
    {
        IDiceRoller _diceRoller;
        IGameFactory _gameFactory;

        public GameService(IDiceRoller diceRoller,IGameFactory gameFactory)
        {
            _diceRoller = diceRoller;
            _gameFactory = gameFactory;
        }

        public GameMatrix DrawGame()
        {
            return new GameMatrix()
            {
                DrawLadders = _gameFactory.DrawLadders(),
                DrawSequences = _gameFactory.DrawSequences(),
                DrawSnakes = _gameFactory.DrawSnakes(),
            };
        }

        public int RollDice()
        {
            return _diceRoller.RollDice();
        }
    }
}
