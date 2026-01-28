using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class Position
    {
        int[] _pos = new int[2];
        public Position(int x, int y)
        {
            _pos[0] = x;
            _pos[1] = y;
            
        }
        public int[] givepos()
        {
            return _pos;
        }

    }
}
