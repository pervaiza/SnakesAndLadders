using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Domain
{
    public class GameFactory  : IGameFactory
    {

        public int[] DrawLadders()
        {
            return new int[10];
        }

        public int[] DrawSnakes()
        {
            return new int[10];
        }

    }
}
