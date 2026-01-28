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
        public int GivePosX()
        {
            return _pos[0];
        }
        public int GivePosY()
        {
            return _pos[1];
        }
        public void SetPosX(int newposx)
        {
            _pos[0] = newposx;
        }
        public void SetPosY(int newposy)
        {
            _pos[1] = newposy;
        }

    }
}
