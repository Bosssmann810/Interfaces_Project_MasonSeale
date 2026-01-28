using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class Enemy
    {
        int _x;
        int _y;
        ConsoleColor _color;
        IMoveStrategy _strat;
        Enemy(int x, int y, ConsoleColor color)
        {
            _x = x;
            _y = y;
            _color = color;
        }
    }
}
