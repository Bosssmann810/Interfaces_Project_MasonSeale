using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal interface IMoveStrategy 
    {
        Position Move(Position position, Player player);
        

    }
}
