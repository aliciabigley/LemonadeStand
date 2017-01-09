using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        int userInput;
        public int ChooseGameLenght()
        {
            Console.WriteLine("How many days would you like to run your stand? [7] [14]");
            int userInput = int.Parse(Console.ReadLine());
            this.userInput = userInput;
            return this.userInput;
        }
        public void DeterminGameLenght() //move to game class
        {
            
            if (userInput == 7)
            {
                for (int i = 0; i > 7; i++)
                {
                    //run game here
                }
            }
            if (userInput == 14)

                for (int i = 0; i > 14; i++)
                {
                    //run game here
                }
        }

    }
}
