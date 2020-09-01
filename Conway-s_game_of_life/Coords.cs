using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_game_of_life
{
    class Coords
    {
        public int X;
        public int Y;

        public Coords()
        {
            X = 0;
            Y = 0;
        }

        public Coords(int x ,int y)
        {
            X = x;
            Y = y;
        }
    }
}
