using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe //: IMixTogether
    {
        int numberOfPitchers;
        public int removeLemonsFromInventory;
        public int removeSugarFromInventory;
        public int removeIceFromInventory;
        public int removeCupFromInventory;

        public void DisplayRecipeWelcome(Game game)
        {
            Console.WriteLine("Now that you ran to the store, it's time to whip up a tasty patch of lemonade.");
            Console.WriteLine("You will need a minimum of 6 lemons, 7 cups of sugar, 20 ice cubes per pitcher, and 10 cups. ");
            Console.WriteLine("Do you need to run back to the store? [Y] Yes or [N]");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                game.store.Restock();//return to store.
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Alright! Let's make some lemonade!");
                Console.WriteLine("Please press 'enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public int ChooseNumberOfPitchers()
        {
            Console.WriteLine("We have the perfect recipe passed down from your great, great, great grandma Rosie!\n\n");
            Console.WriteLine("It contains 6 Lemons, 7 cups of sugar, 25 ice cubes making 10 cups of lemonade.\n\n");
            Console.WriteLine("How many pitches do you want to make?");
            int numberOfPitchers = int.Parse(Console.ReadLine());
            return numberOfPitchers;
        }
        public int TakeLemonsOut(Player player)
        {
            removeLemonsFromInventory = (numberOfPitchers * 6);
            return removeLemonsFromInventory;
        }
        //public void RemoveLemons(Player player)
        //{
        //    player.inventory.list
        //}
        public int TakeSugarOut(Player player)
        {
            removeSugarFromInventory = (numberOfPitchers * 7);
            return removeSugarFromInventory;
        }
        public int TakeIceOut(Player player)
        {
            removeIceFromInventory = (numberOfPitchers * 25);
            return removeIceFromInventory;
        }
        public int TakeCupOut(Player player)
        {
            removeCupFromInventory = (numberOfPitchers * 10);
            return removeCupFromInventory;
        }

        public void ChangeRecipe()
        {

        }
        public void MixLemon()
        {
            Console.WriteLine("Its time to mix in the lemons.");
        }
        public void PlayRecipe()
        {
             DisplayRecipeWelcome();
        }
    }
}
