using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        int numberOfPitchers = 1;
        int checkNumberOfLemons;
        public int removeLemonsFromInventory;
        public int removeSugarFromInventory;
        public int removeIceFromInventory;
        public int removeCupFromInventory;
        public int ChooseNumberOfPitchers()
        {
            Console.WriteLine("We have the perfect recipe passed down from your great, great, great grandma Rosie!\n\n");
            Console.WriteLine("It contains 6 Lemons, 7 cups of sugar, 25 ice cubes making 10 cups of lemonade.\n\n");
            Console.WriteLine("How many pitchers do you want to make?");
            int numberOfPitchers = int.Parse(Console.ReadLine());
            return numberOfPitchers;
        }
        public int TakeLemonsOut(Player player)
        {
            removeLemonsFromInventory = (numberOfPitchers * 6);
            return removeLemonsFromInventory;
        }
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
        public void PlayRecipe(Player player)
        {
            TakeLemonsOut(player);
            TakeSugarOut(player);
            TakeIceOut(player);
            TakeCupOut(player);

        }
    }
}
