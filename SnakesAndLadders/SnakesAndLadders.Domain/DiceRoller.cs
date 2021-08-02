using System;

namespace SnakesAndLadders.Domain
{
    public class DiceRoller : IDiceRoller
    {
        public int RollDice()
        {
            return new Random().Next(1, 7);
        }
    }
}
