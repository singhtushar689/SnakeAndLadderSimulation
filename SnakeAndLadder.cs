using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulation
{
    public class SnakeAndLadder
    { 
        public void Game()
        {
            
            int initialPosition = 0;
            Console.WriteLine("Enter the Snake and Ladder Game");
            Console.WriteLine("Player is at position {0}", initialPosition);

            Random random = new Random();
            int rollingDice = random.Next(1, 7);
            Console.WriteLine("Number Shown randomly on dice is {0}",rollingDice);

        }
    }
}
