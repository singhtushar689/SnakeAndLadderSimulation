using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulation
{
    public class SnakeAndLadder
    {
        public const int Ladder = 0;
        public const int Snake = 1;
        public const int Win = 100;
        public void Game()
        {
            int position = 0;
            int diceCount = 0;
            Console.WriteLine("Enter the Snake and Ladder Game");
            while (position < Win)
            {
                Random random = new Random();
                int rollingDice = random.Next(1, 7);
                int checkOption = random.Next(3);
                switch (checkOption)
                {
                    case Ladder:
                        if (position + rollingDice <= 100)
                        {
                            Console.WriteLine("It is Ladder");
                            position += rollingDice;
                        }
                        break;
                    case Snake:
                        if(position - rollingDice < 1)
                        {
                            Console.WriteLine("It is Snake ");
                            position = 0;
                        }
                        else
                        {
                            Console.WriteLine("It is Snake ");
                            position -= rollingDice;
                        }
                        break;
                    default:
                        break;       
                }
                diceCount++;
                Console.WriteLine("Dice Value is {0}",rollingDice);

                
                Console.WriteLine("It is {0}", checkOption);
                Console.WriteLine("Player is at {0}",position);
                
            }
            Console.WriteLine("Number of times dice rolled : {0}", diceCount);
        }
    }
}
