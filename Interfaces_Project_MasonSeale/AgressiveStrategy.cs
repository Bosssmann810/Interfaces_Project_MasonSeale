using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class AgressiveStrategy : IMoveStrategy
    {
        int holder;
        public Position Move(Position position, Player player)
        {
            if (position.GivePosX() > player._playerpos.GivePosX())
            {
                holder = position.GivePosX();
                position.SetPosX(holder -= 1);
            }
            if (position.GivePosX() <= player._playerpos.GivePosX())
            {
                holder = position.GivePosX();
                position.SetPosX(holder += 1);
            }
            if (position.GivePosY() > player._playerpos.GivePosY())
            {
                holder = position.GivePosY();
                position.SetPosY(holder -= 1);
            }
            if (position.GivePosY() < player._playerpos.GivePosY())
            {
                holder = position.GivePosY();
                position.SetPosY(holder -= 1);
            }

            return position;
        }
        
    }
}
