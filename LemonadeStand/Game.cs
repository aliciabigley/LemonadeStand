using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void RunGame()
        {
            DisplayWelcom();
            DisplayRules();

        }
        public void DisplayWelcom()
        {
            Console.WriteLine("Your a buisnessman (or women) at heart and figure you'll try your hand at making as much money as posible over the next few days.\n\n");
            Console.WriteLine("After hours of brainstorming, you finally settled on runninig a lemonaid stand.\n\n");
            Console.WriteLine("please hit 'enter' to continue.");
            Console.ReadLine();
            Console.WriteLine("Welcome! My name is Alicia. I'm going to be giving you the lowdown on how to run a sucessful lemonade stand.\n\n");
            Console.Clear();

        }

        public void DisplayRules()
        {
            Console.WriteLine("First thing first. You are about to sell lemonaid in the busist part of Laguna Beach, CA!\n\n");
            Console.WriteLine("If you play your cards right, you can sell tons of lemonade every day.\n\n");
            Console.WriteLine("Every morning you will wake up and check the weather, brush your teeth, comb your hair, and get ready for the day.");
            Console.WriteLine("Then your check your inventory to see if you need run to the store to pick up more supplies.");
            Console.WriteLine("After that, you will determine the total number of cups of lemonade you want to make for the day. \n\n\n");
            Console.WriteLine("You only get to make one batch thoughtout the day. So if you make too little you risk selling out.");
            Console.WriteLine("Make too much and you will have leftovers which you CANNOT use the next day.\n\n\n");
            Console.WriteLine("Finally, you will set a the price per cup.");
            Console.WriteLine("Keep in mind that in all businesses you have start up costs and maintance costs. So you don't want to price your lemonade too low or too high.\n\n\n\n");
            Console.WriteLine("Would you like a game hint?");
            Console.WriteLine("[Y] or [N]");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "y")
            {
                Console.WriteLine("The weather will determine if you will have a busy or slow day at the ol' lemonade stand");
                Console.WriteLine("Hit 'enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if (userInput == "n")
            {
                Console.Clear();
            }
        }
        public string GameLenght()
        {
            Console.WriteLine("How many days would you like to run your stand? [7] [14]");
            string userInput = Console.ReadLine();
            return userInput;
            int cycleNumber;
            Int32.TryParse(userInput, out cycleNumber);

            //Insert loop here cycle throught 6 or 13 times



        }
    }
}
