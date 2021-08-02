using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakesAndLadders.Services
{
    public interface IGameService
    {
        public int RollDice();

        public GameMatrix DrawGame();
    }

    public class GameMatrix
    {
        public int CurrentPositionUser1;

        public int CurrentPositionUser2;

        public int RollDice;

        public int[] DrawSequences;

        public int[] DrawLadders;

        public int[] DrawSnakes;

    }
}
