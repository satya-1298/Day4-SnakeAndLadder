using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class DiceRolling
    {
        public void Game()
        {
            int start_position = 0;
            int position = 0;
            int Count = 0;
            int Winning_Position = 100;

            while (position < Winning_Position) 
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("The dice rolled to " + dice);
                position += dice;
                Console.WriteLine("Position of the player = " + position);
                if(position == Winning_Position)
                {
                    Console.WriteLine("The player poisition is " + (position));

                    Console.WriteLine("GameOver");
                }
                else if(position> Winning_Position) 
                {
                   
                    Console.WriteLine("The player Remains in poisition  "+ start_position );
                }
               // Console.WriteLine("The player position moved to : " + position);
            }
            Console.WriteLine("The player position moved to : " + position);

        }
    }
}
