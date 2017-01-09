using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int numberOfPitchers;
        //int checkNumberOfLemons;
        public int removeLemonsFromInventory;
        public int removeSugarFromInventory;
        public int removeIceFromInventory;
        public int removeCupFromInventory;
        public int ChooseNumberOfPitchers()
        {
            Console.WriteLine("We have the perfect recipe passed down from your great, great, great grandma Rosie!\n\n");
            Console.WriteLine("It contains 6 Lemons, 7 cups of sugar, 25 ice cubes making 10 cups of lemonade.\n\n");
            Console.WriteLine("Things to keep in mind:");
            Console.WriteLine("1. The weather (the hotter it is the more cups you may sell)");
            Console.WriteLine("2. You can not save unused lemonade you did not sell the previous day.\n\n");
            Console.WriteLine("How many pitchers do you want to make?");
            int numberOfPitchers = int.Parse(Console.ReadLine());
            Console.WriteLine("You now have {0} cups of lemonade!!", (numberOfPitchers*10));
            return numberOfPitchers;
        }
        public int TakeLemonsOut(Player player)  //fix: do not allow negative numbers.
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
            ChooseNumberOfPitchers();
            TakeLemonsOut(player);
            TakeSugarOut(player);
            TakeIceOut(player);
            TakeCupOut(player);

        }
    }
}
