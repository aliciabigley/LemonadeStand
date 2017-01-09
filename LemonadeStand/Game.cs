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
            //DisplayRules();
            //day.ChooseGameLenght();
            //weather.WeeklyWeather();
            //store.Restock(player);
            //player.recipe.PlayRecipe(player);

        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Your a buisnessman (or women) at heart and figure you'll try your hand at making as much money as possible over the next few days.\n\n");
            Console.WriteLine("After hours of brainstorming, you finally settle on runninig a lemonade stand.\n\n");
            Console.WriteLine("You scrounged up $10.00 and will use this money to purchase ingredients from the store.");
            Console.WriteLine("please hit 'enter' to go to the main meun.");
            Console.ReadLine();
            Console.Clear();
            MainMenu();

        }
        public void MainMenu()
        {
            Console.WriteLine("Please type in the number of the menu item you would like to select.");
            Console.WriteLine("1: Rules\n\n2: Weather\n\n3: Check Wallet\n\n4: Run to the store\n\n5: Check inventory\n\n6: Check recipe, make Lemonade and set price.\n\n7: Play Game");
            string value = Console.ReadLine();
            switch (value)
            {
                //Rules
                case "1":
                    Console.Clear();
                    DisplayRules();

                    break;
                    //Weather- make sure it doesn't regenerate weather everytime you select weather
                case "2":
                    Console.Clear();
                    weather.WeeklyWeather();
                    Console.WriteLine("please hit 'enter' to go to the main meun.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                    //Wallet
                case "3":
                    Console.Clear();
                    player.wallet.DisplayBalance();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                    //store
                case "4":
                    Console.Clear();
                    store.Restock(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                    //inventory- show inventory
                case "5":
                    Console.Clear();
                    player.inventory.ShowAllProductInventory();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                    //pitchers- show how many items you need for a pitcher
                case "6":
                    Console.Clear();
                    player.recipe.PlayRecipe(player);
                    //player.recipe.ChooseNumberOfPitchers();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                    //play game- loop which reps the amount of days you want to play
                    //set price of cup of lemonade
                    // make customers
                    //each day show profit or loss
                case "7":
                    Console.Clear();
                    day.ChooseGameLenght();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                    //show profit or loss for the week

                default:
                    Console.WriteLine("Sorry, that we don't have an option for that.\n\n");
                    MainMenu();
                    break;
            }

        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome! My name is Alicia. I'm will be giving you the lowdown on how to run a sucessful lemonade stand.\n\n");
            Console.WriteLine("First things first. You're about to set up shop in the busist part of Laguna Beach, CA!\n\n");
            Console.WriteLine("If you play your cards right, you can sell tons of lemonade every day.\n\n");
            Console.WriteLine("Every morning you will wake up and check the weather, brush your teeth, comb your hair, and get ready for the day.");
            Console.WriteLine("Then your check your inventory to see if you need run to the store to pick up more supplies.");
            Console.WriteLine("After that, you will determine the total number of cups of lemonade you want to make for the day. \n\n\n");
            Console.WriteLine("You only get to make one batch thoughtout the day. So if you make too little you risk selling out.");
            Console.WriteLine("Make too much and you will have leftovers which you CANNOT use the next day.\n\n\n");
            Console.WriteLine("Finally, you will set a the price per cup.");
            Console.WriteLine("Keep in mind that in all businesses you have start up costs and maintance costs. So you don't want to price your lemonade too low or too high.\n\n\n\n");
            Console.WriteLine("please hit 'enter' to take you back to the menu.");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
    }
}
