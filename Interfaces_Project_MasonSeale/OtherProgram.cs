using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Project_MasonSeale
{

    internal class OtherProgram
    {
        Player player;
        Enemy enemy;
        static void Main(string[] args)
        {
            //had to instaniate a new program to get it to not complain about publics in a static field.
            var program = new OtherProgram();
            program.run();
        }
        //this is what i want it to do in on start
        public void run()
        {
            bool looping = true;
            player = new Player(x: 1, y: 1, color: ConsoleColor.Blue);
            enemy = new Enemy(x: 4, y: 4, ConsoleColor.Red);
            enemy.SetStrat(new RandomStrat());
            while (looping)
            {
                Console.SetCursorPosition(player._playerpos._x, player._playerpos._y);
                Console.BackgroundColor = player.WhatColor();
                Console.Write(" ");
                Console.SetCursorPosition(enemy.pos._x, enemy.pos._y);
                Console.BackgroundColor= enemy.WhatColor();
                Console.Write(" ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Press M to move the enemy, press I/O/P to change strat, Esc to quit");
                Console.WriteLine("I for Agressive, O for Random, P for Passive");
                Console.WriteLine($"Current strat: {enemy.WhatStrat()}");
                while (true) 
                {
                    ConsoleKeyInfo input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.M)
                    {
                        enemy.Movein(player);
                        break;
                    }
                    if (input.Key == ConsoleKey.I)
                    {
                        enemy.SetStrat(new AgressiveStrategy());
                        break;
                    }
                    if (input.Key == ConsoleKey.O)
                    {
                        enemy.SetStrat(new RandomStrat());
                        break;
                    }
                    if ((input.Key == ConsoleKey.P))
                    {
                        enemy.SetStrat(new PassiveStrategy());
                        break;
                    }
                    if(input.Key == ConsoleKey.Escape)
                    {
                        looping = false;
                        break;
                    }


                }
                Console.Clear();

            }
            
        }
    }
}
