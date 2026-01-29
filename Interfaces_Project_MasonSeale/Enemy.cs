using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{
    internal class Enemy
    {
        public Position pos;
        ConsoleColor _color;
        IMoveStrategy _strat;
        public Enemy(int x, int y, ConsoleColor color)
        {
            pos = new Position(x,y);
            
            _color = color;
        }
        public void Movein(Player player)
        {

            _strat.Move(pos,player);
        }
        public void SetStrat(IMoveStrategy strat)
        {
            _strat = strat;
        }
        public ConsoleColor WhatColor()
        {
            return _color;
        }
        public IMoveStrategy WhatStrat()
        {
            return _strat;
        }
    }
}
