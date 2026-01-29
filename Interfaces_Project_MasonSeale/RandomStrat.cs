using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class RandomStrat : IMoveStrategy
    {
        Random rand = new Random();
        public Position Move(Position position, Player player)
        {
            int movedirection = rand.Next(1, 5);
            if (movedirection == 1)
            {
                position._x += 1;
            }
            if (movedirection == 2)
            {
                position._y += 1;
            }
            if(movedirection == 3)
            {
                position._x -= 1;
            }
            if (movedirection == 4)
            {
                position._y -= 1;
            }

            return position;
        }

    }
}
