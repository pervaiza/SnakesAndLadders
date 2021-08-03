using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Domain
{
    public class GameFactory  : IGameFactory
    {

        public int ApplyLadder(int postion)
        {
            if (postion == 3) return 23;
            if (postion == 19) return 39;
            if (postion == 48) return 68;
            if (postion == 31) return 71;
            if (postion == 60) return 90;
            else
                return postion;
        }

        public int SnakeBite(int postion)
        {
            if (postion == 50) return 10;
            if (postion == 25) return 1;
            if (postion == 37) return 5;
            if (postion == 55) return 11;
            if (postion == 98) return 20;
            else
                return postion;
        }

    }
}
