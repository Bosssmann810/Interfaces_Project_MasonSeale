using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class PassiveStrategy
    {
        public Position Move(Position position, Player player)
        {
            if (position._x > player._playerpos._x)
            {
                position._x += 1;
            }
            if (position._x < player._playerpos._x)
            {
                position._x -= 1;
            }
            if (position._y > player._playerpos._y)
            {
                position._y += 1;
            }
            if (position._y < player._playerpos._y)
            {
                position._y -= 1;
            }

            return position;
        }

    }
}
