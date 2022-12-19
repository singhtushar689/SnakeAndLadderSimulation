using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulation
{
    public class SnakeAndLadder
    {
        public const int ladder = 1;
        public const int snake = 2;
        public const int win = 100;
        public void Game()
        {
            int position = 0;
            Console.WriteLine("Enter the Snake and Ladder Game");
            while (position < win)
            {
                Random random = new Random();
                int rollingDice = random.Next(1, 7);
                int checkOption = random.Next(0, 3);
                switch (checkOption)
                {
                    case ladder:                    
                        position += rollingDice;
                        break;
                    case snake:
                        if(position - rollingDice < 1)
                        {
                            position = 0;
                        }
                        else
                        {
                            position -= rollingDice;
                        }
                        break;
                    default:
                        break;       
                }
                Console.WriteLine("Dice Value is {0}",rollingDice);
                Console.WriteLine("It is {0}", checkOption);
                Console.WriteLine("Player is at {0}",position);
            }
        }
    }
}
