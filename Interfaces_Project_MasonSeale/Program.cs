using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces_Project_MasonSeale
{
    internal class Program
    {
        Player player;
        public void Main(string[] args)
        {
            player = new Player(x: 1, y: 1, color: ConsoleColor.Blue);
            
        }
    }
}
