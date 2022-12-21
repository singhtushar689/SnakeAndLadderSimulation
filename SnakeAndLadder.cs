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
            int position1 = 0;
            int position2 = 0;
            int diceCount = 0;
            int diceCount1 = 0;
            bool player1 = true;
            bool player2 = false;
            Console.WriteLine("Welcome to the Snake and Ladder Game");
            while (position1 < Win && position2 < Win)
            {
                if (player1)
                {
                    Random random = new Random();
                    int rollingDice = random.Next(1, 7);
                    int checkOption = random.Next(3);
                    switch (checkOption)
                    {
                        case Ladder:
                            if (position1 + rollingDice <= 100)
                            {
                                Console.WriteLine("It is Ladder");
                                position1 += rollingDice;
                            }
                            player1 = true;
                            break;
                        case Snake:
                            Console.WriteLine("It is Snake");
                            if (position1 - rollingDice < 1)
                            {
                                position1 = 0;
                            }
                            else
                            {
                                position1 -= rollingDice;
                            }
                            player2 = false;
                            player1 = true;
                            break;
                        default:
                            player2 = true;
                            player1 = false;
                            break;
                    }
                    diceCount++;
                    Console.WriteLine("Dice Value is {0}", rollingDice);


                    Console.WriteLine("It is {0}", checkOption);
                    Console.WriteLine("Player1 is at {0}", position1);
                }
                else
                {
                    Random random = new Random();
                    int rollingDice = random.Next(1, 7);
                    int checkOption = random.Next(3);
                    switch (checkOption)
                    {
                        case Ladder:
                            if (position2 + rollingDice <= 100)
                            {
                                Console.WriteLine("It is Ladder");
                                position2 += rollingDice;
                            }
                            player2 = true;
                            break;
                        case Snake:
                            Console.WriteLine("It is Snake");
                            if (position2 - rollingDice < 1)
                            {
                                position2 = 0;
                            }
                            else
                            {
                                position2 -= rollingDice;
                            }
                            player1 = false;
                            player2 = true;
                            break;
                        default:
                            player1 = true;
                            player2 = false;
                            break;
                    }
                    Console.WriteLine("Dice Value is {0}", rollingDice);
                    Console.WriteLine("It is {0}", checkOption);
                    Console.WriteLine("Player2 is at {0}", position2);
                }
            }
            if (position1 > position2)
            {
                Console.WriteLine("Player1 won the game");
            }
            else
            {
                Console.WriteLine("Player2 won the game");
            }

        }
    }
}
    
        
        
        
     
        
        
        
        
        
    












