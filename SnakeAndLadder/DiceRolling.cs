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
            int position = 0;
            int Count = 0;
            Random random = new Random();
            int dice=random.Next(1,7);
            Console.WriteLine("The dice rolled to "+dice);
            position += dice;
            Console.WriteLine("Position of the player = " + position);
            Random ran = new Random();
            int c = ran.Next(3);
           
            switch (c)
            {

                case 1:
                    Console.WriteLine("It's ladder");
                    position += dice;
                    break;
                case 2:
                    Console.WriteLine("It's Sanke");
                    position -= dice;
                    break;
                default:
                    Console.WriteLine("No Play the player will be in same place");
                    break;

            }
            Console.WriteLine("The player position moved to : "+position);
        }
    }
}
