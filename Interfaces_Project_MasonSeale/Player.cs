using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class Player
    {
        public Position _playerpos;
        public int _x;
        public int _y;
        ConsoleColor _color;
        public Player(int x, int y, ConsoleColor color)
        {
            _playerpos = new Position(x, y);

            _color = color;

        }
        
    }
}
