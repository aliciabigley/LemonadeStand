using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Random random;
        public Weather weather;
        public Player player;
        public Store store;
        public Day day;

        public Game()
        {
            random = new Random();
            weather  = new Weather(random);
            player = new Player();
            store = new Store();
            day = new Day();


        }
        public void RunGame()
        {
            DisplayWelcome();
            ShowClear();
            DisplayRules();
            ShowClear();
            day.ChooseGameLenght();
            ShowClear();
            weather.WeeklyWeather();
            store.Restock(player);
            player.recipe.PlayRecipe(player);

        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Your a buisnessman (or women) at heart and figure you'll try your hand at making as much money as posible over the next few days.\n\n");
            Console.WriteLine("After hours of brainstorming, you finally settled on runninig a lemonade stand.\n\n");
            Console.WriteLine("please hit 'enter' to continue.");
            Console.ReadLine();

        }
        //switch case here with options that take you to different classes
        public void DisplayRules()
        {
            Console.WriteLine("Welcome! My name is Alicia. I'm going to be giving you the lowdown on how to run a sucessful lemonade stand.\n\n");
            Console.WriteLine("First thing first. You are about to sell lemonaid in the busist part of Laguna Beach, CA!\n\n");
            Console.WriteLine("If you play your cards right, you can sell tons of lemonade every day.\n\n");
            Console.WriteLine("Every morning you will wake up and check the weather, brush your teeth, comb your hair, and get ready for the day.");
            Console.WriteLine("Then your check your inventory to see if you need run to the store to pick up more supplies.");
            Console.WriteLine("After that, you will determine the total number of cups of lemonade you want to make for the day. \n\n\n");
            Console.WriteLine("You only get to make one batch thoughtout the day. So if you make too little you risk selling out.");
            Console.WriteLine("Make too much and you will have leftovers which you CANNOT use the next day.\n\n\n");
            Console.WriteLine("Finally, you will set a the price per cup.");
            Console.WriteLine("Keep in mind that in all businesses you have start up costs and maintance costs. So you don't want to price your lemonade too low or too high.\n\n\n\n");
            Console.WriteLine("You will start with $10.00 in your pocket. Use it wisely!\n\n");
            Console.WriteLine("please hit 'enter' to continue.");
            Console.ReadLine();
            //Console.WriteLine("Would you like a game hint?\n\n");
            //Console.WriteLine("[Y] or [N]");
            //string userInput = Console.ReadLine().ToLower();
            //if(userInput == "y")
            //{
            //    Console.WriteLine("The weather will determine if you will have a busy or slow day at the ol' lemonade stand");
            //    Console.WriteLine("Hit 'enter' to continue");
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            //else if (userInput == "n")
            //{
            //    Console.Clear();
            //}
        }
        public void ShowClear()
        {
            Console.Clear();
        }
    }
}
